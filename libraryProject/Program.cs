using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using libraryProject;

namespace LibraryProject
{

    class Program
    {
        public static void Main()
        {
            List<Books> Catalog = new List<Books>();
            string line = " ";
            using (StreamReader file = new StreamReader(@"D:\c#\libraryProject\booklist2.csv"))
            {
                for (Int16 index = 0; line != null; index++)
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
                    book.Resource = parts[0];
                    book.Title = parts[1];
                    book.Subtitle = parts[2];
                    book.Series = parts[3];
                    book.Section = parts[4];
                    book.CallNumber = parts[5];
                    book.Author = parts[6];
                    book.Publisher = parts[7];
                    Catalog.Add(book);
                }

            }
            Console.WriteLine(Catalog.Count);
            //           Console.WriteLine(Catalog.Sort);
            Console.WriteLine(Catalog[1].Author);
            Console.WriteLine(Catalog[2].Copies);
            Console.WriteLine(Catalog[3].Publisher);
            AddBook();
            Console.ReadLine();

        }
        public static void AddBook()
        {
            string line = "  ";
            using (StreamWriter file = new StreamWriter(@"D:\c#\libraryProject\booklist2.csv"))
            {
                for (Int16 index = 0; line != null; index++)
                {
                    string[] parts = new string[] { "", "", "", "", "", "", "", "" };
                    Console.WriteLine(line);
                    Books book = new Books();
                    Console.WriteLine();
                    Console.Write("Resource:");
                    book.Resource = Console.ReadLine();
                    Console.Write("Title:");
                    book.Title = Console.ReadLine();
                    Console.Write("SubTitle:");
                    book.Subtitle = Console.ReadLine();
                    Console.Write("Series:");
                    book.Series = Console.ReadLine();
                    Console.Write("Section:");
                    book.Section = Console.ReadLine();
                    Console.Write("CallNumber:");
                    book.CallNumber = Console.ReadLine();
                    Console.Write("Author:");
                    book.Author = Console.ReadLine();
                    Console.Write("Publisher:");
                    book.Publisher = Console.ReadLine();
                    parts[0] = book.Resource;
                    parts[1] = book.Title;
                    parts[2] = book.Subtitle;
                    parts[3] = book.Series;
                    parts[4] = book.Section;
                    parts[5] = book.CallNumber;
                    parts[6] = book.Author;
                    parts[7] = book.Publisher;
                    file.WriteLine(parts[0] + "," + parts[1] + "," + parts[2] + "," + parts[3] + "," + parts[4] + "," + parts[5] + "," + parts[6] + "," + parts[7]);
                }

            }
            /*
            Books book = new Books();
            Console.WriteLine();
            Console.Write("Resource:");
            book.Resource = Console.ReadLine();
            Console.Write("Title:");
            book.Title = Console.ReadLine();
            Console.Write("SubTitle:");
            book.Subtitle = Console.ReadLine();
            Console.Write("Series:");
            book.Series = Console.ReadLine();
            Console.Write("Section:");
            book.Section = Console.ReadLine();
            Console.Write("CallNumber:");
            book.CallNumber = Console.ReadLine();
            Console.Write("Author:");
            book.Author = Console.ReadLine();
            Console.Write("Publisher:");
            book.Publisher = Console.ReadLine();*/
            Console.ReadLine();
        }
        public static void DeleteBook()
        {
            Books catalog = new Books();
            catalog = null;
        }
    }
}

