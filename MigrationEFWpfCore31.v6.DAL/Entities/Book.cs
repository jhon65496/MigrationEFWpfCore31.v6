
namespace MigrationEFWpfCore31.v6.DAL.Entities
{
    public class Book 
    {    
        public int BookId { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
    }
}
