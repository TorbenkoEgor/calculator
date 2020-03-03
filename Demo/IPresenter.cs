using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public interface IPresenter
    {
        void PerformAction(String action, String argument);
        void FileOperation(String action, String argument);
        void RestoreHistory(int pointer);
    }
}
