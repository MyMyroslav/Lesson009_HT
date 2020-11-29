using System;
namespace Lesson009_HT_Task3
{
    public class Title
    {
        private string title;
        public void Show(string title)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"{title}");
        }
        public Title()
        {
        }
        public Title(string title)
        {
            this.title = title;
        }
        public string addTitle(string addTitle)
        {
            return addTitle;
        }
    }
}
