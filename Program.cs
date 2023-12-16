class Program {
    static void Main() {
        Library myLibrary = new Library();

        Book myBook = new Book("Author Name", "Book Title");
        myLibrary.AddBook(1, 2, 3, myBook);

        bool containsBook = myLibrary.ContainsBook(1, 2, 3);
        Console.WriteLine("Book exists at specified position: " + containsBook);

        string booksOnShelf = myLibrary.GetBooks(1, 2);
        Console.WriteLine(booksOnShelf);
    }
}
