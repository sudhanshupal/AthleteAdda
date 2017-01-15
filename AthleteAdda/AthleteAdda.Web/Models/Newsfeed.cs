using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AthleteAdda.Web.Models
{
    public class Newsfeed
    {
        public int NewsFeed_Id { get; set; }
        public string Datetime { get; set; }
        public int Publisher_Id { get; set; }
        public string Content { get; set; }
        public string Image_Path { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsVerified { get; set; }
        public string Comment_by_Reviewer { get; set; }
    }
}