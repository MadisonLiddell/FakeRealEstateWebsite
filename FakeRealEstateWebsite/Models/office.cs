namespace FakeRealEstateWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("realfakeestate.office")]
    public partial class office
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public office()
        {
            agents = new HashSet<agent>();
        }

        [Key]
        public int off_code { get; set; }

        public long off_phone { get; set; }

        [Required]
        [StringLength(30)]
        public string off_address { get; set; }

        [Column(TypeName = "date")]
        public DateTime off_date_open { get; set; }

        [Column(TypeName = "date")]
        public DateTime? off_date_closed { get; set; }

        public int off_zipcode { get; set; }

        [Required]
        [StringLength(21)]
        public string off_city { get; set; }

        [Required]
        [StringLength(21)]
        public string off_state { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agent> agents { get; set; }
    }
}
