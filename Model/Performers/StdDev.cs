using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class StdDev : IPerformer
    {
        public void Perform(HistoryData data, double input, IPresenter presenter)
        {
            if (data.list.Count == 0)
            {
                presenter.ShowStatus(0, "");
                return;
            }

            double[] old = data.Current();
            double[] block = new double[1] { 0 };
            double m2 = 0;

            for (uint i = 0; i < old.Length; ++i)
            {
                block[0] += old[i];
                m2 += old[i] * old[i];

                if ((i + 1) % 100 == 0 || i + 1 == block.Length)
                    presenter.ShowStatus((double)(i + 1) / block.Length, "Performing stddev.");
            }

            if (block.Length > 0)
            {
                block[0] /= block.Length;
                block[0] *= block[0];

                m2 /= block.Length;

                block[0] = Math.Sqrt(m2 - block[0]);
            }

            data.Add(block);
            presenter.ShowStatus(1, "Calculating stddev done.");
        }
    }
}
