using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject
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
        public string Resource { get; set; }
        public string Subtitle { get; set; }
        public string Series { get; set; }
        public Int16 TimesCheckedOut { get; set; }
        public string Section { get; set; }
        public string CallNumber { get; set; }


    }
}