using System;
namespace Lesson009_HT_Task3
{
    public class Book
    {
        private string book;
        public void Show(string book)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(book);
        }
        public Book()
        {
        }

    }
}
