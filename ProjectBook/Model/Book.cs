using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectBook.Model
{
    [Table("Book", Schema = "dbo")]
    public class Book
    {

        [Key]
        public int BookId { get; set; }

        public string BookName { get; set; }

        public string BookISBN { get; set; }

        public string BookAuthor { get; set; }

        public int BookStatus { get; set; }
    }
}
