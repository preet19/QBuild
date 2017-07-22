namespace QBuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bom")]
    public partial class bom
    {
        [StringLength(15)]
        public string PARENT_NAME { get; set; }

        public int? QUANTITY { get; set; }

        [StringLength(19)]
        public string COMPONENT_NAME { get; set; }

        public int ID { get; set; }
    }
}
