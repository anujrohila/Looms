//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-08 - 11:39:11
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
    /// Assembler for <see cref="tblProductQualityMST"/> and <see cref="tblProductQualityMSTDTO"/>.
    /// </summary>
    public static partial class tblProductQualityMSTAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblProductQualityMSTDTO"/> converted from <see cref="tblProductQualityMST"/>.</param>
        static partial void OnDTO(this tblProductQualityMST entity, tblProductQualityMSTDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblProductQualityMST"/> converted from <see cref="tblProductQualityMSTDTO"/>.</param>
        static partial void OnEntity(this tblProductQualityMSTDTO dto, tblProductQualityMST entity);

        /// <summary>
        /// Converts this instance of <see cref="tblProductQualityMSTDTO"/> to an instance of <see cref="tblProductQualityMST"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblProductQualityMSTDTO"/> to convert.</param>
        public static tblProductQualityMST ToEntity(this tblProductQualityMSTDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblProductQualityMST();

            entity.ProductQualityID = dto.ProductQualityID;
            entity.ProductQualityName = dto.ProductQualityName;
            entity.WARPDenierAfterTPM = dto.WARPDenierAfterTPM;
            entity.WARPNumberOfFilaments = dto.WARPNumberOfFilaments;
            entity.WARPYarnQualityID = dto.WARPYarnQualityID;
            entity.WARPYarnTypeID = dto.WARPYarnTypeID;
            entity.WARPDirectionOfTwistS = dto.WARPDirectionOfTwistS;
            entity.WARPDirectionOfTwistZ = dto.WARPDirectionOfTwistZ;
            entity.WARPTwistPerMeterS = dto.WARPTwistPerMeterS;
            entity.WARPTwistPerMeterZ = dto.WARPTwistPerMeterZ;
            entity.WEFTDenierAfterTPM = dto.WEFTDenierAfterTPM;
            entity.WEFTNumberOfFilaments1 = dto.WEFTNumberOfFilaments1;
            entity.WEFTYarnQualityID = dto.WEFTYarnQualityID;
            entity.WEFTYarnTypeID = dto.WEFTYarnTypeID;
            entity.WEFTDirectionOfTwistS = dto.WEFTDirectionOfTwistS;
            entity.WEFTDirectionOfTwistZ = dto.WEFTDirectionOfTwistZ;
            entity.WEFTTwistPerMeterS = dto.WEFTTwistPerMeterS;
            entity.WEFTTwistPerMeterZ = dto.WEFTTwistPerMeterZ;
            entity.ApproxTotalEndsWithBorder = dto.ApproxTotalEndsWithBorder;
            entity.ReedOnLoom = dto.ReedOnLoom;
            entity.PickOnLoom = dto.PickOnLoom;
            entity.Border = dto.Border;
            entity.HeatSetting = dto.HeatSetting;
            entity.WeightOfFabricWARP = dto.WeightOfFabricWARP;
            entity.WeightOfFabricWEFT = dto.WeightOfFabricWEFT;
            entity.TotalWeight = dto.TotalWeight;
            entity.IsActive = dto.IsActive;
            entity.CreatedBy = dto.CreatedBy;
            entity.CreatedDateTime = dto.CreatedDateTime;
            entity.UpdatedBy = dto.UpdatedBy;
            entity.UpdatedDateTime = dto.UpdatedDateTime;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblProductQualityMST"/> to an instance of <see cref="tblProductQualityMSTDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblProductQualityMST"/> to convert.</param>
        public static tblProductQualityMSTDTO ToDTO(this tblProductQualityMST entity)
        {
            if (entity == null) return null;

            var dto = new tblProductQualityMSTDTO();

            dto.ProductQualityID = entity.ProductQualityID;
            dto.ProductQualityName = entity.ProductQualityName;
            dto.WARPDenierAfterTPM = entity.WARPDenierAfterTPM;
            dto.WARPNumberOfFilaments = entity.WARPNumberOfFilaments;
            dto.WARPYarnQualityID = entity.WARPYarnQualityID;
            dto.WARPYarnTypeID = entity.WARPYarnTypeID;
            dto.WARPDirectionOfTwistS = entity.WARPDirectionOfTwistS;
            dto.WARPDirectionOfTwistZ = entity.WARPDirectionOfTwistZ;
            dto.WARPTwistPerMeterS = entity.WARPTwistPerMeterS;
            dto.WARPTwistPerMeterZ = entity.WARPTwistPerMeterZ;
            dto.WEFTDenierAfterTPM = entity.WEFTDenierAfterTPM;
            dto.WEFTNumberOfFilaments1 = entity.WEFTNumberOfFilaments1;
            dto.WEFTYarnQualityID = entity.WEFTYarnQualityID;
            dto.WEFTYarnTypeID = entity.WEFTYarnTypeID;
            dto.WEFTDirectionOfTwistS = entity.WEFTDirectionOfTwistS;
            dto.WEFTDirectionOfTwistZ = entity.WEFTDirectionOfTwistZ;
            dto.WEFTTwistPerMeterS = entity.WEFTTwistPerMeterS;
            dto.WEFTTwistPerMeterZ = entity.WEFTTwistPerMeterZ;
            dto.ApproxTotalEndsWithBorder = entity.ApproxTotalEndsWithBorder;
            dto.ReedOnLoom = entity.ReedOnLoom;
            dto.PickOnLoom = entity.PickOnLoom;
            dto.Border = entity.Border;
            dto.HeatSetting = entity.HeatSetting;
            dto.WeightOfFabricWARP = entity.WeightOfFabricWARP;
            dto.WeightOfFabricWEFT = entity.WeightOfFabricWEFT;
            dto.TotalWeight = entity.TotalWeight;
            dto.IsActive = entity.IsActive;
            dto.CreatedBy = entity.CreatedBy;
            dto.CreatedDateTime = entity.CreatedDateTime;
            dto.UpdatedBy = entity.UpdatedBy;
            dto.UpdatedDateTime = entity.UpdatedDateTime;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblProductQualityMSTDTO"/> to an instance of <see cref="tblProductQualityMST"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblProductQualityMST> ToEntities(this IEnumerable<tblProductQualityMSTDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblProductQualityMST"/> to an instance of <see cref="tblProductQualityMSTDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblProductQualityMSTDTO> ToDTOs(this IEnumerable<tblProductQualityMST> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
