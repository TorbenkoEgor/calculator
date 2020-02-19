using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model.FileOperators
{
    class Load : IFileOperator
    {
        public void Perform(HistoryData data, String argument, IPresenter presenter)
        {
            double[] block = null;

            try
            {
                String s;

                using (StreamReader stream = new StreamReader(argument))
                {
                    s = stream.ReadLine();
                }

                String[] values = s.Split(' ');

                /*if (values.Length > 1e6)
                {
                    presenter.ShowStatus(0, "File is too big.");
                    return;
                }*/

                block = new double[values.Length];

                for (uint i = 0; i < block.Length; ++i)
                {
                    if (!double.TryParse(values[i], out block[i]))
                    {
                        presenter.ShowStatus(0, "Parse fail => '" + values[i] + "'");
                        return;
                    }

                    if ((i + 1) % 100 == 0 || i + 1 == block.Length)
                        presenter.ShowStatus((double)(i + 1) / block.Length, "Performing save.");
                }
            }
            catch (Exception e)
            {
                presenter.ShowStatus(0, e.ToString());
                return;
            }

            data.Add(block);
            presenter.ShowStatus(1, "Done.");
            presenter.ShowHistory(data);
        }
    }
}
