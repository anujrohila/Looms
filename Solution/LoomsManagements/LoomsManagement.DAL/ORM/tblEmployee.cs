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
    
    public partial class tblEmployee
    {
        public tblEmployee()
        {
            this.tblAttendanceMSTs = new HashSet<tblAttendanceMST>();
            this.tblSalaryMSTs = new HashSet<tblSalaryMST>();
        }
    
        public long EmployeeID { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public Nullable<long> EmployeeTypeID { get; set; }
        public string EmployeeCode { get; set; }
        public string JobTitle { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ResidentialAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public string IDProfe { get; set; }
        public string IDProfeNo { get; set; }
        public byte[] Photo { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public Nullable<System.DateTime> LeaveDate { get; set; }
        public Nullable<int> SponsorsID { get; set; }
        public string Shift { get; set; }
        public Nullable<double> Salary { get; set; }
        public Nullable<double> PerDayWorkingHours { get; set; }
        public Nullable<double> PerHourSalary { get; set; }
        public Nullable<bool> PaymentType { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNo { get; set; }
        public string RTGSNo { get; set; }
        public string IFSCCode { get; set; }
        public Nullable<double> OpeningBalance { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBY { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<tblAttendanceMST> tblAttendanceMSTs { get; set; }
        public virtual tblEmployeeTypeMST tblEmployeeTypeMST { get; set; }
        public virtual ICollection<tblSalaryMST> tblSalaryMSTs { get; set; }
    }
}
