//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Authority
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Authority()
        {
            this.Events = new HashSet<Event>();
        }
    
        public int Akey { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string TypeofInstitute { get; set; }
        public int MaxEvents { get; set; }
        public int MaxTerminal { get; set; }
        public int EventCount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }
    }
}
