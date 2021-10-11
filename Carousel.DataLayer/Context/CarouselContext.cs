using Carousel.DataLayer.Entities.Slider;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carousel.DataLayer.Context
{
     public  class CarouselContext:DbContext
    {
        public CarouselContext (DbContextOptions<CarouselContext> options)
            :base(options)
        {
            //base class namely DbContext is an Abstract class ,
            //therefore the options should be set there 

        }

        //Context Classes
        public DbSet<Slider> Sliders { get; set; }


    }



}
