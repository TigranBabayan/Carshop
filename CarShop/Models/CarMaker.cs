using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class CarMaker
    {
        public int Id { get; set; }
        public string CarName { get; set; }

        public ICollection<CarModel> CarModel { get; set; }
    }
}
