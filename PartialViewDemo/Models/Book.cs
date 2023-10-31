using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartialViewDemo.Models
{

    [Table("Book")]//map class with table in DB
    public class Book
    {
        [Key]// this is pk col in DB
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Author { get; set; }

        [Required]
        public int Price { get; set; }


    }
}
