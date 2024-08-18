using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Diplay Order")]
    //    [Range(1,100,ErrorMessage ="Custom Error Message")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}
