namespace MyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [StringLength(100)]
        public string mail { get; set; }

        [StringLength(100)]
        public string pictureProfile { get; set; }

        [Required]
        [StringLength(20)]
        public string nameU { get; set; }

        [Required]
        [StringLength(10)]
        public string passwordU { get; set; }

        [StringLength(20)]
        public string topic { get; set; }

        public int? points { get; set; }

        public virtual Topic Topic1 { get; set; }
    }
}
