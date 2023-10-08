using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Book book1 = new Book();
            Book book2 = new Book("a", "b", 2020, 156.000m);
            book1.DisplayInfo();
            book2.DisplayInfo();
            Console.ReadKey();
        }
    }
}
