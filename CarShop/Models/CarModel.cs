using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;


namespace CarShop.Models
{
    public class CarModel
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
        public uint   Mileage { get; set; }
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
        public string CarModelImage { get; set; }

        [Display(Name = "Թոփ հայտարարություն")]
        public bool TopAnnouncements { get; set; }
        

        [Display(Name = "Շարժիչի ծավալ")]
       // [Range(0.1,7.3)]
       
        public string EngineValue { get; set; }

        [Display(Name = "Նկարագրություն")]
        public string Description { get; set; }
        [Display(Name = "Ձիաուժ")]
        public int? HoursePower { get; set; }
        [Display(Name = "Սրահի գույն")]
        public string CarModelExteriorColor { get; set; }
        [Display(Name = "Դռների քանակ")]
        public int DoorCount { get; set; }
        [Display(Name ="Քարշակ")]
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
    public enum BodyStyle
    {
        [Display(Name = "Սեդան")]
        Sedan,
        [Display(Name = "Հետչբեք")]
        Hatchback,
        [Display(Name = "Ունիվերսալ")]
        Wagon,
        [Display(Name = "Կուպե")]
        Coupe,
        [Display(Name = "Կաբրիոլետ/Ռոդսթեր")]
        Convertible,
        [Display(Name = "Ամենագնաց")]
        Suv,
        [Display(Name = "Պիկապ")]
        Pickup,
        [Display(Name = "Մինիվեն/Միկրոավտոբուս")]
        Minivan,
        [Display(Name = "Ֆուրգոն")]
        Van,
        [Display(Name = "Լիմուզին")]
        Limousine

    }

    public enum GearBox
    {
        [Display(Name = "Մեխանիկական")]
        Manual,
        [Display(Name = "Ավտոմատ")]
        Automatic,
        [Display(Name = "Կիսաավտոմատ")]
        Semi_Automatic,
        [Display(Name = "Վարիատոր")]
        CVT_Variable
    }

    public enum HandDrive
    {
        [Display(Name = "Ձախ")]
        Left,
        [Display(Name = "Աջ")]
        Right,
        [Display(Name = "Փոխված աջից ձախ")]
        Transformed_from_right_to_left
    }

    public enum FuelType
    {
        [Display(Name = "Բենզին")]
        Gasoline,
        [Display(Name = "Գազ")]
        Gas,
        [Display(Name = "Դիզել")]
        Diesel,
        [Display(Name = "Հիբրիդ")]
        Hybrid,
        [Display(Name = "Էլեկտրական")]
        Electric
    }

    public enum CustomCleared
    {
        [Display(Name = "Այո")]
        Yes,
        [Display(Name = "Ոչ")]
        No
    }

    public enum DriveTrain
    {
        [Display(Name = "Առժևի")]
        FWD,
        [Display(Name = "Ետևի")]
        RWD,
        [Display(Name = "Լիաքարշ")]
        AWD
    }

    public enum Condition
    {
        [Display(Name = "Գերազանց")]
        Excellent,
        [Display(Name = "Լավ")]
        Good,
        [Display(Name = "Նորմալ")]
        Average,
        [Display(Name = "Վթարբած")]
        Damaged,
        [Display(Name = "Պահեստամասերի համար")]
        For_pasts
    }









}
