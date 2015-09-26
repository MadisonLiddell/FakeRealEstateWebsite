namespace FakeRealEstateWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("realfakeestate.agent")]
    public partial class agent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public agent()
        {
            teams = new HashSet<team>();
        }

        [Required]
        [StringLength(20)]
        public string agent_fname { get; set; }

        [Required]
        [StringLength(20)]
        public string agent_lname { get; set; }

        [Key]
        public int agent_id { get; set; }

        public long? agent_phone { get; set; }

        [Required]
        [StringLength(30)]
        public string agent_address { get; set; }

        [Column(TypeName = "date")]
        public DateTime agent_date_join { get; set; }

        [Required]
        [StringLength(21)]
        public string agent_city { get; set; }

        [Required]
        [StringLength(21)]
        public string agent_state { get; set; }

        [Required]
        [StringLength(5)]
        public string agent_zipcode { get; set; }

        public int? fk_off_code { get; set; }

        public virtual office office { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<team> teams { get; set; }
    }
}
