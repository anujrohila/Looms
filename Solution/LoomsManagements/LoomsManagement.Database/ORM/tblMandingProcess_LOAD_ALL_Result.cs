//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoomsManagement.Database.ORM
{
    using System;
    
    public partial class tblMandingProcess_LOAD_ALL_Result
    {
        public long MendingID { get; set; }
        public Nullable<int> TakaNo { get; set; }
        public Nullable<long> EmployeeID { get; set; }
        public string Grade { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public Nullable<double> TotalMeter { get; set; }
        public Nullable<int> TotalNoOfFaults { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdationDateTime { get; set; }
    }
}
