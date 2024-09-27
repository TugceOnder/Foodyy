using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DtoLayer.Dtos.SliderDtos
{
    public class GetByIdSliderDto
    {
        public int SliderId { get; set; }
        public int Title { get; set; }
        public int ImageUrl { get; set; }
    }
}
