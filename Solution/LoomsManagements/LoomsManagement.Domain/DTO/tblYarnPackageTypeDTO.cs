//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-09 - 14:23:52
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
    public partial class tblYarnPackageTypeDTO
    {
        [DataMember()]
        public Int64 YarnPackageTypeID { get; set; }

        [DataMember()]
        public String TypeName { get; set; }

        [DataMember()]
        public Nullable<Boolean> IsDelete { get; set; }

        [DataMember()]
        public Nullable<Boolean> IsActive { get; set; }

        [DataMember()]
        public Nullable<Int32> CreatedBy { get; set; }

        [DataMember()]
        public Nullable<DateTime> CreatedDateTime { get; set; }

        [DataMember()]
        public Nullable<Int32> UpdatedBy { get; set; }

        [DataMember()]
        public Nullable<DateTime> UpdatedDateTime { get; set; }

        [DataMember()]
        public List<Int64> tblYarnPurchaseItems_PurchaseItemID { get; set; }

        public tblYarnPackageTypeDTO()
        {
        }

        public tblYarnPackageTypeDTO(Int64 yarnPackageTypeID, String typeName, Nullable<Boolean> isDelete, Nullable<Boolean> isActive, Nullable<Int32> createdBy, Nullable<DateTime> createdDateTime, Nullable<Int32> updatedBy, Nullable<DateTime> updatedDateTime, List<Int64> tblYarnPurchaseItems_PurchaseItemID)
        {
			this.YarnPackageTypeID = yarnPackageTypeID;
			this.TypeName = typeName;
			this.IsDelete = isDelete;
			this.IsActive = isActive;
			this.CreatedBy = createdBy;
			this.CreatedDateTime = createdDateTime;
			this.UpdatedBy = updatedBy;
			this.UpdatedDateTime = updatedDateTime;
			this.tblYarnPurchaseItems_PurchaseItemID = tblYarnPurchaseItems_PurchaseItemID;
        }
    }
}