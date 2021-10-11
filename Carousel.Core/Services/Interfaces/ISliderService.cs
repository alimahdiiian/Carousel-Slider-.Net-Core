using Carousel.DataLayer.Entities.Slider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace Carousel.Core.Services.Interfaces
{
     public interface ISliderService
    {
         Task<List<Slider>> GetAllSlidersAsync();
        
        Task<Slider> GetSliderById(int sliderId);

        Task<int> AddSlider(Slider slider , IFormFile sliderImg);
        

        Task<int> UpdateSliderAsync(Slider slider , IFormFile sliderImg);

       Task<int> DeleteSliderAsync(Slider slider);

    }

}
