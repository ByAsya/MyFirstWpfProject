namespace MyProject.Database
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

        [StringLength(200)]
        public string pictureProfile { get; set; }

        [Required]
        [StringLength(20)]
        public string nameU { get; set; }

        [Required]
        [StringLength(10)]
        public string passwordU { get; set; }

        public int? pointsOne { get; set; }

        public int? pointsTwo { get; set; }

        public int? pointsThree { get; set; }

        public int? pointsFour { get; set; }
    }
}
