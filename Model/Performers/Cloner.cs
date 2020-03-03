using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Performers
{
    class Cloner : IPerformer
    {
        public void Perform(HistoryData data, double input, IPresenter presenter)
        {
            if (data.list.Count == 0)
            {
                presenter.ShowStatus(0, "");
                return;
            }

            int mult = (int)Math.Floor(input);

            double[] old = data.Current();

            if (mult != input || input < 0 || old.Length * mult > 2e9)
            {
                presenter.ShowStatus(0, "Bad argument");
                return;
            }

            double[] block = new double[old.Length * mult];

            for (uint i = 0; i < old.Length; i++)
            {
                for (uint j = 0; j < mult; j++)
                    block[j * old.Length + i] = old[i];

                if ((i + 1) % 100 == 0 || i + 1 == block.Length)
                    presenter.ShowStatus((double)(i + 1) / block.Length, "Performing clone.");
            }

            data.Add(block);
            presenter.ShowStatus(1, "Clone done.");
        }
    }
}
