//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CabAgeDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeMaster
    {
        public EmployeeMaster()
        {
            this.EmployeeLocations = new HashSet<EmployeeLocation>();
            this.EmployeeSurveyResults = new HashSet<EmployeeSurveyResult>();
        }
    
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public Nullable<long> EmployeeMobileNumber { get; set; }
    
        public virtual ICollection<EmployeeLocation> EmployeeLocations { get; set; }
        public virtual ICollection<EmployeeSurveyResult> EmployeeSurveyResults { get; set; }
    }
}
