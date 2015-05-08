//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-09 - 14:24:05
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
    /// Assembler for <see cref="tblYarnQualityMST"/> and <see cref="tblYarnQualityMSTDTO"/>.
    /// </summary>
    public static partial class tblYarnQualityMSTAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblYarnQualityMSTDTO"/> converted from <see cref="tblYarnQualityMST"/>.</param>
        static partial void OnDTO(this tblYarnQualityMST entity, tblYarnQualityMSTDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblYarnQualityMST"/> converted from <see cref="tblYarnQualityMSTDTO"/>.</param>
        static partial void OnEntity(this tblYarnQualityMSTDTO dto, tblYarnQualityMST entity);

        /// <summary>
        /// Converts this instance of <see cref="tblYarnQualityMSTDTO"/> to an instance of <see cref="tblYarnQualityMST"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblYarnQualityMSTDTO"/> to convert.</param>
        public static tblYarnQualityMST ToEntity(this tblYarnQualityMSTDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblYarnQualityMST();

            entity.YarnQualityID = dto.YarnQualityID;
            entity.YarnQualityName = dto.YarnQualityName;
            entity.Description = dto.Description;
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
        /// Converts this instance of <see cref="tblYarnQualityMST"/> to an instance of <see cref="tblYarnQualityMSTDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblYarnQualityMST"/> to convert.</param>
        public static tblYarnQualityMSTDTO ToDTO(this tblYarnQualityMST entity)
        {
            if (entity == null) return null;

            var dto = new tblYarnQualityMSTDTO();

            dto.YarnQualityID = entity.YarnQualityID;
            dto.YarnQualityName = entity.YarnQualityName;
            dto.Description = entity.Description;
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
        /// Converts each instance of <see cref="tblYarnQualityMSTDTO"/> to an instance of <see cref="tblYarnQualityMST"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblYarnQualityMST> ToEntities(this IEnumerable<tblYarnQualityMSTDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblYarnQualityMST"/> to an instance of <see cref="tblYarnQualityMSTDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblYarnQualityMSTDTO> ToDTOs(this IEnumerable<tblYarnQualityMST> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}