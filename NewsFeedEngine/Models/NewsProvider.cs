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
    
    public partial class NewsProvider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NewsProvider()
        {
            this.NewsArticles = new HashSet<NewsArticle>();
            this.NewsFeeds = new HashSet<NewsFeed>();
        }
    
        public int ProviderId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Nullable<int> CountryId { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsArticle> NewsArticles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsFeed> NewsFeeds { get; set; }
    }
}
