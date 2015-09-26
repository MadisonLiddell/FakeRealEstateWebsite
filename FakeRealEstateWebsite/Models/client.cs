namespace FakeRealEstateWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("realfakeestate.client")]
    public partial class client
    {
        [Key]
        public int client_id { get; set; }

        [Required]
        [StringLength(20)]
        public string client_fname { get; set; }

        [Required]
        [StringLength(20)]
        public string client_lname { get; set; }

        public int client_phone { get; set; }

        [Required]
        [StringLength(30)]
        public string client_address { get; set; }

        [Column(TypeName = "date")]
        public DateTime client_date_join { get; set; }
    }
}
