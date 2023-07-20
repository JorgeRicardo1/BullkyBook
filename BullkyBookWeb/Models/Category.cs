using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BullkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName ("Display order")]
        [Range(1,10,ErrorMessage = "Display order must be between 1 and 10 only")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDataRime { get; set; } = DateTime.Now;
    }
}
