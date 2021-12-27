using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Polymorphisme
{
    class Book
    {
        protected int ISBN;
        protected string Title;
        protected string Author;
        protected float Price;
        protected int numberPage;

        public Book(int iSBN, string title, string author, float price, int numberPage)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            Price = price;
            if (numberPage >= 20)
            this.numberPage = numberPage;
        }

        public Book()
        {

        }

        public override string ToString()
        {
            return base.ToString()
                + "\nISBN : " + this.ISBN 
                + "\nTitle: " + this.Title 
                + "\nAuthor: " + this.Author 
                + "\nPrice$ : " + this.Price 
                + "\nNumberPages: " + this.numberPage;
        }

        // Surcharge 

        public bool Comparer (Book b)
        {
            bool res = false;

            if ( this.ISBN == b.ISBN
                 && this.numberPage == b.numberPage
                 && this.Title == b.Title
                 && this.Price == b.Price
                 && this.Author == b.Author)
                res = true;

            return res;
        }

        public bool Comparer(string Title)
        {
            bool res = false;

            if (this.Title == Title)
                res = true;

            return res;
        }

        public bool Comparer(float Price)
        {
            bool res = false;

            if (this.Price == Price)
                res = true;

            return res;
        }
    }
}
