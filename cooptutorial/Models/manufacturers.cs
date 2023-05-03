using System.ComponentModel.DataAnnotations; // Key
using System.ComponentModel.DataAnnotations.Schema; // Auto Increment

namespace cooptutorial.Models
{
    public class manufacturers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increment
        public int id { get; set; }
        public string Title { get; set; }
    }
}
