using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreC_Fun
{
    internal class PrintStuff
    {
        // Constructor
        private string language;

        public PrintStuff ()
        {
            language = "EN";
        }

        public PrintStuff(string temp)
        {
            language = temp;
        }

        public void PrintName(string fn)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + fn + "!");
            }
            if (language == "PT")
            {
                System.Console.WriteLine("OI, " + fn + "!");
            }
        }
    }
}
