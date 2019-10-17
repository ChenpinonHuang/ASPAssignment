using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment.Models
{
    public class TerrestrialAnimal
    {
        [Key]
        public int TerrestrialId { get; set; }
        [ForeignKey("Genre")]
        public int AnimalId { get; set; }
        public string Category { get; set; }
        public double Weight { get; set; }
        public double LifeSpan { get; set; }

        public Animal Animal { get; set; }
    }
    
}
