//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practika.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Groups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Groups()
        {
            this.Applicationsss = new HashSet<Applicationsss>();
            this.Participant = new HashSet<Participant>();
            this.Schedule = new HashSet<Schedule>();
        }
    
        public int Group_code { get; set; }
        public Nullable<int> Number_of_students { get; set; }
        public Nullable<int> Teacher_code { get; set; }
        public Nullable<int> Audience_code { get; set; }
        public Nullable<int> Load_code { get; set; }
        public Nullable<int> Specialty_Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicationsss> Applicationsss { get; set; }
        public virtual Audience Audience { get; set; }
        public virtual Load Load { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual Teachers Teachers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participant> Participant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
