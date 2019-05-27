namespace MyProject.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Task
    {
        [Key]
        public int nameTask { get; set; }

        public string textTask { get; set; }

        [StringLength(100)]
        public string answers { get; set; }

        [StringLength(100)]
        public string topic { get; set; }

        public virtual Topic Topic1 { get; set; }
    }
}
