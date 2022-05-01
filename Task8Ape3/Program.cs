using System;

namespace Task8Ape3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Sherlock Holmes", "Arthur Conan Doyle", 10);
          
            Book book1 = new Book("Sherlock Holme", "Arthur Conan Doyle", 15);
            
            Book book2 = new Book("Sherlock", "Arthur Conan Doyle", 20);
            

            Libary libary = new Libary();
            libary.books.Add(book);
            libary.books.Add(book1);
            libary.books.Add(book2);


            Console.WriteLine("FindAllBooksByPageCountRange:");
            foreach (var item in libary.FindAllBooksByPageCountRange(5,100))
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("\n");
            }



            Console.WriteLine("FindAllBooksbyName:");
            foreach (var item in libary.FindAllBooksbyName("Az-dili"))
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("\n");

            }



            Console.WriteLine("RemoveBooksbyName:");
            libary.RemoveBooksbyName("Sherlock Holme");
            foreach (var item in libary.books)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("\n");

            }



            Console.WriteLine("RemoveBooksbyCode:");
           
            libary.RemoveBooksbyCode("Sherlock");
            foreach (var item in libary.books)
            {
                Console.WriteLine(item.Name);
            }

            
        }
    }
}
