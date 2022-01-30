using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MileStone_2;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstTest()
        {
            Book first_book = new Book("FirstBook", "FirstAuthor", "FirstPublisher", 100, "FirstGenre", 2021);
            Assert.AreEqual("FirstBook", first_book.BookName);
            Assert.AreEqual("FirstAuthor", first_book.AuthorName);
            Assert.AreEqual("FirstPublisher", first_book.Publisher);
            Assert.AreEqual(100, first_book.Price);
            Assert.AreEqual("FirstGenre", first_book.Genre);
            Assert.AreEqual(2021, first_book.YearOfPublish);
            first_book.changeBookName("NewFirstBook");
            Assert.AreEqual("NewFirstBook", first_book.BookName);
        }
        [TestMethod]
        public void SecondTest()
        {
            Book second_book = new Book("SecondBook", "SecondAuthor", "SecondPublisher", 200, "SecondGenre", 2022);
            Assert.AreEqual("SecondBook", second_book.BookName);
            Assert.AreEqual("SecondAuthor", second_book.AuthorName);
            Assert.AreEqual("SecondPublisher", second_book.Publisher);
            Assert.AreEqual(200, second_book.Price);
            Assert.AreEqual("SecondGenre", second_book.Genre);
            Assert.AreEqual(2022, second_book.YearOfPublish);
            second_book.changeAuthorName("NewAuthorName");
            Assert.AreEqual("NewAuthorName", second_book.AuthorName);
        }
        [TestMethod]
        public void ThirdTest()
        {
            Book third_book = new Book("ThirdBook", "ThirdAuthor", "ThirdPublisher", 300, "ThirdGenre", 2020);
            Assert.AreEqual("ThirdBook", third_book.BookName);
            Assert.AreEqual("ThirdAuthor", third_book.AuthorName);
            Assert.AreEqual("ThirdPublisher", third_book.Publisher);
            Assert.AreEqual(300, third_book.Price);
            Assert.AreEqual("ThirdGenre", third_book.Genre);
            Assert.AreEqual(2020, third_book.YearOfPublish);
            third_book.changePublisher("NewPublisher");
            Assert.AreEqual("NewPublisher", third_book.Publisher);
        }
        [TestMethod]
        public void FourthTest()
        {
            Book fourth_book = new Book("FourthBook", "FourthAuthor", "FourthPublisher", 400, "FourthGenre", 2021);
            Assert.AreEqual("FourthBook", fourth_book.BookName);
            Assert.AreEqual("FourthAuthor", fourth_book.AuthorName);
            Assert.AreEqual("FourthPublisher", fourth_book.Publisher);
            Assert.AreEqual(400, fourth_book.Price);
            Assert.AreEqual("FourthGenre", fourth_book.Genre);
            Assert.AreEqual(2021, fourth_book.YearOfPublish);
            fourth_book.changePrice(400.50);
            Assert.AreEqual(400.50, fourth_book.Price);
        }

        [TestMethod]
        public void FifthTest()
        {
            Book fifth_book = new Book("FifthBook", "FifthAuthor", "FifthPublisher", 500, "FifthGenre", 2022);
            Assert.AreEqual("FifthBook", fifth_book.BookName);
            Assert.AreEqual("FifthAuthor", fifth_book.AuthorName);
            Assert.AreEqual("FifthPublisher", fifth_book.Publisher);
            Assert.AreEqual(500, fifth_book.Price);
            Assert.AreEqual("FifthGenre", fifth_book.Genre);
            Assert.AreEqual(2022, fifth_book.YearOfPublish);
            fifth_book.changeGenre("NewGenre");
            Assert.AreEqual("NewGenre", fifth_book.Genre);
        }

        [TestMethod]
        public void SixthTest()
        {
            Book sixth_book = new Book("SixthBook", "SixthAuthor", "SixthPublisher", 600, "SixthGenre", 2022);
            Assert.AreEqual("SixthBook", sixth_book.BookName);
            Assert.AreEqual("SixthAuthor", sixth_book.AuthorName);
            Assert.AreEqual("SixthPublisher", sixth_book.Publisher);
            Assert.AreEqual(600, sixth_book.Price);
            Assert.AreEqual("SixthGenre", sixth_book.Genre);
            Assert.AreEqual(2022, sixth_book.YearOfPublish);
            sixth_book.changeYear(2021);
            Assert.AreEqual(2021, sixth_book.YearOfPublish);
        }

    }
}
