//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-09 - 14:24:02
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
    /// Assembler for <see cref="tblPartysMST"/> and <see cref="tblPartysMSTDTO"/>.
    /// </summary>
    public static partial class tblPartysMSTAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblPartysMSTDTO"/> converted from <see cref="tblPartysMST"/>.</param>
        static partial void OnDTO(this tblPartysMST entity, tblPartysMSTDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblPartysMST"/> converted from <see cref="tblPartysMSTDTO"/>.</param>
        static partial void OnEntity(this tblPartysMSTDTO dto, tblPartysMST entity);

        /// <summary>
        /// Converts this instance of <see cref="tblPartysMSTDTO"/> to an instance of <see cref="tblPartysMST"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblPartysMSTDTO"/> to convert.</param>
        public static tblPartysMST ToEntity(this tblPartysMSTDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblPartysMST();

            entity.PartyID = dto.PartyID;
            entity.CompanyCode = dto.CompanyCode;
            entity.PartyName = dto.PartyName;
            entity.ContactPersonName = dto.ContactPersonName;
            entity.OfficeAddress = dto.OfficeAddress;
            entity.ShippingAddress = dto.ShippingAddress;
            entity.City = dto.City;
            entity.State = dto.State;
            entity.MobileNo = dto.MobileNo;
            entity.PhoneNo = dto.PhoneNo;
            entity.SMSNo = dto.SMSNo;
            entity.ReferencePersonName = dto.ReferencePersonName;
            entity.ReferencePersonMobileNo = dto.ReferencePersonMobileNo;
            entity.EmailID = dto.EmailID;
            entity.ExtraDetails = dto.ExtraDetails;
            entity.TINNo = dto.TINNo;
            entity.TINDate = dto.TINDate;
            entity.PANNO = dto.PANNO;
            entity.CSTTINNo = dto.CSTTINNo;
            entity.CSTDate = dto.CSTDate;
            entity.ECCNo = dto.ECCNo;
            entity.IsDelete = dto.IsDelete;
            entity.IsActive = dto.IsActive;
            entity.CreateBye = dto.CreateBye;
            entity.CreationDateTime = dto.CreationDateTime;
            entity.UpdateBy = dto.UpdateBy;
            entity.UpdationDateTIme = dto.UpdationDateTIme;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblPartysMST"/> to an instance of <see cref="tblPartysMSTDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblPartysMST"/> to convert.</param>
        public static tblPartysMSTDTO ToDTO(this tblPartysMST entity)
        {
            if (entity == null) return null;

            var dto = new tblPartysMSTDTO();

            dto.PartyID = entity.PartyID;
            dto.CompanyCode = entity.CompanyCode;
            dto.PartyName = entity.PartyName;
            dto.ContactPersonName = entity.ContactPersonName;
            dto.OfficeAddress = entity.OfficeAddress;
            dto.ShippingAddress = entity.ShippingAddress;
            dto.City = entity.City;
            dto.State = entity.State;
            dto.MobileNo = entity.MobileNo;
            dto.PhoneNo = entity.PhoneNo;
            dto.SMSNo = entity.SMSNo;
            dto.ReferencePersonName = entity.ReferencePersonName;
            dto.ReferencePersonMobileNo = entity.ReferencePersonMobileNo;
            dto.EmailID = entity.EmailID;
            dto.ExtraDetails = entity.ExtraDetails;
            dto.TINNo = entity.TINNo;
            dto.TINDate = entity.TINDate;
            dto.PANNO = entity.PANNO;
            dto.CSTTINNo = entity.CSTTINNo;
            dto.CSTDate = entity.CSTDate;
            dto.ECCNo = entity.ECCNo;
            dto.IsDelete = entity.IsDelete;
            dto.IsActive = entity.IsActive;
            dto.CreateBye = entity.CreateBye;
            dto.CreationDateTime = entity.CreationDateTime;
            dto.UpdateBy = entity.UpdateBy;
            dto.UpdationDateTIme = entity.UpdationDateTIme;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblPartysMSTDTO"/> to an instance of <see cref="tblPartysMST"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblPartysMST> ToEntities(this IEnumerable<tblPartysMSTDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblPartysMST"/> to an instance of <see cref="tblPartysMSTDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblPartysMSTDTO> ToDTOs(this IEnumerable<tblPartysMST> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
