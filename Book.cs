using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class Book
    {
        private string Title;
        private string Author; 
        private int Year;
        private decimal Price;

        public Book()
        {
            Title = Author = "Unavailable";
            Price = 0;
        }
        public Book(string title, string author, int year, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.Price = price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($" Tên sách: {Title} \n Tác giả: {Author} \n Năm xuất bản:  {Year} \n Giá sách: {Price} \n ");
        }
    }
}
