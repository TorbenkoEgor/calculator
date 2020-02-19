using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IModel
    {
        void PerformOperation(String action, double argument);
        void FileOperation(String action, String argument);
        void RestoreHistory(int pointer);
    }
}
