using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class Divider : IPerformer
    {
        public void Perform(HistoryData data, double input, IPresenter presenter)
        {
            if (data.list.Count == 0)
            {
                presenter.ShowStatus(0, "");
                return;
            }

            if (input == 0)
            {
                presenter.ShowStatus(0, "Bad argument.");
                return;
            }

            double[] old = data.Current();
            double[] block = new double[old.Length];

            for (uint i = 0; i < block.Length; ++i)
            {
                block[i] = old[i] / input;

                if ((i + 1) % 100 == 0 || i + 1 == block.Length)
                    presenter.ShowStatus((double)(i + 1) / block.Length, "Performing divide.");
            }

            data.Add(block);
            presenter.ShowStatus(1, "Divide done.");
        }
    }
}
