using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
    public class BeamMasterRepository
    {
        /// <summary>
        /// Save Beam Master
        /// </summary>
        /// <param name="tblBeamMSTDTO"></param>
        /// <returns></returns>
        public int SaveBeamMaster(tblBeamMSTDTO tblBeamMSTDTO)
        {
            using (var loomsManagementEntities = new LoomsManagementEntities())
            {
                if (tblBeamMSTDTO.BeemID == 0)
                {
                    var objBeamMaster = tblBeamMSTDTO.ToEntity();
                    loomsManagementEntities.tblBeamMSTs.Add(objBeamMaster);
                }
                else
                {
                    var objBeamMaster = loomsManagementEntities.tblBeamMSTs.Where(m => m.BeemID == tblBeamMSTDTO.BeemID).FirstOrDefault();
                    objBeamMaster.BeemID = tblBeamMSTDTO.BeemID;
                    objBeamMaster.CompanyID = tblBeamMSTDTO.CompanyID;
                    objBeamMaster.BeamNo = tblBeamMSTDTO.BeamNo;
                    objBeamMaster.WrapperPartyID = tblBeamMSTDTO.WrapperPartyID;
                    objBeamMaster.JobberPartyName = tblBeamMSTDTO.JobberPartyName;
                    objBeamMaster.BeemDate = tblBeamMSTDTO.BeemDate;
                    objBeamMaster.YarnQualityID = tblBeamMSTDTO.YarnQualityID;
                    objBeamMaster.GrayQualityId = tblBeamMSTDTO.GrayQualityId;
                    objBeamMaster.LotNo = tblBeamMSTDTO.LotNo;
                    objBeamMaster.NoofTar = tblBeamMSTDTO.NoofTar;
                    objBeamMaster.Meters = tblBeamMSTDTO.Meters;
                    objBeamMaster.Taka = tblBeamMSTDTO.Taka;
                    objBeamMaster.GrossWeight = tblBeamMSTDTO.GrossWeight;
                    objBeamMaster.NetWeight = tblBeamMSTDTO.NetWeight;
                    objBeamMaster.LoadingDate = tblBeamMSTDTO.LoadingDate;
                    objBeamMaster.BhidanStatus = tblBeamMSTDTO.BhidanStatus;
                    objBeamMaster.BhidanDate = tblBeamMSTDTO.BhidanDate;
                    objBeamMaster.PasaraiEmployeeId = tblBeamMSTDTO.PasaraiEmployeeId;
                    objBeamMaster.ProductionMeters = tblBeamMSTDTO.ProductionMeters;
                    objBeamMaster.ProductionTaka = tblBeamMSTDTO.ProductionTaka;
                    objBeamMaster.PipeWeight = tblBeamMSTDTO.PipeWeight;
                    objBeamMaster.MinStrategy = tblBeamMSTDTO.MinStrategy;
                    objBeamMaster.MachineId = tblBeamMSTDTO.MachineId;
                    objBeamMaster.Remarks = tblBeamMSTDTO.Remarks;
                    objBeamMaster.IssueDate = tblBeamMSTDTO.IssueDate;
                    objBeamMaster.TakaMeter = tblBeamMSTDTO.TakaMeter;
                    objBeamMaster.Rate = tblBeamMSTDTO.Rate;
                    objBeamMaster.Amount = tblBeamMSTDTO.Amount;
                    objBeamMaster.MeterConsumption = tblBeamMSTDTO.MeterConsumption;
                    objBeamMaster.RPM = tblBeamMSTDTO.RPM;
                    objBeamMaster.Pick = tblBeamMSTDTO.Pick;
                    objBeamMaster.My = tblBeamMSTDTO.My;
                    objBeamMaster.FinalAmount = tblBeamMSTDTO.FinalAmount;
                    objBeamMaster.IsDelete = tblBeamMSTDTO.IsDelete;
                    objBeamMaster.IsActive = tblBeamMSTDTO.IsActive;
                    objBeamMaster.CreatedBy = tblBeamMSTDTO.CreatedBy;
                    objBeamMaster.CreationDateTime = tblBeamMSTDTO.CreationDateTime;
                    objBeamMaster.UpdateBy = tblBeamMSTDTO.UpdateBy;
                    objBeamMaster.UpdationDateTime = tblBeamMSTDTO.UpdationDateTime;
                }
                if (loomsManagementEntities.SaveChanges() > 0)
                    return 0;
                else
                    return 2;
            }
        }

        /// <summary>
        /// Get All Beam Master Details
        /// </summary>
        /// <returns></returns>
        public List<tblBeamMSTDTO> GetAllBeamMasterDetails()
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblBeamMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        /// <summary>
        /// Get Beam Master Details
        /// </summary>
        /// <param name="beamID"></param>
        /// <returns></returns>
        public tblBeamMSTDTO GetBeamMasterDetails(int beamID)
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblBeamMSTs.Where(m => m.BeemID == beamID).FirstOrDefault().ToDTO();
            }
        }

        /// <summary>
        /// Delete Company Data
        /// </summary>
        /// <param name="beamID"></param>
        /// <returns></returns>
        public int DeleteCompanyData(int beamID)
        {
            using (var loomsManagementEntities = new LoomsManagementEntities())
            {
                var objBeamMaster = loomsManagementEntities.tblBeamMSTs.Where(m => m.BeemID == beamID).FirstOrDefault();
                if (objBeamMaster != null)
                {
                    objBeamMaster.IsDelete = true;
                    if (loomsManagementEntities.SaveChanges() > 0)
                        return 0;
                    else
                        return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
