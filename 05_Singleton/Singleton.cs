using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        static Singleton singleton = new Singleton();

        private Singleton()
        {
            Console.WriteLine("Create an Instance.");
        }

        public static Singleton GetInstance()
        {
            return singleton;
        }
    }
}
