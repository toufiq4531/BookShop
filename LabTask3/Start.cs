using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    class Start
    {
        static void Main(string[] args)
        {
            //Objects of StoryBook
            StoryBook storyBook1 = new StoryBook("SB1", "The Hobbit", "J.R.R. Tolkien", 15.99, 50, "Fantasy");
            StoryBook storyBook2 = new StoryBook("SB2", "Harry Potter and the Philosopher's Stone", "J.K. Rowling", 12.99, 40, "Fantasy");
            StoryBook storyBook3 = new StoryBook("SB3", "Percy Jackson and the Lightning Thief", "Rick Riordan", 11.99, 30, "Fantasy");
            StoryBook storyBook4 = new StoryBook("SB4", "The Hunger Games", "Suzanne Collins", 14.99, 45, "Science Fiction");
            StoryBook storyBook5 = new StoryBook("SB5", "To Kill a Mockingbird", "Harper Lee", 9.99, 35, "Fiction");


            //Objects of TextBook
            TextBook textBook1 = new TextBook("TB1", "Introduction to Algorithms", "Thomas H. Cormen", 99.99, 20, 12);
            TextBook textBook2 = new TextBook("TB2", "Artificial Intelligence: A Modern Approach", "Stuart Russell", 89.99, 15, 13);
            TextBook textBook3 = new TextBook("TB3", "Database Management Systems", "Raghu Ramakrishnan", 79.99, 25, 14);
            TextBook textBook4 = new TextBook("TB4", "Computer Networks", "Andrew S. Tanenbaum", 69.99, 30, 15);
            TextBook textBook5 = new TextBook("TB5", "Operating System Concepts", "Abraham Silberschatz", 59.99, 35, 16);

            //Object of BookShop
            BookShop bookShop = new BookShop("MyBookStore");

            Console.WriteLine("BookShop name: " + bookShop.getName());
            Console.WriteLine();

            bookShop.insertBook(storyBook1);
            bookShop.insertBook(storyBook2);
            bookShop.insertBook(storyBook3);
           
            bookShop.insertBook(textBook1);
            bookShop.insertBook(textBook2);
            bookShop.insertBook(textBook3);

            bookShop.removeBook(storyBook1);
            bookShop.removeBook(textBook1);

            bookShop.searchBook("SB1");
            bookShop.searchBook("TB3");

            Console.WriteLine("All books in the bookshop:");
            bookShop.showAllBooks();
            

            Console.ReadKey();
        }
    }
}
