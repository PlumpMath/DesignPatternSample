using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.framework;

namespace Prototype
{
    class Program
    {
        const string hello = "Hello, world !!";

        static void Main(string[] args)
        {
            // 準備
            var manager = new Manager();

            // 登録
            manager.Register("strong message", new UnderlinePen('~'));
            manager.Register("warning box", new MessageBox('*'));
            manager.Register("slash box", new MessageBox('/'));

            // 生成
            IProduct p1 = manager.Create("strong message");
            IProduct p2 = manager.Create("warning box");
            IProduct p3 = manager.Create("slash box");
            IProduct p4 = manager.Create("slash box");
            p1.Use(hello);
            p2.Use(hello);
            p3.Use(hello);
            p4.Use(hello);

            if (p3 != p4)
            {
                Console.WriteLine("クローンしたので、オブジェクト自体は別物");
            }
        }
    }
}
