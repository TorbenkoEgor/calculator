using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IPresenter
    {
        void ShowStatus(double percent, String status);
        void ShowHistory(HistoryData data);
    }
}
