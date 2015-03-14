using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;

namespace LoomsManagement.DAL
{
   public class BranchMasterRepository
    {

        public int SaveBranchMasterData(tblBranchMSTDTO tblBranchMSTDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblBranchMSTDTO.BranchID == 0)
                {
                    if (loomsManagementEntity.tblBranchMSTs.Where(m => m.BranchID == tblBranchMSTDTO.BranchID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 0;
                    }
                    else
                    {
                        tblBranchMST objBranchMst = tblBranchMSTDTO.ToEntity();
                        loomsManagementEntity.tblBranchMSTs.Add(objBranchMst);
                    }
                }
                else
                {
                    if (loomsManagementEntity.tblBranchMSTs.Where(m => m.BranchName == tblBranchMSTDTO.BranchName && m.BranchID != tblBranchMSTDTO.BranchID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 0;
                    }
                    else
                    {
                        tblBranchMST objBranchMst = loomsManagementEntity.tblBranchMSTs.Where(m => m.BranchID == tblBranchMSTDTO.BranchID && m.IsDelete == false).FirstOrDefault();
                        if (objBranchMst != null)
                        {
                            objBranchMst.BranchID = tblBranchMSTDTO.BranchID;
                            objBranchMst.BankID = tblBranchMSTDTO.BankID;
                            objBranchMst.BranchName = tblBranchMSTDTO.BranchName;
                            objBranchMst.Address = tblBranchMSTDTO.Address;
                            objBranchMst.UpdateBy = tblBranchMSTDTO.UpdateBy;
                            objBranchMst.UpdationDateTime = tblBranchMSTDTO.UpdationDateTime;
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

        public static List<tblBranchMSTDTO> GetAllBranchMasterData()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblBranchMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }

        }

        public static tblBranchMSTDTO GetBranchData(int BranchId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblBranchMSTs.Where(m => m.BranchID == BranchId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteBranchMasterData(int BranchId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                tblBranchMST objBranchMst = loomsManagementEntity.tblBranchMSTs.Where(m => m.BranchID == BranchId && m.IsDelete == false).FirstOrDefault();
                if (objBranchMst != null)
                {
                    objBranchMst.IsDelete = true;
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

        public static List<tblBankMSTDTO> GetAllBankMasterData()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblBankMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

    }
}
