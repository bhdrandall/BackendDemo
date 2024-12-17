namespace BackendDemo.Models    
{
    public class BookCreateRequest
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Owner { get; set; }

        public List<int> GenreIds { get; set; }

        public string RequiredRole { get; set; }
    }
}