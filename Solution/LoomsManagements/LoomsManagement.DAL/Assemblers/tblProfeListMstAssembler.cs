//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-15 - 10:24:06
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
    /// Assembler for <see cref="tblProfeListMst"/> and <see cref="tblProfeListMstDTO"/>.
    /// </summary>
    public static partial class tblProfeListMstAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblProfeListMstDTO"/> converted from <see cref="tblProfeListMst"/>.</param>
        static partial void OnDTO(this tblProfeListMst entity, tblProfeListMstDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblProfeListMst"/> converted from <see cref="tblProfeListMstDTO"/>.</param>
        static partial void OnEntity(this tblProfeListMstDTO dto, tblProfeListMst entity);

        /// <summary>
        /// Converts this instance of <see cref="tblProfeListMstDTO"/> to an instance of <see cref="tblProfeListMst"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblProfeListMstDTO"/> to convert.</param>
        public static tblProfeListMst ToEntity(this tblProfeListMstDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblProfeListMst();

            entity.ProfeID = dto.ProfeID;
            entity.Name = dto.Name;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblProfeListMst"/> to an instance of <see cref="tblProfeListMstDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblProfeListMst"/> to convert.</param>
        public static tblProfeListMstDTO ToDTO(this tblProfeListMst entity)
        {
            if (entity == null) return null;

            var dto = new tblProfeListMstDTO();

            dto.ProfeID = entity.ProfeID;
            dto.Name = entity.Name;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblProfeListMstDTO"/> to an instance of <see cref="tblProfeListMst"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblProfeListMst> ToEntities(this IEnumerable<tblProfeListMstDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblProfeListMst"/> to an instance of <see cref="tblProfeListMstDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblProfeListMstDTO> ToDTOs(this IEnumerable<tblProfeListMst> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
