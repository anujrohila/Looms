//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-31 - 09:13:35
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace LoomsManagement.Domain.DTO
{
 
    [DataContract()]
    public partial class tblFiscalYearDTO
    {
        [DataMember()]
        public Int64 FiscalYearId { get; set; }

        [DataMember()]
        public String FiscalName { get; set; }

        [DataMember()]
        public Nullable<Boolean> IsActive { get; set; }

        [DataMember()]
        public Nullable<Boolean> IsDelete { get; set; }

        [DataMember()]
        public Nullable<Int32> CreatedBy { get; set; }

        [DataMember()]
        public Nullable<DateTime> CreatedDateTime { get; set; }

        [DataMember()]
        public Nullable<Int32> UpdatedBy { get; set; }

        [DataMember()]
        public Nullable<DateTime> UpdatedDateTime { get; set; }

        [DataMember()]
        public DateTime StartDate { get; set; }

        [DataMember()]
        public DateTime EndDate { get; set; }

        public tblFiscalYearDTO()
        {
        }

        public tblFiscalYearDTO(Int64 fiscalYearId, String fiscalName, Int32 startYear, Int32 endYear, Nullable<Boolean> isActive, Nullable<Boolean> isDelete, Nullable<Int32> createdBy, Nullable<DateTime> createdDateTime, Nullable<Int32> updatedBy, Nullable<DateTime> updatedDateTime, DateTime startDate, DateTime endDate)
        {
			this.FiscalYearId = fiscalYearId;
			this.FiscalName = fiscalName;
			this.IsActive = isActive;
			this.IsDelete = isDelete;
			this.CreatedBy = createdBy;
			this.CreatedDateTime = createdDateTime;
			this.UpdatedBy = updatedBy;
			this.UpdatedDateTime = updatedDateTime;
			this.StartDate = startDate;
			this.EndDate = endDate;
        }
    }
}
