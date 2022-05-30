using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace BooksAndAuthor {
    
    [DataContract]
    public record AuthorAndBooks {
        [DataMember]
        string? author;
        [DataMember]
        List<string> booksList;

        public AuthorAndBooks() {
            booksList = new List<string>();
        }
        public AuthorAndBooks(string _author) : this() {
            Author = _author;
        }
        [DataMember]
        public string Author {
            get => author!;
            set {
                value = value.Trim();
                if (value != null || value!.Length > 2) author = value;
                else {
                    _ = value ?? throw new ArgumentNullException("Author is Null", nameof(value));
                    if (value!.Length < 2) throw new ArgumentException("Author name is not corect");
                }

            }
        }
        [DataMember]
        public List<string> GetBooksList { get => booksList; set => booksList = value; }
       
        public void SetBooksInList(string book) {
            book = book.Trim();
            if (book != null || book!.Length > 1) {
                booksList.Add(book);
            }
            else {
                _ = book ?? throw new ArgumentNullException("Book is null", nameof(SetBooksInList));
                if (book.Length < 1) throw new ArgumentNullException("The title of the book is not correct", nameof(SetBooksInList));
            }
        }
    }
}
