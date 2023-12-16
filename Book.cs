public class Book {
    private string author;
    private string title;

    public Book(string author, string title) {
        this.author = author;
        this.title = title;
    }

    public string GetAuthor() {
        return author;
    }

    public string GetTitle() {
        return title;
    }

    public override string ToString() {
        return $"{author}, {title}";
    }
}

public class Library {
    private List<List<List<Book>>> shelves;

    public Library() {
        shelves = new List<List<List<Book>>>();
        for (int i = 0; i < 3; i++) {
            var floor = new List<List<Book>>();
            for (int j = 0; j < 30; j++) {
                var shelf = new List<Book>();
                for (int k = 0; k < 6; k++) {
                    var compartment = new Book("Unknown", "Unknown");
                    shelf.Add(compartment);
                }
                floor.Add(shelf);
            }
            shelves.Add(floor);
        }
    }

    public void AddBook(int floor, int shelf, int compartment, Book book) {
        if (IsValidPosition(floor, shelf, compartment)) {
            shelves[floor - 1][shelf - 1][compartment - 1] = book;
        }
    }

    public bool ContainsBook(int floor, int shelf, int compartment) {
        return IsValidPosition(floor, shelf, compartment) &&
            shelves[floor - 1][shelf - 1][compartment - 1].GetAuthor() != "Unknown";
    }

    public string GetBooks(int floor, int shelf) {
        if (IsValidPosition(floor, shelf, 1)) {
            var books = shelves[floor - 1][shelf - 1];
            string result = $"Shelf {shelf}\n";
            foreach (var book in books) {
                result += $"{book}\n";
            }
            return result;
        }
        return "Shelf not found";
    }

    private bool IsValidPosition(int floor, int shelf, int compartment) {
        return floor > 0 && floor <= shelves.Count &&
            shelf > 0 && shelf <= shelves[floor - 1].Count &&
            compartment > 0 && compartment <= shelves[floor - 1][shelf - 1].Count;
    }

}