//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoomsManagement.DAL.ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblWindingWork
    {
        public tblWindingWork()
        {
            this.tblTFOProcesses = new HashSet<tblTFOProcess>();
        }
    
        public int WindingProcessId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<long> PuchaseItemId { get; set; }
        public string Shift { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<double> TotalIssueWeight { get; set; }
        public Nullable<double> WastedWeight { get; set; }
        public Nullable<double> ProductionWeight { get; set; }
        public Nullable<int> NoOfCopes { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public Nullable<int> YarnQualityId { get; set; }
        public Nullable<int> YarnTypeId { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> UpdationDateTime { get; set; }
        public Nullable<System.DateTime> CreationDateTIme { get; set; }
    
        public virtual ICollection<tblTFOProcess> tblTFOProcesses { get; set; }
        public virtual tblYarnPurchaseItem tblYarnPurchaseItem { get; set; }
    }
}
