using System;
using Xunit;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Tests
{
    public class BookTests
    {
        [Fact]
        public void AddBookPrice()
        {
            var book = new Book(){
                Id=1,
                Title = "My test book",
                Price = 9.99
            };

            book.Price = 7.99;

            Assert.Equal(7.99, book.Price);
        

        }
        public void TestMemberDiscount(){
            var book = new Book(){
                Id=1,
                Title="My test book",
                Price = 9.99
            };
            book.ApplyMemberDiscount();

            var discountPrice = 9.99 * .9;
            Assert.Equal(discountPrice, book.Price);
        }
    }
}
