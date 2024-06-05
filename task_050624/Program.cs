using task_050624.Models;

namespace task_050624
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
           Library library = new Library();

            Book book1 = new Book(1, "Beatmaking", "Clavis", 300);
            Book book2 = new Book(2, "Main Kampf", "HItler", 300);
            Book book3 = new Book(3, "Bele buyurdu zerdust", "Nietzsche", 300);

            library.RemoveAllBooksByName("Beatmaking");
        }
        }
    }

