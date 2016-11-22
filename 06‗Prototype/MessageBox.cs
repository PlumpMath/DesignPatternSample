using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.framework;

namespace Prototype
{
    class MessageBox : IProduct
    {
        char decochar;

        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }

        public void Use(string s)
        {
            int length = s.Length;

            for(int i=0; i<length+4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
            Console.WriteLine(decochar + " " + s + " " + decochar);
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
        }

        public IProduct CreateClone()
        {
            return (IProduct)Clone();
        }

        public object Clone()
        {
            return new MessageBox(decochar);
        }
    }
}
