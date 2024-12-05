using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Address
    {
        public int AddressID { get; set; }
        public string AddressDescription { get; set; }
        public string AddressMail { get; set; }
        public string AddressPhone { get; set; }
        public string AddressDetail { get; set; }
    }
}