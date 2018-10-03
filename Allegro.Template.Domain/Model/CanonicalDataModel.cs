using System;
using System.ComponentModel.DataAnnotations;

namespace Allegro.Template.Domain.Model
{
    /// <summary>
    /// repetitive colums through out the data tables
    /// </summary>
    public class CanonicalDataModel
    {
        public DateTime? CreatedDate { get; set; }
        [MaxLength(255)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(255)]
        public string UpdatedBy { get; set; }
    }
}
