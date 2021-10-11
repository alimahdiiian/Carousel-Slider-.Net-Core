using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carousel.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Carousel.DataLayer.Entities.Slider;

namespace Carousel.Web.Pages.Admin.Slider
{
    public class IndexModel : PageModel
    {
        //IOC
        private readonly ISliderService _sliderService;
        public IndexModel(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }


        public List<Carousel.DataLayer.Entities.Slider.Slider> 
            SliderList { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            SliderList =await _sliderService.GetAllSlidersAsync();

            return Page();
        }



       public void OnPost()
        {

        }

        //use a handler to delete Slider
        public async Task<IActionResult> OnPostDeleteSlider(int Id)
        {
            Carousel.DataLayer.Entities.Slider.Slider slider =
                    await _sliderService.GetSliderById(Id);

            await _sliderService.DeleteSliderAsync(slider);

            return RedirectToPage("Index");
        }








    }
}
