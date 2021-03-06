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
    
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            this.Bookings = new HashSet<Booking>();
            this.Terminals = new HashSet<Terminal>();
        }
    
        public int EID { get; set; }
        public string Ename { get; set; }
        public string Edetails { get; set; }
        public int TerminalCount { get; set; }
        public System.DateTime EStartDay { get; set; }
        public System.DateTime EEndDate { get; set; }
        public int AID { get; set; }
        public Nullable<int> TimeRequired { get; set; }
    
        public virtual Authority Authority { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terminal> Terminals { get; set; }
    }
}
