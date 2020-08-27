using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class GrabbedBooks
    {
        private Stack<Book> getBooks = new Stack<Book>();

        public Stack<Book> GetBooks { get { return getBooks; } }

        public void GrabBook(Book grabbedBook)
        {
            getBooks.Push(grabbedBook);
        }

    }
}
