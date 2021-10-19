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
    
    public partial class EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYEE()
        {
            this.BENEFICIARies = new HashSet<BENEFICIARY>();
            this.OVERTIMEs = new HashSet<OVERTIME>();
            this.TIMEOFFs = new HashSet<TIMEOFF>();
            this.WEEKLYSALARies = new HashSet<WEEKLYSALARY>();
            this.SKILLs = new HashSet<SKILL>();
            this.HOLIDAYSCHEDULEs = new HashSet<HOLIDAYSCHEDULE>();
        }
    
        public int employee_id { get; set; }
        public string employee_SSN { get; set; }
        public string employee_name { get; set; }
        public System.DateTime employee_dob { get; set; }
        public string employee_sex { get; set; }
        public string employee_maritalStatus { get; set; }
        public string employee_image { get; set; }
        public string employee_phone { get; set; }
        public string employee_address { get; set; }
        public string employee_mail { get; set; }
        public System.DateTime employee_hireDate { get; set; }
        public string employee_superiorName { get; set; }
        public int employee_balances { get; set; }
        public int employee_dept_id { get; set; }
        public int employee_gralv_id { get; set; }
        public int employee_jb_id { get; set; }
        public int employee_workstt_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BENEFICIARY> BENEFICIARies { get; set; }
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual GRADELEVEL GRADELEVEL { get; set; }
        public virtual JOB JOB { get; set; }
        public virtual WORKINGSTATU WORKINGSTATU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OVERTIME> OVERTIMEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIMEOFF> TIMEOFFs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WEEKLYSALARY> WEEKLYSALARies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SKILL> SKILLs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOLIDAYSCHEDULE> HOLIDAYSCHEDULEs { get; set; }
    }
}
