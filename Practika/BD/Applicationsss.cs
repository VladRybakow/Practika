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
    
    public partial class Applicationsss
    {
        public int Application_code { get; set; }
        public string Description { get; set; }
        public string Teacher_FullName { get; set; }
        public string Speciality { get; set; }
        public Nullable<int> Student_code { get; set; }
        public Nullable<int> Group_code { get; set; }
        public Nullable<bool> Enrolled { get; set; }
    
        public virtual Participant Participant { get; set; }
        public virtual Groups Groups { get; set; }
    }
}
