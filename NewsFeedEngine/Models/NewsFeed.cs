//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsFeedEngine.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewsFeed
    {
        public int NewsFeedId { get; set; }
        public Nullable<int> ProviderId { get; set; }
        public string RssUrl { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual NewsCategory NewsCategory { get; set; }
        public virtual NewsProvider NewsProvider { get; set; }
    }
}
