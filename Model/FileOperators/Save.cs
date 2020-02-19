using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model.FileOperators
{
    class Save : IFileOperator
    {
        public void Perform(HistoryData data, String argument, IPresenter presenter)
        {
            if (data.list.Count == 0)
            {
                presenter.ShowStatus(0, "");
                return;
            }

            try
            {
                using (StreamWriter stream = new StreamWriter(argument))
                {

                    double[] old = data.Current();

                    for (uint i = 0; i < old.Length; ++i)
                    {
                        stream.Write(old[i].ToString() + (i + 1 < old.Length ? " " : ""));

                        if ((i + 1) % 100 == 0 || i + 1 == old.Length)
                            presenter.ShowStatus((double)(i + 1) / old.Length, "Performing save.");
                    }
                }
            }
            catch (Exception e)
            {
                presenter.ShowStatus(0, e.ToString());
            }

            presenter.ShowStatus(1, "Done.");
        }
    }
}
