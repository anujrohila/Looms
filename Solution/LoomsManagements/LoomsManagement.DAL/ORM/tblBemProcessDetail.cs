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
    
    public partial class tblBemProcessDetail
    {
        public long BemProcessDetailsID { get; set; }
        public Nullable<long> BemProcessID { get; set; }
        public Nullable<long> TFORoleProcessID { get; set; }
        public Nullable<int> IssueNoOFCopes { get; set; }
        public Nullable<double> IssueWeights { get; set; }
        public Nullable<long> YarnQualityID { get; set; }
        public Nullable<long> YarnTypeID { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdationDateTime { get; set; }
    
        public virtual tblBeemProcess tblBeemProcess { get; set; }
        public virtual tblBoilerProcess tblBoilerProcess { get; set; }
        public virtual tblTFOProcess tblTFOProcess { get; set; }
    }
}
