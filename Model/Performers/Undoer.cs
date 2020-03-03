using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class Undoer : IPerformer
    {
        public void Perform(HistoryData data, double input, IPresenter presenter)
        {
            if (data.list.Count == 0 || data.pointer == 0)
            {
                presenter.ShowStatus(0, "Bad state.");
                return;
            }

            data.pointer--;
            presenter.ShowStatus(1, "Undone.");
        }
    }
}
