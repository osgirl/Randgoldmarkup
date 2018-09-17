using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DevExtremeMvcApp1.Models
{
    public class FormLayoutFeaturesModel
    {

        [Required(ErrorMessage = "Please provide a date.")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Please provide the type of shift.")]
        public string Shift { get; set; }
        public string Operator { get; set; }
        public string JumboId { get; set; }
        public string UGLocationHeadingSize { get; set; }

        public string EntryPeriod { get; set; }

        public string DrillSteelLength { get; set; }
        public string FaceHoleLength { get; set; }
        public string FaceHoles { get; set; }
        public string FaceHolesMetres { get; set; }
        public string StrippingHoles { get; set; }
        public string StrippingMetres { get; set; }
        public string ReamerHoles { get; set; }
        public string ReamerHolesMetres { get; set; }
        public string CableBoltMetres { get; set; }

        public string PinHoleHoles { get; set; }
        public string PinHoleHolesMetres { get; set; }

        public string DrivingCutsFired { get; set; }
        public string DrivingCutsFiredMetres { get; set; }
        public string DrivingCutsFiredAdv { get; set; }
        public string DrivingCutsFiredVol { get; set; }
                
        public string ContractItem1 { get; set; }
        public string PieceRateCode1 { get; set; }

        public string StrippingHolesFired { get; set; }
        public string StrippingHolesFiredVol { get; set; }

        public string Contractitem2 { get; set; }
        public string PieceRateCode2 { get; set; }


        public string WetHolesFired { get; set; }

        public string ContractItem3 { get; set; }
        public string PieceRateCode3 { get; set; }

        public string TotalHolesFired { get; set; }
        public string BlastPlanReceived { get; set; }
        public string Shotfirer { get; set; }

        public string Comments { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[^0-9]+$", ErrorMessage = "Do not use digits in the Name.")]
        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "Name must have at least 2 symbols")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[\d\w\._\-]+@([\d\w\._\-]+\.)+[\w]+$", ErrorMessage = "Email is invalid")]
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime HireDate { get; set; }

        public string ActivityType { get; set; }
        public string Quantity { get; set; }






    }
}