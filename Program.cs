string[] books = new string[5] { "", "", "", "", "" };

while (true)
{
    Console.Clear();
    Console.WriteLine("Menu:");
    
    bool canAddBook = Array.Exists(books, book => book == "");
    bool canRemoveBook = Array.Exists(books, book => book != "");

    if (canAddBook)
    {
        Console.WriteLine("1. Add a book");
    }
    if (canRemoveBook)
    {
        Console.WriteLine("2. Remove a book");
    }
    Console.WriteLine("3. Display all books");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            if (canAddBook)
            {
                Console.WriteLine("Enter a book title:");
                string bookTitle = Console.ReadLine();

                bool bookAdded = false;
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] == "")
                    {
                        books[i] = bookTitle;
                        bookAdded = true;
                        break;
                    }
                }
                if (!bookAdded)
                {
                    Console.WriteLine("No more books can be added.");
                } else {
                    Console.WriteLine("Book added successfully.");
                }
            }
            else
            {
                Console.WriteLine("No more books can be added.");
            }
            break;

        case "2":
            if (canRemoveBook)
            {
                Console.WriteLine("Enter a book title to remove:");
                string bookToRemove = Console.ReadLine();

                bool bookRemoved = false;
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] == bookToRemove)
                    {
                        books[i] = "";
                        bookRemoved = true;
                        break;
                    }
                }
                if (!bookRemoved)
                {
                    Console.WriteLine("Book title not found.");
                } else {
                    Console.WriteLine("Book removed successfully.");
                }
            }
            else
            {
                Console.WriteLine("No books to remove.");
            }
            break;

        case "3":
            Console.WriteLine("List of book titles:");
            foreach (string book in books)
            {
                if (book != "")
                {
                    Console.WriteLine(book);
                }
            }
            break;

        case "4":
            return;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
