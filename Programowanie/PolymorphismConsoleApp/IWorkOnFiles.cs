using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConsoleApp
{
    internal interface IWorkOnFiles
    {
        void SaveToFile();
        //void LoadFromFile();
    }
    /*
    abstract class WorkOnFiles
    {
        virtual void SaveToFile() = 0;
        virtual void LoadFromFile() = 0;
    }
    */
}
