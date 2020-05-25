using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CS_Advanced_Topics___Lambda_Expressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5 },
                new Book() {Title = "Title 2", Price = 7 },
                new Book() {Title = "Title 3", Price = 17 },
            };
        }
    }
}
