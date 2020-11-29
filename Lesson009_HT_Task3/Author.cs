using System;
namespace Lesson009_HT_Task3
{
    public class Author
    {
        private string author;
        public void Show(string author)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{author}");
        }
        public Author()
        {
        }
        public Author(string author)
        {
            this.author = author;
        }
        public string addName(string authorName)
        {
            return authorName;
        }
    }
}
