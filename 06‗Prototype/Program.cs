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
        static void Main(string[] args)
        {
            // 準備
            var manager = new Manager();
            IProduct upen = new UnderlinePen('~');
            IProduct mbox = new MessageBox('*');
            IProduct sbox = new MessageBox('/');

            manager.Register("strong message", upen);
            manager.Register("warning box", mbox);
            manager.Register("slash box", sbox);

            // 生成
            const string hello = "Hello, world !!";
            IProduct p1 = manager.Create("strong message");
            IProduct p2 = manager.Create("warning box");
            IProduct p3 = manager.Create("slash box");
            p1.Use(hello);
            p2.Use(hello);
            p3.Use(hello);
        }
    }
}
