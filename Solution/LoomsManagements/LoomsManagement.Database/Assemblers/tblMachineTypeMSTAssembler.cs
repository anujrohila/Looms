//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-08 - 11:39:09
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
    /// Assembler for <see cref="tblMachineTypeMST"/> and <see cref="tblMachineTypeMSTDTO"/>.
    /// </summary>
    public static partial class tblMachineTypeMSTAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblMachineTypeMSTDTO"/> converted from <see cref="tblMachineTypeMST"/>.</param>
        static partial void OnDTO(this tblMachineTypeMST entity, tblMachineTypeMSTDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblMachineTypeMST"/> converted from <see cref="tblMachineTypeMSTDTO"/>.</param>
        static partial void OnEntity(this tblMachineTypeMSTDTO dto, tblMachineTypeMST entity);

        /// <summary>
        /// Converts this instance of <see cref="tblMachineTypeMSTDTO"/> to an instance of <see cref="tblMachineTypeMST"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblMachineTypeMSTDTO"/> to convert.</param>
        public static tblMachineTypeMST ToEntity(this tblMachineTypeMSTDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblMachineTypeMST();

            entity.MachineTypeID = dto.MachineTypeID;
            entity.TypeName = dto.TypeName;
            entity.Description = dto.Description;
            entity.IsActive = dto.IsActive;
            entity.CreatedBy = dto.CreatedBy;
            entity.CreatedDateTime = dto.CreatedDateTime;
            entity.UpdatedBy = dto.UpdatedBy;
            entity.UpdatedDateTime = dto.UpdatedDateTime;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblMachineTypeMST"/> to an instance of <see cref="tblMachineTypeMSTDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblMachineTypeMST"/> to convert.</param>
        public static tblMachineTypeMSTDTO ToDTO(this tblMachineTypeMST entity)
        {
            if (entity == null) return null;

            var dto = new tblMachineTypeMSTDTO();

            dto.MachineTypeID = entity.MachineTypeID;
            dto.TypeName = entity.TypeName;
            dto.Description = entity.Description;
            dto.IsActive = entity.IsActive;
            dto.CreatedBy = entity.CreatedBy;
            dto.CreatedDateTime = entity.CreatedDateTime;
            dto.UpdatedBy = entity.UpdatedBy;
            dto.UpdatedDateTime = entity.UpdatedDateTime;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMachineTypeMSTDTO"/> to an instance of <see cref="tblMachineTypeMST"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblMachineTypeMST> ToEntities(this IEnumerable<tblMachineTypeMSTDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMachineTypeMST"/> to an instance of <see cref="tblMachineTypeMSTDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblMachineTypeMSTDTO> ToDTOs(this IEnumerable<tblMachineTypeMST> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}