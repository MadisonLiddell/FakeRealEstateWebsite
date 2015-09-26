namespace FakeRealEstateWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("realfakeestate.assistant")]
    public partial class assistant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public assistant()
        {
            teams = new HashSet<team>();
        }

        [Key]
        public int assist_id { get; set; }

        [Required]
        [StringLength(20)]
        public string assist_fname { get; set; }

        [Required]
        [StringLength(20)]
        public string assist_lname { get; set; }

        public long? assist_phone { get; set; }

        [Required]
        [StringLength(30)]
        public string assist_address { get; set; }

        [Column(TypeName = "date")]
        public DateTime assist_date_join { get; set; }

        [Required]
        [StringLength(21)]
        public string assist_city { get; set; }

        [Required]
        [StringLength(21)]
        public string assist_state { get; set; }

        public int assist_zipcode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<team> teams { get; set; }
    }
}
