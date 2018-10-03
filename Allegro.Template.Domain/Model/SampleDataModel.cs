using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Allegro.Template.Domain.Model
{
    /// <summary>
    /// All tables we will be creating in Database should be store in Domain.Model
    /// </summary>
    public class SampleDataModel: CanonicalDataModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Description { get; set; }
    }
}
