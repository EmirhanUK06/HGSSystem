using HGSPROJECT.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGSPROJECT.Entity
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public int HgsNumber { get; set; }
        public string Owner { get; set; }
        public DateTime Time { get; set; }
        public VehicleType VehicleType { get; set; } = VehicleType.car;
        public float Balance { get; set; }
    }
}
