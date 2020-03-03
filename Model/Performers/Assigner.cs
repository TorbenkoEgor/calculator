using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class Assigner : IPerformer
    {
        public void Perform(HistoryData data, double input, IPresenter presenter)
        {
            double[] block = new double[1] { input };
            data.Add(block);
            presenter.ShowStatus(1, "Assign done.");
        }
    }
}
