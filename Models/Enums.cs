using BiebWebApp.Models;
namespace BiebWebApp.Models
{
    // Enumeration representing the type of an item
    public enum ItemType
    {
        Book,
        Magazine,
        Newspaper,
        DVD
    }

    // Enumeration representing the status of an item
    public enum ItemStatus
    {
        Available,
        Reserved,
        Loaned
    }

   
  

    // Enumeration representing the type of a user
    public enum UserType
    {
        Member,
        Librarian,
        Administrator
    }
}
