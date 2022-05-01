using System;
using System.Collections.Generic;
using System.Text;

namespace Task8Ape3
{
    internal class Libary
    {
        public List<Book> books = new List<Book>();

        public List<Book>  FindAllBooksbyName(string value)
        {

             return books.FindAll(x => x.Name.Contains(value));
            
        }
        public void RemoveBooksbyName(string value)
        {
             books.RemoveAll(x => x.Name.Contains(value));
            
        }
        public List<Book> SearchBooks(string value)
        {
            return books.FindAll(x => x.Name.Contains(value) ||  x.AuthorName.Contains(value) || x.PageCount.ToString().Contains(value));
        }
        public List<Book> FindAllBooksByPageCountRange(int min ,int max)
        {
            return books.FindAll(x => x.PageCount>=min && x.PageCount<=max);
        }
        public  void RemoveBooksbyCode(string value)
        {
            Book book=books.Find(x => x.Code.Contains(value));
            if (book!=null)
            {
                books.Remove(book);
            }

        }



    }
}
