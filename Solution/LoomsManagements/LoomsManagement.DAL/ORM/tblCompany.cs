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
    
    public partial class tblCompany
    {
        public tblCompany()
        {
            this.tblCompanyMachineMSTs = new HashSet<tblCompanyMachineMST>();
        }
    
        public long CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string ComapnyCode { get; set; }
        public string OwnerName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string Address { get; set; }
        public string ContactPersonName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<double> InvestmentAmount { get; set; }
        public string PANNo { get; set; }
        public string CSTNo { get; set; }
        public string ECCNo { get; set; }
        public string SMSNO { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDateTime { get; set; }
    
        public virtual ICollection<tblCompanyMachineMST> tblCompanyMachineMSTs { get; set; }
    }
}
