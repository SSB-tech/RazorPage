using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Model
{
    public class RazorCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        [Range(1,100,ErrorMessage ="Display Order Must be Betweem 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
