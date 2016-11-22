using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Singletonパターンの練習問題用クラスです（練習問題５－１）
    /// </summary>
    class TicketMaker
    {
        static int ticket = 1000;
        static TicketMaker onlyOneTiketMaker = new TicketMaker();
        
        private TicketMaker()
        {
            Console.WriteLine("This is only one ticket maker.");
        } 

        public static int GetNextTicketNumber()
        {
            return ticket++;
        }
    }

    class TicketMaker2
    {
        int ticket = 1000;
        static TicketMaker2 onlyOneTiketMaker = new TicketMaker2();

        private TicketMaker2()
        {
            Console.WriteLine("This is only one ticket maker.");
        }

        public static TicketMaker2 GetInstance()
        {
            return onlyOneTiketMaker;
        }

        public int GetNextTicketNumber()
        {
            return ticket++;
        }
    }
}
