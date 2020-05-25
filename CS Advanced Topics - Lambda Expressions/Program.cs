using System;

namespace CS_Advanced_Topics___Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //  args => expression
            //number => number * number;    // Lambda Expression is an anonymous method - no access modifier, name or return statement

            //Func<int, int> square = Square  // 1st parameter represents argument, 2nd represents return type - this delegate points to the Square Method
            //Func<int, int> square = number => number * number;
            // () => ...        // No arguments
            // x => ...         // 1 arguments
            // (x, y, z) => ... // Multiple arguments

            //const int factor = 5;                       
            //Func<int, int> multiplier = n => n * factor;    // Scope of right side of lambda expression includes anything defined within the method calling the expression
            //Console.WriteLine(multiplier(10));

            var books = new BookRepository().GetBooks();

            // predicate is a delegate that points to a method that gets a boolean value specifying whether a given condition was satisfied
            //books.FindAll
            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            //var cheapBooks = books.FindAll(book => book.Price < 10);
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        //static bool IsCheaperThan10Dollars(Book book)   // A Predicate Function
        //{
        //    return book.Price < 10;
        //}

        //static int Square(int number)
        //{
        //    return number * number;
        //}
    }
}
