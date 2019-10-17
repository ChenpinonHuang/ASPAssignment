using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Feture { get; set; }

        public List<TerrestrialAnimal> TerrestrialAnimal { get; set; }
    }

}
