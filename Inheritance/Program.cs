using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.Name = "animal Farmer";
            b1.Author = "George Orwell";
            b1.PrintInfo();

            AudioBook b2 = new AudioBook("animal Farmer" , "George Orwell" , "John");
            b2.PrintInfo();

            PdfBook b3 = new PdfBook("animal Farmer", "George Orwell", "John Jensen " , 250);
            b3.PrintInfo();
            b3.PrintInfo("John Jensen ", 250);


            Console.ReadKey(true);

        }

        public class Book
        {
            public string Name;
            public string Author;

            public virtual void PrintInfo()
            {
                Console.WriteLine(Name + "-" + Author);
            }
        }

        public class AudioBook : Book
        {
            public string Narrator;

            public AudioBook()  //default constracter
            {

            }

            public AudioBook(string name , string author , string narrator)
            {
                Name = name;
                Author = author;
                Narrator = narrator;
            }
            public override void PrintInfo() //override metod its means that override the PrintInfo metod , here we can not access to printifo from book class
            {
                Console.WriteLine(Name + "-" + Author + "("+Narrator +")");
            }
        }

        public class PdfBook : Book
        {
            public string Publihser;
            public double Price;

            public PdfBook()
            {

            }

            public PdfBook(string name, string author, string publisher,double price)
            {
                Name = name;
                Author = author;
                Publihser = publisher;
                Price = price;
            }

            public void PrintInfo(string Publisher, double Price) //overload metod its means that vi can access both PrintInfo metod from Book class without parameter and also this metod with parameter
            {
                Console.WriteLine(Name + "-" + Author +"-"+ Publihser +"with price:"+ Price+ "$");
            }

        }

           
    }
}
