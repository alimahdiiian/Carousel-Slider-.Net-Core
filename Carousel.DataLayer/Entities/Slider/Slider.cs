using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carousel.DataLayer.Entities.Slider
{
     public class Slider
    {

        [Key]
        public int SliderId { get; set; }

        [Display(Name = "Slider Title")]
        [Required(ErrorMessage = " Please enter {0}")]
        public string SliderTitle { get; set; }

        //this property has no maxlength, because should be nvarcharmax
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please enter {0} ")]
        public string SliderDescription { get; set; }


        [Display(Name = "Additional Comment ")]
        public string SliderComment { get; set; }

        [Required(ErrorMessage = "Please enter {0} ")]
        [Display(Name = "Address")]
        [Url(ErrorMessage = "The address enterd is wrong ")]
        public string Url { get; set; }

        [Display(Name = "Photo")]
        public string ImageName { get; set; }

        [Display(Name = "StartDate")]
        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}",
            ApplyFormatInEditMode =true)]
        public System.DateTime StartDate { get; set; }

        [Display(Name = "EndDate")]
        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}",
            ApplyFormatInEditMode = true)]
        public System.DateTime EndDate { get; set; }

        [Display(Name = "Active ?")]
        public bool IsActive { get; set; }
    }



}
