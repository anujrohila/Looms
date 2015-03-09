//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-08 - 11:39:08
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
    /// Assembler for <see cref="tblCompanyMachineMST"/> and <see cref="tblCompanyMachineMSTDTO"/>.
    /// </summary>
    public static partial class tblCompanyMachineMSTAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblCompanyMachineMSTDTO"/> converted from <see cref="tblCompanyMachineMST"/>.</param>
        static partial void OnDTO(this tblCompanyMachineMST entity, tblCompanyMachineMSTDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblCompanyMachineMST"/> converted from <see cref="tblCompanyMachineMSTDTO"/>.</param>
        static partial void OnEntity(this tblCompanyMachineMSTDTO dto, tblCompanyMachineMST entity);

        /// <summary>
        /// Converts this instance of <see cref="tblCompanyMachineMSTDTO"/> to an instance of <see cref="tblCompanyMachineMST"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblCompanyMachineMSTDTO"/> to convert.</param>
        public static tblCompanyMachineMST ToEntity(this tblCompanyMachineMSTDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblCompanyMachineMST();

            entity.RowId = dto.RowId;
            entity.MachineId = dto.MachineId;
            entity.CompanyId = dto.CompanyId;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblCompanyMachineMST"/> to an instance of <see cref="tblCompanyMachineMSTDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblCompanyMachineMST"/> to convert.</param>
        public static tblCompanyMachineMSTDTO ToDTO(this tblCompanyMachineMST entity)
        {
            if (entity == null) return null;

            var dto = new tblCompanyMachineMSTDTO();

            dto.RowId = entity.RowId;
            dto.MachineId = entity.MachineId;
            dto.CompanyId = entity.CompanyId;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblCompanyMachineMSTDTO"/> to an instance of <see cref="tblCompanyMachineMST"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblCompanyMachineMST> ToEntities(this IEnumerable<tblCompanyMachineMSTDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblCompanyMachineMST"/> to an instance of <see cref="tblCompanyMachineMSTDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblCompanyMachineMSTDTO> ToDTOs(this IEnumerable<tblCompanyMachineMST> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
