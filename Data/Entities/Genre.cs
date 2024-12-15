namespace BackendDemo.Data.Entities
{
    public class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        // Navigation properties
        public ICollection<Book> Books { get; set; }
    }
}
