using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_050624.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string BookCode { get; set; }

        public Book(int id, string name, string authorName, int pageCount)
        {
            Id = id;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            BookCode = MyHelperLibrary.Helpers.MyHelper.CreateBookCode(name);
        }
    }
}


