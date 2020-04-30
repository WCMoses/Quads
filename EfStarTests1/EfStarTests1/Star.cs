namespace EfStarTests1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Star
    {
        public int Id { get; set; }

        public double RaHours { get; set; }

        public double RaMinutes { get; set; }

        public double RaSeconds { get; set; }

        public double DecimalRa { get; set; }

        public double DecDegrees { get; set; }

        public double DecMinutes { get; set; }

        public double DecSeconds { get; set; }

        public double DecimalDec { get; set; }

        public double Magnitude { get; set; }

        public double Brightness { get; set; }

        public int Region { get; set; }
    }

    public class Region
    {
        public int Id { get; set; }
        public double MinRa { get; set; }
        public double MaxRa { get; set; }
        public double MinDec { get; set; }
        public double MaxDec { get; set; }

        public ICollection<Star> Stars { get; set; }
    }
}
