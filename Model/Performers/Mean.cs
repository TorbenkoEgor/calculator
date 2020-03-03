using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class Mean : IPerformer
    {
        public void Perform(HistoryData data, double input, IPresenter presenter)
        {
            if (data.list.Count == 0)
            {
                presenter.ShowStatus(0, "");
                return;
            }

            double[] old = data.Current();
            double[] block = new double[1]{ 0 };

            for (uint i = 0; i < block.Length; ++i)
            {
                block[0] += old[i];

                if ((i + 1) % 100 == 0 || i + 1 == block.Length)
                    presenter.ShowStatus((double)(i + 1) / block.Length, "Performing mean.");
            }

            if(block.Length > 0)
                block[0] /= block.Length;

            data.Add(block);
            presenter.ShowStatus(1, "Calculating mean done.");
        }
    }
}
