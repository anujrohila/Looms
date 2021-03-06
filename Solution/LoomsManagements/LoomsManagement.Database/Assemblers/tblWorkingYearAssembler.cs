//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-08 - 11:39:12
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
    /// Assembler for <see cref="tblWorkingYear"/> and <see cref="tblWorkingYearDTO"/>.
    /// </summary>
    public static partial class tblWorkingYearAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblWorkingYearDTO"/> converted from <see cref="tblWorkingYear"/>.</param>
        static partial void OnDTO(this tblWorkingYear entity, tblWorkingYearDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblWorkingYear"/> converted from <see cref="tblWorkingYearDTO"/>.</param>
        static partial void OnEntity(this tblWorkingYearDTO dto, tblWorkingYear entity);

        /// <summary>
        /// Converts this instance of <see cref="tblWorkingYearDTO"/> to an instance of <see cref="tblWorkingYear"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblWorkingYearDTO"/> to convert.</param>
        public static tblWorkingYear ToEntity(this tblWorkingYearDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblWorkingYear();

            entity.YearID = dto.YearID;
            entity.YearName = dto.YearName;
            entity.IsActive = dto.IsActive;
            entity.CreatedBy = dto.CreatedBy;
            entity.CreatedDateTime = dto.CreatedDateTime;
            entity.UpdatedBy = dto.UpdatedBy;
            entity.UpdatedDateTime = dto.UpdatedDateTime;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblWorkingYear"/> to an instance of <see cref="tblWorkingYearDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblWorkingYear"/> to convert.</param>
        public static tblWorkingYearDTO ToDTO(this tblWorkingYear entity)
        {
            if (entity == null) return null;

            var dto = new tblWorkingYearDTO();

            dto.YearID = entity.YearID;
            dto.YearName = entity.YearName;
            dto.IsActive = entity.IsActive;
            dto.CreatedBy = entity.CreatedBy;
            dto.CreatedDateTime = entity.CreatedDateTime;
            dto.UpdatedBy = entity.UpdatedBy;
            dto.UpdatedDateTime = entity.UpdatedDateTime;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblWorkingYearDTO"/> to an instance of <see cref="tblWorkingYear"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblWorkingYear> ToEntities(this IEnumerable<tblWorkingYearDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblWorkingYear"/> to an instance of <see cref="tblWorkingYearDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblWorkingYearDTO> ToDTOs(this IEnumerable<tblWorkingYear> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
