using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Carousel
    {
        public int CarouselID { get; set; }
        public string CarouselImageUrl { get; set; }
        public string CarouselTitle { get; set; }
        public string CarouselDescription { get; set; }
    }
}