using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.");

            var obj1 = Singleton.GetInstance();
            var obj2 = Singleton.GetInstance();

            if(obj1 == obj2)
            {
                Console.WriteLine("SAME!!");
            }

            Console.WriteLine("End.");

            for(int i=0; i<10; i++)
            {
                Console.WriteLine(TicketMaker.GetNextTicketNumber());
            }

            var ticketMaker2 = TicketMaker2.GetInstance();

            for (int i=0; i<10; i++)
            {
                Console.WriteLine(ticketMaker2.GetNextTicketNumber());
            }
        }
    }
}
