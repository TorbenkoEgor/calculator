using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HistoryData
    {
        public List<double[]> list;
        public int pointer;

        public HistoryData()
        {
            list = new List<double[]>();
            pointer = 0;
        }

        public void Add(double[] block)
        {
            while (list.Count > 0 && list.Count > pointer + 1)
                list.RemoveRange(pointer + 1, list.Count - 1 - pointer);

            list.Add(block);
            pointer = list.Count - 1;
        }

        public double[] Current()
        {
            if (list.Count == 0)
                return null;

            return list.ElementAt(pointer);
        }

        public void Reset()
        {
            list.Clear();
            pointer = 0;
        }
    }
}
