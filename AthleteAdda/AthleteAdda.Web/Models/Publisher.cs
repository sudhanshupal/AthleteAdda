using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AthleteAdda.Web.Models
{
    public class Publisher
    {
        public int Publisher_Id { get; set; }
        public string Publisher_Name { get; set; }
        public string Email_Id { get; set; }
        public string Mobile_No { get; set; }
        public string Display_Name { get; set; }
        public string Display_Picture { get; set; }
    }
}