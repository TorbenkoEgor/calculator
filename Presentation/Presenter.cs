using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    class Presenter : Model.IPresenter, View.IPresenter
    {
        private IKernel kernel;
        private Model.IModel model;
        private View.IView view;

        public Presenter(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public void Bind()
        {
            this.model = kernel.Get<Model.IModel>();
            this.view = kernel.Get<View.IView>();
        }

        public void PerformAction(string action, string argument)
        {
            double input;

            if (argument.Length == 0)
                input = 0;
            else if (!Double.TryParse(argument, out input))
            {
                view.ShowStatus(0, "Bad argument.");
                return;
            }

            view.ShowStatus(0, "Start.");

            model.PerformOperation(action, input);
        }

        public void RestoreHistory(int pointer)
        {
            view.ShowStatus(0, "Start.");
            model.RestoreHistory(pointer);
        }

        public void FileOperation(String action, String argument)
        {
            model.FileOperation(action, argument);
        }

        public void ShowHistory(Model.HistoryData data)
        {
            var list = new List<String>();

            uint p = 0;
            foreach (var d in data.list)
            {
                String s = p.ToString() + ":" + d.Length.ToString() + " => [";

                ++p;

                for (uint i = 0; i < d.Length; ++i)
                {
                    if (s.Length + d[i].ToString().Length > 130)
                    {
                        s += "...";
                        break;
                    }

                    s += d[i].ToString();

                    if (i + 1 < d.Length)
                        s += ", ";
                }

                s += "]";

                list.Add(s);
            }

            view.ShowHistory(list, data.pointer);
        }

        public void ShowStatus(double percent, string status)
        {
            view.ShowStatus(percent, status);
        }
    }
}
