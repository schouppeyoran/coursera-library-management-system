class LibraryManager
{
    static void Main()
    {
        List<string> books = new List<string>();
        List<string> borrowedBooks = new List<string>();
        const int maxBooks = 5;
        const int maxBorrowedBooks = 3;

        while (true)
        {
            Console.WriteLine("Would you like to add, remove, list, search, borrow, return, or exit? (add/remove/list/search/borrow/return/exit)");
            string action = Console.ReadLine().ToLower();

            if (action == "add")
            {
                if (books.Count >= maxBooks)
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to add:");
                    string newBook = Console.ReadLine();
                    books.Add(newBook);
                }
            }
            else if (action == "remove")
            {
                if (books.Count == 0)
                {
                    Console.WriteLine("The library is empty. No books to remove.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to remove:");
                    string removeBook = Console.ReadLine();
                    if (books.Remove(removeBook))
                    {
                        Console.WriteLine("Book removed.");
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
            }
            else if (action == "list")
            {
                if (books.Count == 0)
                {
                    Console.WriteLine("The library is empty.");
                }
                else
                {
                    Console.WriteLine("Available books:");
                    foreach (string book in books)
                    {
                        Console.WriteLine(book);
                    }
                }
            }
            else if (action == "search")
            {
                Console.WriteLine("Enter the title of the book to search:");
                string searchBook = Console.ReadLine();
                if (books.Contains(searchBook))
                {
                    Console.WriteLine("Book found.");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
            else if (action == "borrow")
            {
                if (borrowedBooks.Count >= maxBorrowedBooks)
                {
                    Console.WriteLine("You have already borrowed the maximum number of books.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to borrow:");
                    string borrowBook = Console.ReadLine();
                    if (books.Contains(borrowBook))
                    {
                        borrowedBooks.Add(borrowBook);
                        books.Remove(borrowBook);
                        Console.WriteLine("Book borrowed.");
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
            }
            else if (action == "return")
            {
                if (borrowedBooks.Count == 0)
                {
                    Console.WriteLine("You have not borrowed any books.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to return:");
                    string returnBook = Console.ReadLine();
                    if (borrowedBooks.Remove(returnBook))
                    {
                        books.Add(returnBook);
                        Console.WriteLine("Book returned.");
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', 'list', 'search', 'borrow', 'return', or 'exit'.");
            }
        }
    }
}
