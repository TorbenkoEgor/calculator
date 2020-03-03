using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class Repeater : IPerformer
    {
        public void Perform(HistoryData data, double input, IPresenter presenter)
        {
            if (data.list.Count == 0 || data.pointer + 1 == data.list.Count)
            {
                presenter.ShowStatus(0, "Bad state.");
                return;
            }

            data.pointer++;
            presenter.ShowStatus(1, "Previous operation is done.");
        }
    }
}
