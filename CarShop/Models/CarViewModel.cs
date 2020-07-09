using CarShop.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace CarShop.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Մոդել")]
        public string ModelName { get; set; }
        [Display(Name = "Մոդիֆիկացիա")]
        public string Modefication { get; set; }
        [Display(Name = "Տարեթիվ")]
        [Required]
        public int Year { get; set; }
        [Required]
        [Display(Name = "Թափք")]
        public BodyStyle Bodystyle { get; set; }
        [Display(Name = "Վազք")]
        [Required]
        public uint Mileage { get; set; }
        [Required]
        [Display(Name = "Գույն")]
        public string CarModelColor { get; set; }
        [Required]
        [Display(Name = "Փոխանցման տուփ")]
        public GearBox Gearbox { get; set; }
        [Required]
        [Display(Name = "Շարժիչ")]
        public FuelType Fueltype { get; set; }
        [Required]
        [Display(Name = "Ղեկ")]
        public HandDrive Handdrive { get; set; }
        [Display(Name = "Մաքսազերծված")]
        [Required]
        public CustomCleared Customcleared { get; set; }
        [Required]
        [Display(Name = "Գին")]
        public uint Price { get; set; }

        [Display(Name = "Նկար")]
        public List<IFormFile> CarModelImage { get; set; }

        [Display(Name = "Թոփ հայտարարություն")]
        public bool TopAnnouncements { get; set; }

        [Display(Name = "Շարժիչի ծավալ")]
        //[Range(0.1, 7.3)]
       
        public string EngineValue { get; set; }

        [Display(Name = "Նկարագրություն")]
        public string Description { get; set; }
        [Display(Name = "Ձիաուժ")]
        public int? HoursePower { get; set; }
        [Display(Name = "Սրահի գույն")]
        public string CarModelExteriorColor { get; set; }
        [Display(Name = "Դռների քանակ")]
        public int DoorCount { get; set; }
        [Display(Name = "Քարշակ")]
        public DriveTrain Drivetrain { get; set; }
        [Display(Name = "Վիճակ")]
        public Condition Condition { get; set; }

        [Display(Name = "Vin")]
        public string Vin { get; set; }
        [Required]
        [Display(Name = "Մակնիշ")]
        public int CarMakerId { get; set; }
        public CarMaker CarMaker { get; set; }
    }
}
