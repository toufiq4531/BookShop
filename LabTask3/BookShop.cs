using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    class BookShop
    {
        String name;
        int bookCount = 0;
        Book[] books = new Book[100];

        public BookShop() { }

        public BookShop(String name)
        {
            this.name = name;

        }

        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }

        public bool insertBook(Book b)
        {
            if (bookCount < books.Length)  //(bookCount < 100)
            {
                books[bookCount++] = b;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool removeBook(Book b)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i] == b)
                {
                    // Shift remaining books to fill the empty slot
                    for (int j = i; j < bookCount - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    books[--bookCount] = null;
                    Console.WriteLine("Book Removed");
                    return true;
                }
            }
            return false;
        }


        public void showAllBooks()
        {
            for (int i = 0; i < bookCount; i++)
            {
                books[i].showDetails();
                Console.WriteLine();
            }
        }
        public Book searchBook(String isbn)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].getIsbn() == isbn)
                {
                    Console.WriteLine("ISBN: " + isbn + " Found"); // can add \n for new line space
                    return null;
                }
                
            }
            Console.WriteLine("ISBN: " + isbn + " Not Found"); // can add \n for new line space
            return null;
        }
    }
}
