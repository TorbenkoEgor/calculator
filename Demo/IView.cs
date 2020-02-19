using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public interface IView
    {
        void ShowStatus(double percent, String status);
        void ShowHistory(List<String> data, int pointer);
    }
}
