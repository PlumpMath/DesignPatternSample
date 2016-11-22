using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.framework
{
    class Manager
    {
        Dictionary<string, IProduct> showcase = new Dictionary<string, IProduct>();

        public void Register(string name, IProduct proto)
        {
            showcase.Add(name, proto);
        }

        public IProduct Create(string protoname)
        {
            IProduct p = showcase[protoname];
            return p.CreateClone();
        }
    }
}
