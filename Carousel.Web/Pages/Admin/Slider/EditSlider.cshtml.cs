using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carousel.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Carousel.Web.Pages.Admin.Slider
{
    public class EditSliderModel : PageModel
    {
        private readonly ISliderService _sliderService;
        public EditSliderModel(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [BindProperty]
        public Carousel.DataLayer.Entities.Slider.Slider Slider { get; set; }

        public async Task<IActionResult> OnGet(int Id)
        {
            Slider =await _sliderService.GetSliderById(Id);

            return Page();
        }

        public async Task<IActionResult> OnPost(IFormFile sliderImg)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //edit slide
           await _sliderService.UpdateSliderAsync(Slider, sliderImg);

            return RedirectToPage("Index");
        }




    }
}
