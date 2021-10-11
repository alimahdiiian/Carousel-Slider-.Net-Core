using Carousel.Core.Security;
using Carousel.Core.Services.Interfaces;
using Carousel.DataLayer.Context;
using Carousel.DataLayer.Entities.Slider;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carousel.Core.Generator;

namespace Carousel.Core.Services
{
    public class SliderService : ISliderService
    {
        private readonly CarouselContext _context;
        public SliderService(CarouselContext context)
        {
            _context = context;
        }


        public async Task<List<Slider>> GetAllSlidersAsync()
        {
            return await Task.FromResult((_context.Sliders).ToList());                
              
        }

        public async Task<Slider> GetSliderById(int sliderId)
        {
            Slider slider =
                await _context.Sliders.FindAsync(sliderId);

            return slider;
        }

        public async Task<int> AddSlider(Slider slider,IFormFile sliderImg)
        {
            slider.ImageName = "NoImage.jpg";
            slider.StartDate = DateTime.Now;
            //Add slider image 
            if (sliderImg!=null && sliderImg.IsImage())
            {
                slider.ImageName = NameBuilder.UniqueCodeGenerator()
                    + Path.GetExtension(sliderImg.FileName);

                string imgPath = Path.Combine(Directory.GetCurrentDirectory(),
               "wwwroot/Slider", slider.ImageName);
                
                using (var stream=new FileStream(imgPath,FileMode.Create))
                {
                    sliderImg.CopyTo(stream);
                }
            }
           
           await _context.Sliders.AddAsync(slider);
            _context.SaveChanges();

            return  slider.SliderId;
        }

        public async Task<int> UpdateSliderAsync(Slider slider,IFormFile sliderImg)
        {
            if (sliderImg!=null && sliderImg.IsImage())
            {
                //delete old slide image 
                if (slider.ImageName!= "NoImage.jpg")
                {
                    string oldPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot/Slider", slider.ImageName);
                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }           

                }

                //add new slide image 
                slider.ImageName = NameBuilder.UniqueCodeGenerator()
                    + Path.GetExtension(sliderImg.FileName);
                string newPath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot/Slider", slider.ImageName);

                using (var stream = new FileStream(newPath, FileMode.Create))
                {
                    sliderImg.CopyTo(stream);
                }
            }

            _context.Sliders.Update(slider);
            _context.SaveChanges();

            return await Task.FromResult(slider.SliderId);
        }



        public async Task<int> DeleteSliderAsync(Slider slider)
        {
            //delete slider image
            if (slider.ImageName != "NoImage.jpg")
            {
                string oldPath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot/Slider", slider.ImageName);
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }

            }

            _context.Sliders.Remove(slider);
             _context.SaveChanges();

            return await Task.FromResult(slider.SliderId);
        }

        




       
    }

}
