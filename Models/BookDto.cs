namespace BackendDemo.Models
{
    public class BookDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Owner { get; set; }

        public DateTime CheckedOutAt { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime ReturnedAt { get; set; }

        public string RequiredRole { get; set; }

        public ICollection<GenreDto> Genres { get; set; }
    }
}
