//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-09 - 14:24:03
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using LoomsManagement.Domain.DTO;
using LoomsManagement.DAL.ORM;

namespace LoomsManagement.DAL
{

    /// <summary>
    /// Assembler for <see cref="tblSalaryMST"/> and <see cref="tblSalaryMSTDTO"/>.
    /// </summary>
    public static partial class tblSalaryMSTAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblSalaryMSTDTO"/> converted from <see cref="tblSalaryMST"/>.</param>
        static partial void OnDTO(this tblSalaryMST entity, tblSalaryMSTDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblSalaryMST"/> converted from <see cref="tblSalaryMSTDTO"/>.</param>
        static partial void OnEntity(this tblSalaryMSTDTO dto, tblSalaryMST entity);

        /// <summary>
        /// Converts this instance of <see cref="tblSalaryMSTDTO"/> to an instance of <see cref="tblSalaryMST"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblSalaryMSTDTO"/> to convert.</param>
        public static tblSalaryMST ToEntity(this tblSalaryMSTDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblSalaryMST();

            entity.SalaryID = dto.SalaryID;
            entity.EmployeeID = dto.EmployeeID;
            entity.Date = dto.Date;
            entity.StartDate = dto.StartDate;
            entity.EndDate = dto.EndDate;
            entity.WorkedHours = dto.WorkedHours;
            entity.TotalPenalty = dto.TotalPenalty;
            entity.Bonus = dto.Bonus;
            entity.WithdrownAmount = dto.WithdrownAmount;
            entity.WithdrownID = dto.WithdrownID;
            entity.NetSalary = dto.NetSalary;
            entity.IsDelete = dto.IsDelete;
            entity.IsActive = dto.IsActive;
            entity.CreateBy = dto.CreateBy;
            entity.CreationDateTime = dto.CreationDateTime;
            entity.UpdateBy = dto.UpdateBy;
            entity.UpdationDateTime = dto.UpdationDateTime;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblSalaryMST"/> to an instance of <see cref="tblSalaryMSTDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblSalaryMST"/> to convert.</param>
        public static tblSalaryMSTDTO ToDTO(this tblSalaryMST entity)
        {
            if (entity == null) return null;

            var dto = new tblSalaryMSTDTO();

            dto.SalaryID = entity.SalaryID;
            dto.EmployeeID = entity.EmployeeID;
            dto.Date = entity.Date;
            dto.StartDate = entity.StartDate;
            dto.EndDate = entity.EndDate;
            dto.WorkedHours = entity.WorkedHours;
            dto.TotalPenalty = entity.TotalPenalty;
            dto.Bonus = entity.Bonus;
            dto.WithdrownAmount = entity.WithdrownAmount;
            dto.WithdrownID = entity.WithdrownID;
            dto.NetSalary = entity.NetSalary;
            dto.IsDelete = entity.IsDelete;
            dto.IsActive = entity.IsActive;
            dto.CreateBy = entity.CreateBy;
            dto.CreationDateTime = entity.CreationDateTime;
            dto.UpdateBy = entity.UpdateBy;
            dto.UpdationDateTime = entity.UpdationDateTime;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblSalaryMSTDTO"/> to an instance of <see cref="tblSalaryMST"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblSalaryMST> ToEntities(this IEnumerable<tblSalaryMSTDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblSalaryMST"/> to an instance of <see cref="tblSalaryMSTDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblSalaryMSTDTO> ToDTOs(this IEnumerable<tblSalaryMST> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
