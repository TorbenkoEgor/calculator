using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class Reseter : IPerformer
    {
        public void Perform(HistoryData data, double input, IPresenter presenter)
        {
            data.Reset();
            presenter.ShowStatus(1, "Resetted.");
        }
    }
}
