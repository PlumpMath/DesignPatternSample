using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Bridge
{
    class StringDisplayImpl : DisplayImpl
    {
        string str;
        int width;

        public StringDisplayImpl(string str)
        {
            this.str = str;
            this.width = str.Length;
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine("|" + str + "|");
        }

        public override void RawClose()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for(int i=0; i<width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
