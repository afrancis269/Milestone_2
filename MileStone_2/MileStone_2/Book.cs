using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MileStone_2
{
    public class Book
    {
        public string BookName;
        public string AuthorName;
        public string Publisher;
        public double Price;
        public string Genre;
        public int YearOfPublish;

        public Book(string bookName, string authorName, string publisher, double price, string genre, int year)
        {
            this.BookName = bookName;
            this.AuthorName = authorName;
            this.Genre = genre;
            this.Publisher = publisher;
            this.Price = price;
            this.YearOfPublish = year;
        }

        public void displayBook()
        {
            Console.WriteLine("Book title: " + BookName);
            Console.WriteLine("Author: " + AuthorName);
            Console.WriteLine("Publisher: " + Publisher);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Price: " + Price.ToString());
            Console.WriteLine("Year: " + YearOfPublish.ToString());
            Console.ReadLine();
        }
        public void changeBookName(string newName)
        {
            BookName = newName;
        }
        public void changeAuthorName(string newName)
        {
            AuthorName = newName;
        }
        public void changePublisher(string newName)
        {
            Publisher = newName;
        }
        public void changePrice(double newPrice)
        {
            Price = newPrice;
        }
        public void changeGenre(string newGenre)
        {
            Genre = newGenre;
        }
        public void changeYear(int newYear)
        {
            YearOfPublish = newYear;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("FirstBook", "FirstAuthor", "FirstPubliser", 100, "FirstGenre" ,2021);
            book1.displayBook();
            Console.WriteLine("Change first book's price");
            Console.WriteLine("Input book's new price: ");
            string newPrice = Console.ReadLine();
            book1.changePrice(Double.Parse(newPrice));
            Console.WriteLine("New info of first book");
            book1.displayBook();

            Book book2 = new Book("SecondBook", "SecondAuthor", "SecondPublisher", 200, "SecondGenre", 2022);
            book2.displayBook();
            Console.WriteLine("Change second book's genre");
            Console.WriteLine("Input book's new gerne: ");
            string newGenre = Console.ReadLine();
            book2.changeGenre(newGenre);
            Console.WriteLine("New info of second book");
            book2.displayBook();
        }
    }
   
}
