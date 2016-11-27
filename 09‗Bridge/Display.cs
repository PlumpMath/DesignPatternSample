using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Bridge
{
    /// <summary>
    /// 機能のクラス
    /// </summary>
    class Display
    {
        private DisplayImpl impl;

        public Display(DisplayImpl impl)
        {
            this.impl = impl;
        }

        public void Open()
        {
            impl.RawOpen();
        }

        public void Print()
        {
            impl.RawPrint();
        }

        public void Close()
        {
            impl.RawClose();
        }

        public void DoDisplay()
        {
            Open();
            Print();
            Close();
        }
    }
}
