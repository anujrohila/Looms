using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
    public class BankRepository
    {
        #region Bank Master

        public int SaveBankMaster(tblBankMSTDTO tblBankMSTDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblBankMSTDTO.BankID == 0)
                {
                    if (loomsManagementEntity.tblBankMSTs.Where(m => m.BankName==tblBankMSTDTO.BankName && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblBankMST objBankMst = tblBankMSTDTO.ToEntity();
                        loomsManagementEntity.tblBankMSTs.Add(objBankMst);
                    }
                }
                else
                {
                    if (loomsManagementEntity.tblBankMSTs.Where(m => m.BankName == tblBankMSTDTO.BankName && m.BankID != tblBankMSTDTO.BankID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblBankMST objBankMst = loomsManagementEntity.tblBankMSTs.Where(m => m.BankID == tblBankMSTDTO.BankID && m.IsDelete == false).FirstOrDefault();
                        if (objBankMst != null)
                        {
                            objBankMst.BankID = tblBankMSTDTO.BankID;
                            objBankMst.BankName = tblBankMSTDTO.BankName;
                            objBankMst.UpdateBy = tblBankMSTDTO.UpdateBy;
                            objBankMst.UpdationDateTime = tblBankMSTDTO.UpdationDateTime;
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

        public static List<tblBankMSTDTO> GetAllBankMasterDetails()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblBankMSTs.Where(m=>m.IsDelete==false).ToList().ToDTOs();
            }
        }

        public static tblBankMSTDTO GetBankMasterDetails(int BankId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblBankMSTs.Where(m=>m.BankID==BankId && m.IsDelete==false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteBank(int bankId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                tblBankMST objBankMst = loomsManagementEntity.tblBankMSTs.Where(m => m.BankID == bankId && m.IsDelete == false).FirstOrDefault();
                {
                    if (objBankMst != null)
                    {
                        objBankMst.IsDelete = true;
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

        #endregion

        #region Branch Master

        public int SaveBranch(tblBranchMSTDTO tblBranchMSTDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblBranchMSTDTO.BranchID == 0)
                {
                    if (loomsManagementEntity.tblBranchMSTs.Where(m => m.BranchName == tblBranchMSTDTO.BranchName && m.IsDelete == false).ToList().Count() > 0)
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

        public static List<tblBranchMSTDTO> GetAllBranchMasterDetails()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblBranchMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }

        }

        public static tblBranchMSTDTO GetBranchMasterDetails(int BranchId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblBranchMSTs.Where(m => m.BranchID == BranchId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteBranch(int BranchId)
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

        #endregion

    }
}
