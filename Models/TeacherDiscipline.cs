//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeacherDiscipline
    {
        public int Id { get; set; }
        public int AcademicYearStart { get; set; }
        public int AcademicYearEnd { get; set; }
        public int TotalHours { get; set; }
        public int GroupId { get; set; }
        public int TeacherId { get; set; }
        public int DisciplineId { get; set; }
    
        public virtual Discipline Discipline { get; set; }
        public virtual Group Group { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}