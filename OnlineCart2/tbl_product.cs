//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineCart2
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_product()
        {
            this.tbl_order_details = new HashSet<tbl_order_details>();
            this.tbl_images = new HashSet<tbl_images>();
        }
    
        public int pid { get; set; }
        public string pname { get; set; }
        public int pprice { get; set; }
        public string pdetails { get; set; }
        public Nullable<int> cid { get; set; }
    
        public virtual tbl_category tbl_category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_order_details> tbl_order_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_images> tbl_images { get; set; }
    }
}
