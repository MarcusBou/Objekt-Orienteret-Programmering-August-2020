using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Library
{
    class Gui
    {
        private string choosenBook;

        Bookshelf bookshelf = new Bookshelf();

        public void main_GUI()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[========= The Bookshelf =========]");
                foreach (Book book in bookshelf.BookShelf)
                {
                    Console.WriteLine(book);
                }
                if (bookshelf.grabBook.GetBooks.Count == 0)
                {
                    Console.Write("\nchoose a book by its title: ");
                    choosenBook = Console.ReadLine();
                    Console.WriteLine(bookshelf.RemoveFromBookShelf(choosenBook));
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("\nChoose a book or go Loan your books (choose/loan): ");
                    string chooseOrLoan = Console.ReadLine();
                    if (chooseOrLoan.Equals("choose"))
                    {
                        Console.Write("\nchoose a book by its title: ");
                        choosenBook = Console.ReadLine();
                        Console.WriteLine(bookshelf.RemoveFromBookShelf(choosenBook));
                    }
                    else if (chooseOrLoan.Equals("loan"))
                    {
                        LoanGui();
                    }
                }
            }
        }

        public void LoanGui()
        {
            Console.Clear();
            while (bookshelf.grabBook.GetBooks.Count != 0)
            {

                Console.WriteLine(bookshelf.grabBook.GetBooks.Peek());
                Console.Write("\nWould You like to loan(y/n): ");
                char yesOrNo = Console.ReadKey().KeyChar;
                if (yesOrNo.Equals('y'))
                {
                    Console.WriteLine("Loaning {0}", bookshelf.grabBook.GetBooks.Pop());
                }
                else if (yesOrNo.Equals('n'))
                {
                    bookshelf.BookShelf.Add(bookshelf.grabBook.GetBooks.Peek());
                    Console.WriteLine("Putting back {0} on the shelf", bookshelf.grabBook.GetBooks.Pop());
                }
            }
            
        }
    }
}
