using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BOOKAPP
{
    public class Book
    {
        [Required]
        [Key]
    
        public int Bid { get; set; }
        public string Btitle { get; set; }
        [Display(Name ="Book Title")]
        [Required]
        public string Category{ get; set; }
        [DataType(DataType.Currency)]
        public double price { get; set; }
        public string AuthorName { get; set; }
        [Display(Name = "Author Name")]
        [Required]
        public string publisher{ get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Released Date")]
        [Required]
        public DateTime Releaseddate { get; set; }






    }
}
