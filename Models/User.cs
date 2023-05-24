namespace BiebWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserType Type { get; set; } // UserType enum
                                           // Add or remove properties as needed
    }
}