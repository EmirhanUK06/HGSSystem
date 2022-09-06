using HGSPROJECT.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGSPROJECT.Entity
{
    public class Bus : Car
    {
        public VehicleType VehicleType { get; set; } = VehicleType.bus;
    }
}
