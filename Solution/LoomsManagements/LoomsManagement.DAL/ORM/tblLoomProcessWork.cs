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
    
    public partial class tblLoomProcessWork
    {
        public long LoomProcessWorkID { get; set; }
        public Nullable<long> LoomProcessID { get; set; }
        public Nullable<long> EmployeeID { get; set; }
        public Nullable<System.DateTime> WorkingDate { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public string Shift { get; set; }
        public Nullable<double> MTRStart { get; set; }
        public Nullable<double> MTREnd { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }
}
