using Carousel.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carousel.Web.ViewComponents
{
    public class SliderComponent :ViewComponent
    {
        private readonly ISliderService _sliderService;
        public SliderComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }


       public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)
                View("/Views/Shared/Components/SliderComponent.cshtml"
                ,_sliderService.GetAllSlidersAsync()));
        }

        
    }



}
