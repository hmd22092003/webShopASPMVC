//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mcvhoconline.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class discount_used_detail
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public string discount_id { get; set; }
        public string order_id { get; set; }
        public System.DateTime used_date { get; set; }
        public System.DateTime created_at { get; set; }
        public string created_by { get; set; }
        public System.DateTime updated_at { get; set; }
        public string updated_by { get; set; }
    
        public virtual discount discount { get; set; }
        public virtual order order { get; set; }
        public virtual user user { get; set; }
    }
}
