using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.framework
{
    interface IProduct : ICloneable
    {
        // C#のinterfaceは、メソッドが全て「public abstract」になる
        void Use(string s);
        IProduct CreateClone();
    }
}
