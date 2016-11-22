using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacctoryMethod.framework;

namespace FacctoryMethod.idcard
{
    class IDCardFactory : Factory
    {
        List<IDCard> owners = new List<IDCard>();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            owners.Add((IDCard)product);
        }

        public List<IDCard> GetOwners()
        {
            return owners;
        }
    }
}
