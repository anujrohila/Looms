using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
    public class BeamMasterRepository
    {
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
                    objBeamMaster.WrapperPartyName = tblBeamMSTDTO.WrapperPartyName;
                    objBeamMaster.JobberPartyName = tblBeamMSTDTO.JobberPartyName;
                    objBeamMaster.BeemDate = tblBeamMSTDTO.BeemDate;
                    objBeamMaster.YarnQuality = tblBeamMSTDTO.YarnQuality;
                    objBeamMaster.GrayQuality = tblBeamMSTDTO.GrayQuality;
                    objBeamMaster.TarNo = tblBeamMSTDTO.TarNo;
                    objBeamMaster.Meters = tblBeamMSTDTO.Meters;
                    objBeamMaster.Taka = tblBeamMSTDTO.Taka;
                    objBeamMaster.Weight = tblBeamMSTDTO.Weight;
                    objBeamMaster.ProductionMeters = tblBeamMSTDTO.ProductionMeters;
                    objBeamMaster.ProductionTaka = tblBeamMSTDTO.ProductionTaka;
                    objBeamMaster.PipeWeight = tblBeamMSTDTO.PipeWeight;
                    objBeamMaster.LoadingDate = tblBeamMSTDTO.LoadingDate;
                    objBeamMaster.MinStrategy = tblBeamMSTDTO.MinStrategy;
                    objBeamMaster.MachineNo = tblBeamMSTDTO.MachineNo;
                    objBeamMaster.Remarks = tblBeamMSTDTO.Remarks;
                    objBeamMaster.BhidanStatus = tblBeamMSTDTO.BhidanStatus;
                    objBeamMaster.BhidanDate = tblBeamMSTDTO.BhidanDate;
                    objBeamMaster.PasaraiName = tblBeamMSTDTO.PasaraiName;
                    objBeamMaster.Count = tblBeamMSTDTO.Count;
                    objBeamMaster.IssueDate = tblBeamMSTDTO.IssueDate;
                    objBeamMaster.TakaMeter = tblBeamMSTDTO.TakaMeter;
                    objBeamMaster.Rate = tblBeamMSTDTO.Rate;
                    objBeamMaster.Amount = tblBeamMSTDTO.Amount;
                    objBeamMaster.MeterConsumption = tblBeamMSTDTO.MeterConsumption;
                    objBeamMaster.RPM = tblBeamMSTDTO.RPM;
                    objBeamMaster.Pick = tblBeamMSTDTO.Pick;
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

        public static List<tblBeamMSTDTO> GetAllBeamMasterDetails()
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblBeamMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public static tblBeamMSTDTO GetBeamMasterDetails(int beamID)
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblBeamMSTs.Where(m => m.BeemID == beamID).FirstOrDefault().ToDTO();
            }
        }

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
