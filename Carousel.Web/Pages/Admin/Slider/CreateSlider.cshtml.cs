using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Carousel.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Carousel.Web.Pages.Admin.Slider
{
    public class CreateSliderModel : PageModel
    {
        private readonly ISliderService _sliderService;
        public CreateSliderModel(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [BindProperty]
        public Carousel.DataLayer.Entities.Slider.Slider Slider { get; set; }
        
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost(IFormFile sliderImg)
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
           await _sliderService.AddSlider(Slider,sliderImg);

            return RedirectToPage("Index");
        }


    


    }
}





