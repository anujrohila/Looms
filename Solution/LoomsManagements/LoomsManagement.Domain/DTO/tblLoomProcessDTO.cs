//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-09 - 14:23:41
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
    public partial class tblLoomProcessDTO
    {
        [DataMember()]
        public Int64 LoomProcessID { get; set; }

        [DataMember()]
        public Nullable<Int64> BeemProcessID { get; set; }

        [DataMember()]
        public Nullable<Int64> MachineID { get; set; }

        [DataMember()]
        public Nullable<Double> NoofTFORole { get; set; }

        [DataMember()]
        public Nullable<DateTime> CreatoinDateTime { get; set; }

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

        public tblLoomProcessDTO()
        {
        }

        public tblLoomProcessDTO(Int64 loomProcessID, Nullable<Int64> beemProcessID, Nullable<Int64> machineID, Nullable<Double> noofTFORole, Nullable<DateTime> creatoinDateTime, Nullable<Boolean> isDelete, Nullable<Boolean> isActive, Nullable<Int32> createdBy, Nullable<DateTime> createdDateTime, Nullable<Int32> updatedBy, Nullable<DateTime> updatedDateTime)
        {
			this.LoomProcessID = loomProcessID;
			this.BeemProcessID = beemProcessID;
			this.MachineID = machineID;
			this.NoofTFORole = noofTFORole;
			this.CreatoinDateTime = creatoinDateTime;
			this.IsDelete = isDelete;
			this.IsActive = isActive;
			this.CreatedBy = createdBy;
			this.CreatedDateTime = createdDateTime;
			this.UpdatedBy = updatedBy;
			this.UpdatedDateTime = updatedDateTime;
        }
    }
}
