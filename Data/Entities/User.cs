namespace BackendDemo.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        
        // Foreign key for Role
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
} 