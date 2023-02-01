using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectLibrary.Core.Entities
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        
        // nde pacc
        public Book (int iSBN, string title, string author, string genre )
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            Genre = genre;
        }
    }
}
