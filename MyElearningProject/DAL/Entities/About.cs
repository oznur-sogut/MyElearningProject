using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public string AboutTitle { get; set; }
        public string AboutSubtitle { get; set; }
        public string AboutCard { get; set; }
    }
}