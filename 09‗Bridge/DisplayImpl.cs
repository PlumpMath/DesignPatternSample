using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Bridge
{
    /// <summary>
    /// 実装のクラス
    /// </summary>
    abstract class DisplayImpl
    {
        public abstract void RawOpen();
        public abstract void RawPrint();
        public abstract void RawClose();
    }
}
