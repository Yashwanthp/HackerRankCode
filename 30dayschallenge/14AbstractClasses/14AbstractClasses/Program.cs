using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var title = Console.ReadLine();
            var author = Console.ReadLine();
            var price = Convert.ToInt32(Console.ReadLine());
            Book b = new MyBook(title,author,price);
            b.display();
        }
    }

    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }

    class MyBook : Book
    {
        private readonly string _t;
        private readonly string _a;
        private readonly int _price;

        public MyBook(String t, String a, int price):base(t,a)
        {
            _t = t;
            _a = a;
            _price = price;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {_t}");
            Console.WriteLine($"Author: {_a}");
            Console.WriteLine($"Price: {_price}");
        }
    }
}
