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
    
    public partial class tblYarnPurchase
    {
        public tblYarnPurchase()
        {
            this.tblYarnPurchaseItems = new HashSet<tblYarnPurchaseItem>();
        }
    
        public long PurchaseID { get; set; }
        public Nullable<int> SRNo { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public long PartyID { get; set; }
        public Nullable<long> BrokerID { get; set; }
        public Nullable<long> YearID { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public string ChallanNo { get; set; }
        public string LRNo { get; set; }
        public string RecieveAt { get; set; }
        public string Grade { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<bool> IsDelete { get; set; }
      
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpDatedDateTime { get; set; }
    
        public virtual ICollection<tblYarnPurchaseItem> tblYarnPurchaseItems { get; set; }
    }
}
