//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADO_Exam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Disc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Disc()
        {
            this.Checkk = new HashSet<Checkk>();
        }
    
        public int Id { get; set; }
        public string Cover { get; set; }
        public string DiskTitle { get; set; }
        public string Singer { get; set; }
        public string Publisher { get; set; }
        public int Tracks { get; set; }
        public string Genre { get; set; }
        public System.DateTime YearPublishing { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Checkk> Checkk { get; set; }
    }
}