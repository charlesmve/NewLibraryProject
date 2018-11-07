using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryProject
{
    public class Books
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Publisher { get; set; }
        public Int16 Index { get; set; }
        public Int16 Copies { get; set; }
        public Int16 CheckedOut { get; set; }
        public Int16 BookCount { get; set; }

    }
    class Program
    {
        static void Main()
        {
            List<Books> Catalog = new List<Books>();
            string line = " ";
            using (StreamReader file = new StreamReader(@"D:\c#\libraryProject\booklist2.csv"))
            {
               for(Int16 index =0; line !=null;index++)
                {
                    line = file.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] parts = line.Split(',');
                    Console.WriteLine(line);
                    Books book = new Books();
                    book.Index = index;
                    Console.WriteLine(book.Index);
                    book.Isbn = parts[0];
                    book.Title = parts[1];
                    book.Author = parts[2];
                    book.Year = parts[3];
                    book.Publisher = parts[4];
                    book.Copies = Convert.ToInt16(parts[5]);
                    Catalog.Add(book);
                }
            }
            Console.WriteLine(Catalog.Count);
//           Catalog.ForEach(el => Console.WriteLine(Catalog[].Title));
//           Console.WriteLine(Catalog.Sort);
            Console.WriteLine(Catalog[1].Author);
            Console.WriteLine(Catalog[2].Copies);
            Console.WriteLine(Catalog[3].Publisher);
            Catalog.ForEach(el => Catalog[el].Title);
            Console.ReadLine();

        }
    }
}


