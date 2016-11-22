using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 本
    /// </summary>
    class Book
    {
        public string Name { get; }
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">本の名称</param>
        public Book(string name)
        {
            this.Name = name;
        }
    }
}
