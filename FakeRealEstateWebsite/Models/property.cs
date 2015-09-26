namespace FakeRealEstateWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("realfakeestate.property")]
    public partial class property
    {
        [Key]
        public int prop_code { get; set; }

        [Required]
        [StringLength(10)]
        public string prop_type { get; set; }

        [Required]
        [StringLength(30)]
        public string prop_address { get; set; }

        [Required]
        [StringLength(20)]
        public string prop_owner_fname { get; set; }

        [Required]
        [StringLength(20)]
        public string prop_owner_lname { get; set; }

        public decimal prop_worth { get; set; }

        [Required]
        [StringLength(21)]
        public string prop_city { get; set; }

        [Required]
        [StringLength(21)]
        public string prop_state { get; set; }

        public int prop_zipcode { get; set; }

        public int fk_agent_id { get; set; }

        public virtual status status { get; set; }
    }
}
