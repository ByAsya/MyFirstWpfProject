namespace MyProject
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

        public string answer { get; set; }

        [StringLength(20)]
        public string topicT { get; set; }

        public virtual Topic Topic1 { get; set; }
    }
}
