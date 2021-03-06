//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-09 - 14:23:37
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
    public partial class tblBolierProcessDetailDTO
    {
        [DataMember()]
        public Int64 BoilerProcessDetailsID { get; set; }

        [DataMember()]
        public Nullable<Int64> BoilerProcessID { get; set; }

        [DataMember()]
        public Nullable<Int64> TFORoleProcessID { get; set; }

        [DataMember()]
        public Nullable<Int32> IssueNoOfTFORoles { get; set; }

        [DataMember()]
        public Nullable<Double> IssueWeights { get; set; }

        [DataMember()]
        public Nullable<Int64> YarnQualityID { get; set; }

        [DataMember()]
        public Nullable<Int64> YarnTypeID { get; set; }

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
        public Nullable<Boolean> IsActive { get; set; }

        [DataMember()]
        public Int64 tblBoilerProcess_BolierProcessID { get; set; }

        [DataMember()]
        public Int64 tblTFOProcess_TFORoleProcessId { get; set; }

        public tblBolierProcessDetailDTO()
        {
        }

        public tblBolierProcessDetailDTO(Int64 boilerProcessDetailsID, Nullable<Int64> boilerProcessID, Nullable<Int64> tFORoleProcessID, Nullable<Int32> issueNoOfTFORoles, Nullable<Double> issueWeights, Nullable<Int64> yarnQualityID, Nullable<Int64> yarnTypeID, Nullable<Boolean> isDelete, Nullable<Int32> createdBy, Nullable<DateTime> createdDateTime, Nullable<Int32> updatedBy, Nullable<DateTime> updatedDateTime, Nullable<Boolean> isActive, Int64 tblBoilerProcess_BolierProcessID, Int64 tblTFOProcess_TFORoleProcessId)
        {
			this.BoilerProcessDetailsID = boilerProcessDetailsID;
			this.BoilerProcessID = boilerProcessID;
			this.TFORoleProcessID = tFORoleProcessID;
			this.IssueNoOfTFORoles = issueNoOfTFORoles;
			this.IssueWeights = issueWeights;
			this.YarnQualityID = yarnQualityID;
			this.YarnTypeID = yarnTypeID;
			this.IsDelete = isDelete;
			this.CreatedBy = createdBy;
			this.CreatedDateTime = createdDateTime;
			this.UpdatedBy = updatedBy;
			this.UpdatedDateTime = updatedDateTime;
			this.IsActive = isActive;
			this.tblBoilerProcess_BolierProcessID = tblBoilerProcess_BolierProcessID;
			this.tblTFOProcess_TFORoleProcessId = tblTFOProcess_TFORoleProcessId;
        }
    }
}
