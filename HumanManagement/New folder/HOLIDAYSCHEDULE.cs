//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumanManagement.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOLIDAYSCHEDULE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOLIDAYSCHEDULE()
        {
            this.EMPLOYEEs = new HashSet<EMPLOYEE>();
        }
    
        public int holidayschedule_id { get; set; }
        public System.DateTime holidayschedule_date { get; set; }
        public string holidayschedule_name { get; set; }
        public int holidayschedule_hours { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEE> EMPLOYEEs { get; set; }
    }
}
