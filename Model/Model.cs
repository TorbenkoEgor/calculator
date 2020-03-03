using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Model
{
    public class Model : IModel
    {
        private IKernel kernel;
        private IPresenter presenter;
        private HistoryData historyData;
        private SortedDictionary<String, IPerformer> operations;
        public Model(IKernel kernel)
        {
            this.kernel = kernel;
            this.presenter = kernel.Get<IPresenter>();
            this.historyData = new HistoryData();
            this.operations = new SortedDictionary<String, IPerformer>();
            this.operations.Add("assign", new Performers.Assigner());
            this.operations.Add("clone", new Performers.Cloner());
            this.operations.Add("divide", new Performers.Divider());
            this.operations.Add("factorial", new Performers.Factorial());
            this.operations.Add("log", new Performers.Logarithm());
            this.operations.Add("mean", new Performers.Mean());
            this.operations.Add("minus", new Performers.Minus());
            this.operations.Add("multiply", new Performers.Multiply());
            this.operations.Add("plus", new Performers.Plus());
            this.operations.Add("power", new Performers.Power());
            this.operations.Add("repeat", new Performers.Repeater());
            this.operations.Add("reset", new Performers.Reseter());
            this.operations.Add("root", new Performers.Root());
            this.operations.Add("sqrt", new Performers.Sqrt());
            this.operations.Add("square", new Performers.Square());
            this.operations.Add("stddev", new Performers.StdDev());
            this.operations.Add("undo", new Performers.Undoer());
        }

        public void PerformOperation(String action, double argument)
        {
            try
            {
                operations[action].Perform(historyData, argument, presenter);
                presenter.ShowHistory(historyData);
            }
            catch (KeyNotFoundException)
            {
                presenter.ShowStatus(0, "Bad operation.");
            }
        }

        public void FileOperation(String action, String argument)
        {
            if (action == "save")
            {
                new FileOperators.Saver().Perform(historyData, argument, presenter);
            }

            if (action == "load")
            {
                new FileOperators.Loader().Perform(historyData, argument, presenter);
            }
        }

        public void RestoreHistory(int pointer)
        {
            if (pointer >= historyData.list.Count)
                presenter.ShowStatus(0, "Bad history point for Restore History");
            else
            {
                historyData.pointer = pointer;
                presenter.ShowHistory(historyData);
            }
        }
    }
}
