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
                if (bookshelf.grabBook.GetBooks.Count == 0)//See if Your grabbed books, are empty, if true, ask for a book to choose
                {
                    Console.Write("\nchoose a book by its title: ");
                    choosenBook = Console.ReadLine();
                    Console.WriteLine(bookshelf.RemoveFromBookShelf(choosenBook));//For when book has been choosen, it then adds it to Grabbed Book Stack
                }
                else
                {
                    Console.Write("\nChoose a book or go Loan your books (choose/loan): ");//If Books grabbed is more then 0, You can either choose another book or go loan the book
                    string chooseOrLoan = Console.ReadLine();
                    if (chooseOrLoan.Equals("choose"))//if option choose, Choose another book
                    {
                        Console.Write("\nchoose a book by its title: ");//ask for title of the book
                        choosenBook = Console.ReadLine();
                        Console.WriteLine(bookshelf.RemoveFromBookShelf(choosenBook));//Add Book to the stack of grabbed books, and remove it from bookshelf
                    }
                    else if (chooseOrLoan.Equals("loan"))//if option loan go to loan Gui
                    {
                        LoanGui();//loads up the Loan Gui
                    }
                }
                Console.ReadKey();
            }
        }

        public void LoanGui()
        {
            Console.Clear();
            while (bookshelf.grabBook.GetBooks.Count != 0)
            {

                Console.WriteLine(bookshelf.grabBook.GetBooks.Peek());//shows The next book you have grabbed
                Console.Write("\nWould You like to loan(y/n): ");//checks if you want to loan
                char yesOrNo = Console.ReadKey().KeyChar;//Gets the Key you are pressing
                if (yesOrNo.Equals('y'))//if Yes, the pop the stack
                {
                    Console.WriteLine("\n Loaning: \n{0}", bookshelf.grabBook.GetBooks.Pop());//pops the stack and says loaned book
                }
                else if (yesOrNo.Equals('n'))
                {
                    bookshelf.BookShelf.Add(bookshelf.grabBook.GetBooks.Peek());//puts the book back to the bookshelf
                    Console.WriteLine("Putting back:\n{0} \non the shelf", bookshelf.grabBook.GetBooks.Pop());//pops the stack and shows ´what book is putted back
                }
            }
            
        }
    }
}
