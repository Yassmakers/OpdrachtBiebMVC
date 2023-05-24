using BiebWebApp.Models;
namespace BiebWebApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public ItemType ItemType { get; set; } // ItemType is een Enum met waarden als Book, CD, etc.
        public int Year { get; set; }
        public string Location { get; set; }
    }
}