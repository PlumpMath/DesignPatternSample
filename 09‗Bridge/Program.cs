using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new Display(new StringDisplayImpl("Hello, Japan !!"));
            var d2 = new CountDisplay(new StringDisplayImpl("Hello, World !!"));
            var d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe !!"));

            d1.DoDisplay();
            d2.DoDisplay();
            d3.DoDisplay();
            d3.MultiDisplay(5);
        }
    }
}
