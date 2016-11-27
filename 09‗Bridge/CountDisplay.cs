using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Bridge
{
    class CountDisplay : Display
    {
        /// <summary>
        /// コンストラクタは親クラスのものをそのまま使用
        /// </summary>
        /// <param name="impl"></param>
        public CountDisplay(DisplayImpl impl) : base(impl) { }

        public void MultiDisplay(int times)
        {
            this.Open();
            for (int i=0; i<times; i++)
            {
                this.Print();
            }
            this.Close();
        }
    }
}
