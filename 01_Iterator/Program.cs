using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.AppendBook(new Book("test1"));
            bookShelf.AppendBook(new Book("test2"));
            bookShelf.AppendBook(new Book("test3"));
            bookShelf.AppendBook(new Book("test4"));

            IIterator it = bookShelf.iterator();

            while (it.hasNext())
            {
                Book book = (Book)it.next();
                Console.WriteLine(book.Name);
            }

            EndConsoleOut();
        }

        static private void EndConsoleOut()
        {
            Console.WriteLine("First display of filenames to the console:");
            Console.ReadKey();
        }
    }
}
