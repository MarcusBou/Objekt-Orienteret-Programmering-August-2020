﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library
{
    class Book
    {
        private string booktitle, genre, author;
        private int pages;

        public string Booktitle { get { return booktitle; } set { booktitle = value; } }
        public string Genre { get { return genre; } set { genre = value; } }
        public string Author { get { return author; } set { author = value; } }
        public int Pages { get { return pages; } set { pages = value; } }

        public Book() { }

        public Book(string booksTitle, string genreForBook, string authorOfBook, int pagesInBook)
        {
            booktitle = booksTitle;
            genre = genreForBook;
            author = authorOfBook;
            pages = pagesInBook;
        }
    }
}
