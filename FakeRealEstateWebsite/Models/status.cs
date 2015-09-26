namespace FakeRealEstateWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("realfakeestate.status")]
    public partial class status
    {
        [Required]
        [StringLength(18)]
        public string stat_current { get; set; }

        [Column(TypeName = "date")]
        public DateTime stat_date_updated { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fk_prop_code { get; set; }

        public virtual property property { get; set; }
    }
}
