﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LoomsManagementEntities : DbContext
    {
        public LoomsManagementEntities()
            : base("name=LoomsManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tblAttendanceMST> tblAttendanceMSTs { get; set; }
        public DbSet<tblBankMST> tblBankMSTs { get; set; }
        public DbSet<tblBeemProcess> tblBeemProcesses { get; set; }
        public DbSet<tblBemProcessDetail> tblBemProcessDetails { get; set; }
        public DbSet<tblBoilerProcess> tblBoilerProcesses { get; set; }
        public DbSet<tblBolierProcessDetail> tblBolierProcessDetails { get; set; }
        public DbSet<tblBranchMST> tblBranchMSTs { get; set; }
        public DbSet<tblBrokersMST> tblBrokersMSTs { get; set; }
        public DbSet<tblCompany> tblCompanies { get; set; }
        public DbSet<tblCompanyMachineMST> tblCompanyMachineMSTs { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<tblEmployeeTypeMST> tblEmployeeTypeMSTs { get; set; }
        public DbSet<tblLoomProcess> tblLoomProcesses { get; set; }
        public DbSet<tblLoomProcessWork> tblLoomProcessWorks { get; set; }
        public DbSet<tblMachineMST> tblMachineMSTs { get; set; }
        public DbSet<tblMachineTypeMST> tblMachineTypeMSTs { get; set; }
        public DbSet<tblMandingProcess> tblMandingProcesses { get; set; }
        public DbSet<tblMendingDetailsProcess> tblMendingDetailsProcesses { get; set; }
        public DbSet<tblMendingPenulty> tblMendingPenulties { get; set; }
        public DbSet<tblPartysMST> tblPartysMSTs { get; set; }
        public DbSet<tblPenaltyMST> tblPenaltyMSTs { get; set; }
        public DbSet<tblProductQualityMST> tblProductQualityMSTs { get; set; }
        public DbSet<tblProfeListMst> tblProfeListMsts { get; set; }
        public DbSet<tblSalaryMST> tblSalaryMSTs { get; set; }
        public DbSet<tblTFOProcess> tblTFOProcesses { get; set; }
        public DbSet<tblWindingWork> tblWindingWorks { get; set; }
        public DbSet<tblWithdrownMST> tblWithdrownMSTs { get; set; }
        public DbSet<tblWorkingYear> tblWorkingYears { get; set; }
        public DbSet<tblYarnPackageType> tblYarnPackageTypes { get; set; }
        public DbSet<tblYarnPurchase> tblYarnPurchases { get; set; }
        public DbSet<tblYarnPurchaseItem> tblYarnPurchaseItems { get; set; }
        public DbSet<tblYarnQualityMST> tblYarnQualityMSTs { get; set; }
        public DbSet<tblYarnTypeMST> tblYarnTypeMSTs { get; set; }
        public DbSet<WithdrownReturnMST> WithdrownReturnMSTs { get; set; }
        public DbSet<tblBeamMST> tblBeamMSTs { get; set; }
        public DbSet<tblFiscalYear> tblFiscalYears { get; set; }
    }
}
