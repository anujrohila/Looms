//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-09 - 14:23:58
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
    /// Assembler for <see cref="tblBranchMST"/> and <see cref="tblBranchMSTDTO"/>.
    /// </summary>
    public static partial class tblBranchMSTAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblBranchMSTDTO"/> converted from <see cref="tblBranchMST"/>.</param>
        static partial void OnDTO(this tblBranchMST entity, tblBranchMSTDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblBranchMST"/> converted from <see cref="tblBranchMSTDTO"/>.</param>
        static partial void OnEntity(this tblBranchMSTDTO dto, tblBranchMST entity);

        /// <summary>
        /// Converts this instance of <see cref="tblBranchMSTDTO"/> to an instance of <see cref="tblBranchMST"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblBranchMSTDTO"/> to convert.</param>
        public static tblBranchMST ToEntity(this tblBranchMSTDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblBranchMST();

            entity.BranchID = dto.BranchID;
            entity.BranchName = dto.BranchName;
            entity.Address = dto.Address;
            entity.BankID = dto.BankID;
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
        /// Converts this instance of <see cref="tblBranchMST"/> to an instance of <see cref="tblBranchMSTDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblBranchMST"/> to convert.</param>
        public static tblBranchMSTDTO ToDTO(this tblBranchMST entity)
        {
            if (entity == null) return null;

            var dto = new tblBranchMSTDTO();

            dto.BranchID = entity.BranchID;
            dto.BranchName = entity.BranchName;
            dto.Address = entity.Address;
            dto.BankID = entity.BankID;
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
        /// Converts each instance of <see cref="tblBranchMSTDTO"/> to an instance of <see cref="tblBranchMST"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblBranchMST> ToEntities(this IEnumerable<tblBranchMSTDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblBranchMST"/> to an instance of <see cref="tblBranchMSTDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblBranchMSTDTO> ToDTOs(this IEnumerable<tblBranchMST> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
