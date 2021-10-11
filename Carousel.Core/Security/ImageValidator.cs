using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carousel.Core.Security
{
     public static class ImageValidator
    {
        public static bool IsImage(this IFormFile file )
        {
            try
            {
                var img =
                    System.Drawing.Image.FromStream(file.OpenReadStream());
                return true;
            }
            catch (Exception)
            {
                //if the entrance file is virus or other type of the file
                //except for image ,so method returns false 
                return false;
                throw;
            }
        }
    }
}
