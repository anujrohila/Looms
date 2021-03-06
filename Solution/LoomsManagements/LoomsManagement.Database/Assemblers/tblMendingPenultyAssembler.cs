//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-08 - 11:39:10
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
using LoomsManagement.Database.ORM;

namespace LoomsManagement.DAL.Assemblers
{

    /// <summary>
    /// Assembler for <see cref="tblMendingPenulty"/> and <see cref="tblMendingPenultyDTO"/>.
    /// </summary>
    public static partial class tblMendingPenultyAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblMendingPenultyDTO"/> converted from <see cref="tblMendingPenulty"/>.</param>
        static partial void OnDTO(this tblMendingPenulty entity, tblMendingPenultyDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblMendingPenulty"/> converted from <see cref="tblMendingPenultyDTO"/>.</param>
        static partial void OnEntity(this tblMendingPenultyDTO dto, tblMendingPenulty entity);

        /// <summary>
        /// Converts this instance of <see cref="tblMendingPenultyDTO"/> to an instance of <see cref="tblMendingPenulty"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblMendingPenultyDTO"/> to convert.</param>
        public static tblMendingPenulty ToEntity(this tblMendingPenultyDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblMendingPenulty();

            entity.MendingPenultyID = dto.MendingPenultyID;
            entity.EmployeeID = dto.EmployeeID;
            entity.PenultyID = dto.PenultyID;
            entity.IsActive = dto.IsActive;
            entity.CreateBy = dto.CreateBy;
            entity.CreationDateTime = dto.CreationDateTime;
            entity.UpdateBy = dto.UpdateBy;
            entity.UpdationDateTime = dto.UpdationDateTime;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblMendingPenulty"/> to an instance of <see cref="tblMendingPenultyDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblMendingPenulty"/> to convert.</param>
        public static tblMendingPenultyDTO ToDTO(this tblMendingPenulty entity)
        {
            if (entity == null) return null;

            var dto = new tblMendingPenultyDTO();

            dto.MendingPenultyID = entity.MendingPenultyID;
            dto.EmployeeID = entity.EmployeeID;
            dto.PenultyID = entity.PenultyID;
            dto.IsActive = entity.IsActive;
            dto.CreateBy = entity.CreateBy;
            dto.CreationDateTime = entity.CreationDateTime;
            dto.UpdateBy = entity.UpdateBy;
            dto.UpdationDateTime = entity.UpdationDateTime;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMendingPenultyDTO"/> to an instance of <see cref="tblMendingPenulty"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblMendingPenulty> ToEntities(this IEnumerable<tblMendingPenultyDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMendingPenulty"/> to an instance of <see cref="tblMendingPenultyDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblMendingPenultyDTO> ToDTOs(this IEnumerable<tblMendingPenulty> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
