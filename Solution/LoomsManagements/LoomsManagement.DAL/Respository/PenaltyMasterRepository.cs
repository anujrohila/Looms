using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;


namespace LoomsManagement.DAL
{
    public class PenaltyMasterRepository
    {

        public int SavePenaltyMasterData(tblPenaltyMSTDTO tblPenaltyMSTDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblPenaltyMSTDTO.PenaltyID == 0)
                {
                    if (loomsManagementEntity.tblPenaltyMSTs.Where(m => m.PenaltyName == tblPenaltyMSTDTO.PenaltyName && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 0;
                    }
                    else
                    {
                        tblPenaltyMST objPenaltyMst = tblPenaltyMSTDTO.ToEntity();
                        loomsManagementEntity.tblPenaltyMSTs.Add(objPenaltyMst);
                    }
                }
                else
                {
                    if (loomsManagementEntity.tblPenaltyMSTs.Where(m => m.PenaltyName == tblPenaltyMSTDTO.PenaltyName && m.PenaltyID != tblPenaltyMSTDTO.PenaltyID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblPenaltyMST objPenaltyMst = loomsManagementEntity.tblPenaltyMSTs.Where(m => m.PenaltyID == tblPenaltyMSTDTO.PenaltyID && m.IsDelete == false).FirstOrDefault();
                        if (objPenaltyMst != null)
                        {
                            objPenaltyMst.PenaltyID = tblPenaltyMSTDTO.PenaltyID;
                            objPenaltyMst.PenaltyCode = tblPenaltyMSTDTO.PenaltyCode;
                            objPenaltyMst.PenaltyName = tblPenaltyMSTDTO.PenaltyName;
                            objPenaltyMst.Description = tblPenaltyMSTDTO.Description;
                            objPenaltyMst.UpdateBy = tblPenaltyMSTDTO.UpdateBy;
                            objPenaltyMst.UpdationDateTime = tblPenaltyMSTDTO.UpdationDateTime;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
                if (loomsManagementEntity.SaveChanges() > 0)
                    return 0;
                else
                    return 2;
            }
        }

        public static List<tblPenaltyMSTDTO> GetAllPenaltyMasterData()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblPenaltyMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public static tblPenaltyMSTDTO GetPenaltyMasterData(int PenaltyId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblPenaltyMSTs.Where(m => m.PenaltyID == PenaltyId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeletePenaltyMasterData(int PenaltyId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                tblPenaltyMST objPenaltyMst = loomsManagementEntity.tblPenaltyMSTs.Where(m => m.PenaltyID == PenaltyId && m.IsDelete == false).FirstOrDefault();
                if (objPenaltyMst != null)
                {
                    objPenaltyMst.IsDelete = true;
                    if (loomsManagementEntity.SaveChanges() > 0)
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
