//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AthleteAdda.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Newsfeed
    {
        public int NewsFeed_Id { get; set; }
        public Nullable<System.DateTime> Datetime { get; set; }
        public Nullable<int> Publisher_Id { get; set; }
        public string Content { get; set; }
        public string Image_Path { get; set; }
        public Nullable<bool> IsPublished { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsVerified { get; set; }
        public string Comment_by_Reviewer { get; set; }
    }
}