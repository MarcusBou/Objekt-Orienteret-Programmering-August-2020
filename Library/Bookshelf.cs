using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Bookshelf : Book
    {
        List<Book> bookShelf = new List<Book>();

        public List<Book> BookShelf { get { return bookShelf; } }


    }
}
