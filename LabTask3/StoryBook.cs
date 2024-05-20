using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    class StoryBook : Book
    {
        string category;

        public StoryBook() { }

        public StoryBook(String isbn, String bookTitle, String authorName, 
                        double price, int availableQuantity, String category) : base(isbn, bookTitle, authorName, price, availableQuantity)
        {
            this.category = category;
        }

        public void setCategory(String category)
        {
            this.category = category;
        }

        public String getCategory()
        {
            return category;
        }

        public override void showDetails()
        {
            base.showDetails();
            Console.WriteLine("Book Category: "+ getCategory());
        }

    }
}
