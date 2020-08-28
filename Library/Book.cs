using System;
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

        public Book(string booksTitle, string genreForBook, string authorOfBook, int pagesInBook) //Constructor Parametes that is needed to create a Book
        {
            booktitle = booksTitle;
            genre = genreForBook;
            author = authorOfBook;
            pages = pagesInBook;
        }

        public override string ToString()//When a Book is printed It will print like the string
        {
            return "_______________________________________________" +
                   "\n|Title Of The Book: " + booktitle + 
                   "\n|Genre Of The Book: " + genre +
                   "\n|Author Of The Book: " + author +
                   "\n|Amount Of Pages: " + pages;
        }
    }
}
