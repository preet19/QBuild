namespace QBuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("part")]
    public partial class part
    {
        [StringLength(20)]
        public string NAME { get; set; }

        [StringLength(8)]
        public string TYPE { get; set; }

        [StringLength(4)]
        public string ITEM { get; set; }

        [StringLength(13)]
        public string PART_NUMBER { get; set; }

        [StringLength(61)]
        public string TITLE { get; set; }

        [StringLength(25)]
        public string MATERIAL { get; set; }

        public int ID { get; set; }
    }
}
