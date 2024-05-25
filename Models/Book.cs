using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookish.Models
{
    [Table("BookStore")]
    public class Book
    {
        [Key]
        public long Book_Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Book_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Book_Author { get; set; }

        [Required]
        [Range(0, 1000)]
        public decimal Book_Price { get; set; }

        [Required]
        [Range(0, 5)]
        public double Book_Rating { get; set; }
    }
}

