using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.framework;

namespace Prototype
{
    class UnderlinePen : IProduct
    {
        char ulchar;

        public UnderlinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }

        public object Clone()
        {
            return new UnderlinePen(ulchar);
        }

        public IProduct CreateClone()
        {
            return (IProduct)Clone();
        }

        public void Use(string s)
        {
            int length = s.Length;

            Console.WriteLine("\"" + s + "\"");
            Console.Write(" ");
            for (int i=0; i<length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine("");
        }
    }
}
