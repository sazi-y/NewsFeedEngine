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
    
    public partial class removeDuplicateNewsArticles_Result
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public Nullable<int> ProviderId { get; set; }
        public string Picture { get; set; }
        public string Url { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public string SEOURL { get; set; }
        public Nullable<int> VisitCount { get; set; }
    }
}
