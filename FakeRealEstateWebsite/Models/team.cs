namespace FakeRealEstateWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("realfakeestate.team")]
    public partial class team
    {
        [Key]
        public int team_id { get; set; }

        public int fk_agent_id { get; set; }

        public int fk_assist_id { get; set; }

        public virtual agent agent { get; set; }

        public virtual assistant assistant { get; set; }
    }
}
