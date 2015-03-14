using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
    public class BankMasterRepository
    {

        public int SaveBankMasterData(tblBankMSTDTO tblBankMSTDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblBankMSTDTO.BankID == 0)
                {
                    if (loomsManagementEntity.tblBankMSTs.Where(m => m.BankID == tblBankMSTDTO.BankID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 0;
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

        public static List<tblBankMSTDTO> GetAllBankMasterData()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblBankMSTs.Where(m=>m.IsDelete==false).ToList().ToDTOs();
            }
        }

        public static tblBankMSTDTO GetBankMasterData(int BankId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblBankMSTs.Where(m=>m.BankID==BankId && m.IsDelete==false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteBankMasterData(int bankId)
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
        
    }
}
