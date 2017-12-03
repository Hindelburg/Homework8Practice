namespace HW8Practice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Classification
    {
        public int id { get; set; }

        public int idA { get; set; }

        public int idG { get; set; }

        public virtual Artwork Artwork { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
