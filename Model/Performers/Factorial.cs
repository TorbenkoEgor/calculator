using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class Factorial : IPerformer
    {
        public void Perform(HistoryData data, double input, IPresenter presenter)
        {
            if (data.list.Count == 0)
            {
                presenter.ShowStatus(0, "");
                return;
            }

            double[] old = data.Current();
            double[] block = new double[old.Length];

            for (uint i = 0; i < block.Length; ++i)
            {
                if (old[i] < 0 || Math.Floor(old[i]) != old[i])
                {
                    presenter.ShowStatus(0, "Bad number.");
                    return;
                }

                block[i] = 1;

                for (double f = old[i]; f > 1; --f)
                    block[i] *= f;

                if ((i + 1) % 100 == 0 || i + 1 == block.Length)
                    presenter.ShowStatus((double)(i + 1) / block.Length, "Performing factorial.");
            }

            data.Add(block);
            presenter.ShowStatus(1, "Factorial done.");
        }
    }
}
