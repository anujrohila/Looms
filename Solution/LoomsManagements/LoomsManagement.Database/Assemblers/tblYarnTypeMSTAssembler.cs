//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-08 - 11:39:14
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
    /// Assembler for <see cref="tblYarnTypeMST"/> and <see cref="tblYarnTypeMSTDTO"/>.
    /// </summary>
    public static partial class tblYarnTypeMSTAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblYarnTypeMSTDTO"/> converted from <see cref="tblYarnTypeMST"/>.</param>
        static partial void OnDTO(this tblYarnTypeMST entity, tblYarnTypeMSTDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblYarnTypeMST"/> converted from <see cref="tblYarnTypeMSTDTO"/>.</param>
        static partial void OnEntity(this tblYarnTypeMSTDTO dto, tblYarnTypeMST entity);

        /// <summary>
        /// Converts this instance of <see cref="tblYarnTypeMSTDTO"/> to an instance of <see cref="tblYarnTypeMST"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblYarnTypeMSTDTO"/> to convert.</param>
        public static tblYarnTypeMST ToEntity(this tblYarnTypeMSTDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblYarnTypeMST();

            entity.YarnTypeID = dto.YarnTypeID;
            entity.YarnTypeName = dto.YarnTypeName;
            entity.YarnQualityID = dto.YarnQualityID;
            entity.Denier = dto.Denier;
            entity.NumberOfFilaments = dto.NumberOfFilaments;
            entity.Description = dto.Description;
            entity.IsActive = dto.IsActive;
            entity.UpdateBy = dto.UpdateBy;
            entity.CreateBy = dto.CreateBy;
            entity.UpdationDateTime = dto.UpdationDateTime;
            entity.CreationDateTIme = dto.CreationDateTIme;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblYarnTypeMST"/> to an instance of <see cref="tblYarnTypeMSTDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblYarnTypeMST"/> to convert.</param>
        public static tblYarnTypeMSTDTO ToDTO(this tblYarnTypeMST entity)
        {
            if (entity == null) return null;

            var dto = new tblYarnTypeMSTDTO();

            dto.YarnTypeID = entity.YarnTypeID;
            dto.YarnTypeName = entity.YarnTypeName;
            dto.YarnQualityID = entity.YarnQualityID;
            dto.Denier = entity.Denier;
            dto.NumberOfFilaments = entity.NumberOfFilaments;
            dto.Description = entity.Description;
            dto.IsActive = entity.IsActive;
            dto.UpdateBy = entity.UpdateBy;
            dto.CreateBy = entity.CreateBy;
            dto.UpdationDateTime = entity.UpdationDateTime;
            dto.CreationDateTIme = entity.CreationDateTIme;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblYarnTypeMSTDTO"/> to an instance of <see cref="tblYarnTypeMST"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblYarnTypeMST> ToEntities(this IEnumerable<tblYarnTypeMSTDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblYarnTypeMST"/> to an instance of <see cref="tblYarnTypeMSTDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblYarnTypeMSTDTO> ToDTOs(this IEnumerable<tblYarnTypeMST> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
