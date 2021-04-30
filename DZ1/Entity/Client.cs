namespace DZ1.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdClient { get; set; }

        public int IdUserOfClient { get; set; }

        public int OrderId { get; set; }

        public bool? IdDeletid { get; set; }

        public virtual Orders Orders { get; set; }

        public virtual UserOfClient UserOfClient { get; set; }
    }
}
