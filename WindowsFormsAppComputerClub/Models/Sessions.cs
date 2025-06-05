namespace WindowsFormsAppComputerClub.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sessions
    {
        public int id { get; set; }

        public int? user_id { get; set; }

        public int? computer_id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_time { get; set; }

        public decimal? total_cost { get; set; }

        [StringLength(20)]
        public string status { get; set; }

        public virtual Computers Computers { get; set; }

        public virtual Users Users { get; set; }
    }
}
