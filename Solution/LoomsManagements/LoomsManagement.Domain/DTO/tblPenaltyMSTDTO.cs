//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-09 - 14:23:46
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
    public partial class tblPenaltyMSTDTO
    {
        [DataMember()]
        public Int64 PenaltyID { get; set; }

        [DataMember()]
        public String PenaltyCode { get; set; }

        [DataMember()]
        public String PenaltyName { get; set; }

        [DataMember()]
        public String Description { get; set; }

        [DataMember()]
        public Nullable<Boolean> IsDelete { get; set; }

        [DataMember()]
        public Nullable<Boolean> IsActive { get; set; }

        [DataMember()]
        public Nullable<Int32> CreateBy { get; set; }

        [DataMember()]
        public Nullable<DateTime> CreationDateTime { get; set; }

        [DataMember()]
        public Nullable<Int32> UpdateBy { get; set; }

        [DataMember()]
        public Nullable<DateTime> UpdationDateTime { get; set; }

        public tblPenaltyMSTDTO()
        {
        }

        public tblPenaltyMSTDTO(Int64 penaltyID, String penaltyCode, String penaltyName, String description, Nullable<Boolean> isDelete, Nullable<Boolean> isActive, Nullable<Int32> createBy, Nullable<DateTime> creationDateTime, Nullable<Int32> updateBy, Nullable<DateTime> updationDateTime)
        {
			this.PenaltyID = penaltyID;
			this.PenaltyCode = penaltyCode;
			this.PenaltyName = penaltyName;
			this.Description = description;
			this.IsDelete = isDelete;
			this.IsActive = isActive;
			this.CreateBy = createBy;
			this.CreationDateTime = creationDateTime;
			this.UpdateBy = updateBy;
			this.UpdationDateTime = updationDateTime;
        }
    }
}
