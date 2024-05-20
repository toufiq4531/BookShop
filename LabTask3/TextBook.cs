using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    class TextBook : Book
    {
        int standard;

        public TextBook() { }

        public TextBook(String isbn, String bookTitle, String authorName,
                        double price, int availableQuantity, int standard) : base(isbn, bookTitle, authorName, price, availableQuantity)
        {
            this.standard = standard;
        }

        public void setStandard(int standard)
        {
            this.standard = standard;
        }

        public int getStandard()
        {
            return standard;
        }

        public override void showDetails()
        {
            base.showDetails();
            Console.WriteLine("Book Standard: " + getStandard());
        }

    }
}
