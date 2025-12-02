using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConsoleApp
{
    internal abstract class Figure: IWorkOnFiles
    {
        protected string name;

        public Figure()
        {
            //name = "???";
        }

        public abstract void ShowInfo();

        public abstract /*virtual*/ int GetPerimeter();
        /*{
            return 0;
        }*/

        public abstract int GetArea();

        public abstract void SaveToFile();
    }
}
