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
    
    public partial class Authorization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Authorization()
        {
            this.Applicationsss = new HashSet<Applicationsss>();
        }
    
        public int IdAuth { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> Student_code { get; set; }
        public Nullable<int> Item_number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicationsss> Applicationsss { get; set; }
        public virtual Participant Participant { get; set; }
        public virtual Role Role { get; set; }
        public virtual Selection_committee Selection_committee { get; set; }
    }
}
