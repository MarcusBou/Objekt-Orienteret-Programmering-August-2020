using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Bookshelf 
    {
        private List<Book> bookShelf = new List<Book>();

        public List<Book> BookShelf { get { return bookShelf; } }

        public GrabbedBooks grabBook = new GrabbedBooks();

        public Bookshelf()
        {
            bookShelf.Add(new Book { Booktitle = "Harry Potter de vise sten", Genre = "Fiction", Author = "J.K Rowling", Pages = 303});
            bookShelf.Add(new Book { Booktitle = "Ringenes Herre: eventyret om ringen", Genre = "Fiction", Author = "J.R.R Tolkien", Pages = 423});
            bookShelf.Add(new Book { Booktitle = "Djævlens Lærling", Genre = "Fiction", Author = "Kenneth Bøgh Andersen", Pages = 314});
            bookShelf.Add(new Book { Booktitle = "Heksejægerns lærling", Genre = "Fiction", Author = "Joseph Delaney", Pages = 259});
            bookShelf.Add(new Book { Booktitle = "Journal 64", Genre = "Thriller", Author = "Jussi Adler-Olsen", Pages = 461});
            bookShelf.Add(new Book { Booktitle = "Trofæ", Genre = "Thriller", Author = "Steffen Jacobsen", Pages = 442});
            bookShelf.Add(new Book { Booktitle = "Fifty-Shades of grey", Genre = "Kærlighes-Roman", Author = "E.L James", Pages = 521});
            bookShelf.Add(new Book { Booktitle = "Juraens-Grundregler", Genre = "Fag-litteratur", Author = "Anne lind gleerup", Pages = 515});
        }

        public string RemoveFromBookShelf(string bookTitle)
        {
            foreach (Book book in bookShelf)
            {
                if (book.Booktitle.Equals(bookTitle))
                {
                    grabBook.GrabBook(book);
                    bookShelf.Remove(book);
                    return string.Format("You have grabbed {0}", bookTitle);
                }
            }
            return string.Format("{0} Doesnt Exist on the Bookshelf", bookTitle);
        }
    }
}
