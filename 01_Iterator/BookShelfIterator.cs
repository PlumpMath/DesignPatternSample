using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class BookShelfIterator : IIterator
    {
        private BookShelf bookShelf;
        private int index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            this.index = 0;
        }

        public bool hasNext()
        {
            return (index < bookShelf.GetLength()) ? true : false;
        }

        public object next()
        {
            Book book = bookShelf.GetBookAt(index);
            index++;
            return book;
        }
    }
}
