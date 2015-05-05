//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-09 - 14:23:36
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
    public partial class tblBoilerProcessDTO
    {
        [DataMember()]
        public Int64 BolierProcessID { get; set; }

        [DataMember()]
        public Nullable<Int64> MachineID { get; set; }

        [DataMember()]
        public Nullable<Int64> EmployeeID { get; set; }

        [DataMember()]
        public String Shift { get; set; }

        [DataMember()]
        public Nullable<DateTime> StartDateTime { get; set; }

        [DataMember()]
        public Nullable<DateTime> EndDateTime { get; set; }

        [DataMember()]
        public Nullable<Double> Tempreture { get; set; }

        [DataMember()]
        public Nullable<Boolean> IsDelete { get; set; }

        [DataMember()]
        public Nullable<Boolean> IsActive { get; set; }

        [DataMember()]
        public Nullable<Int32> UpdateBy { get; set; }

        [DataMember()]
        public Nullable<Int32> CreateBy { get; set; }

        [DataMember()]
        public Nullable<DateTime> UpdationDateTime { get; set; }

        [DataMember()]
        public Nullable<DateTime> CreationDateTIme { get; set; }

        [DataMember()]
        public List<Int64> tblBemProcessDetails_BemProcessDetailsID { get; set; }

        [DataMember()]
        public List<Int64> tblBolierProcessDetails_BoilerProcessDetailsID { get; set; }

        public tblBoilerProcessDTO()
        {
        }

        public tblBoilerProcessDTO(Int64 bolierProcessID, Nullable<Int64> machineID, Nullable<Int64> employeeID, String shift, Nullable<DateTime> startDateTime, Nullable<DateTime> endDateTime, Nullable<Double> tempreture, Nullable<Boolean> isDelete, Nullable<Boolean> isActive, Nullable<Int32> updateBy, Nullable<Int32> createBy, Nullable<DateTime> updationDateTime, Nullable<DateTime> creationDateTIme, List<Int64> tblBemProcessDetails_BemProcessDetailsID, List<Int64> tblBolierProcessDetails_BoilerProcessDetailsID)
        {
			this.BolierProcessID = bolierProcessID;
			this.MachineID = machineID;
			this.EmployeeID = employeeID;
			this.Shift = shift;
			this.StartDateTime = startDateTime;
			this.EndDateTime = endDateTime;
			this.Tempreture = tempreture;
			this.IsDelete = isDelete;
			this.IsActive = isActive;
			this.UpdateBy = updateBy;
			this.CreateBy = createBy;
			this.UpdationDateTime = updationDateTime;
			this.CreationDateTIme = creationDateTIme;
			this.tblBemProcessDetails_BemProcessDetailsID = tblBemProcessDetails_BemProcessDetailsID;
			this.tblBolierProcessDetails_BoilerProcessDetailsID = tblBolierProcessDetails_BoilerProcessDetailsID;
        }
    }
}
