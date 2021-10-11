using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carousel.Core.Generator
{
     public static class NameBuilder
    {
        public static string UniqueCodeGenerator()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
