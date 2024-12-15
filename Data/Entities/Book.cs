namespace BackendDemo.Data.Entities
{
    public class Book
    {
        public Book()
        {
            Genres = new HashSet<Genre>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Owner { get; set; }

        public DateTime CheckedOutAt { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime ReturnedAt { get; set; }

        public string RequiredRole { get; set; }

        // Navigation properties
        public ICollection<Genre> Genres { get; set; }
    }
}
