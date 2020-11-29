using System;

namespace Lesson009_HT_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Show("Autobiograhy");
            Author author1 = new Author();
            author1.Show("Myroslav");
            Content content1 = new Content();
            content1.Show("History");
            Title title1 = new Title();
            title1.Show("My Own Life");
            
        }
    }
}
