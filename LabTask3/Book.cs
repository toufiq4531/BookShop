using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    public class Book
    {
        String isbn;
        String bookTitle;
        String authorName;
        double price;
        int availableQuantity;

        public Book() 
        {
        }

        public Book(String isbn, String bookTitle, String authorName,
                    double price, int availableQuantity) 
        {
            this.isbn = isbn;
            this.bookTitle = bookTitle;
            this.authorName = authorName;
            this.price = price;
            this.availableQuantity = availableQuantity;
        }

        public void setIsbn(string isbn) 
        {
            this.isbn = isbn;
        }

        public void setBookTitle(string bookTitle)
        {
            this.bookTitle = bookTitle;
        }

        public void setAuthorName(String authorName) 
        {
            this.authorName = authorName;
        }

        public void setPrice(double price) 
        {
            this.price = price;
        }

        
        public void setAvaiableQuantity(int availableQuantity) 
        {
            this.availableQuantity = availableQuantity;
        }
        

        public String getIsbn() 
        {
            return isbn;
        }
        public String getBookTitle()
        {
            return bookTitle;
        }
        public String getAuthorName()
        {
            return authorName;
        }
        public double getPrice()
        {
            return price;
        }

        public int getAvailableQuantity()
        {
            return availableQuantity;
        }

        /*
        public int AvailableQuantity
        {
            set{ this.availableQuantity = value; }
            get{ return this.availableQuantity; }
        }
        */

        public int AvailableQuantity
        {
            set => availableQuantity = value;
            get => availableQuantity;
        }

        

        public void addQuantity(int amount)
        {
            this.availableQuantity += amount;
        }

        public void sellQuantity(int amount)
        {
            if(this.availableQuantity > amount) {
                this.availableQuantity -= amount;
            }
        }

        public virtual void showDetails()
        {
            Console.WriteLine("ISBN: " + getIsbn());
            Console.WriteLine("Book Title: " + getBookTitle());
            Console.WriteLine("Author Name: " + getAuthorName());
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("Available Quantity: " + getAvailableQuantity());
        }

    }
}
