using System;
namespace Lesson009_HT_Task3
{
    public class Content 
    {
        private string content;
        public void Show(string content)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"{content}");
        }
        public Content()
        {
        }
        public Content(string content)
        {
            this.content = content;
        }
        public string addContent(string addContent)
        {
            return addContent;
        }
    }
}
