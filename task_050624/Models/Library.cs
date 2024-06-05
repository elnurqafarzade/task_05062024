

namespace task_050624.Models
{

    public class Library
    {
        private List<Book> Books { get; }

        public Library()
        {
            Books = new List<Book>();
        }

        public Book this[int index]
        {
            get { return Books[index]; }
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public List<Book> FindAllBooksByName(string value)
        {
            return Books.Where(book => book.Name.Contains(value)).ToList();
        }

        //public Book FindBookByCode(string code)
        //{
        //    return Books.FirstOrDefault(book => book.Code == code);
        //}

        public void RemoveAllBooksByName(string value)
        {
            Books.RemoveAll(book => book.Name.Contains(value));
        }

        public List<Book> SearchBooks(string value)
        {
            return Books.Where(book =>
                book.Name.Contains(value) || book.AuthorName.Contains(value) || book.PageCount.ToString().Contains(value))
                .ToList();
        }

        public List<Book> FindAllBooksByPageCountRange(int minPageCount, int maxPageCount)
        {
            return Books.Where(book => book.PageCount >= minPageCount && book.PageCount <= maxPageCount).ToList();
        }

        public void RemoveBookByCode(string code)
        {
            Books.RemoveAll(book => book.Code == code);
        }
    }
}


