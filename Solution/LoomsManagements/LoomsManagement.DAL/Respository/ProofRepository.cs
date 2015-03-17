using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
   public class ProofRepository
    {
        #region Proof Master

        public int SaveProof(tblProfeListMstDTO tblProfeListMstDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblProfeListMstDTO.ProfeID == 0)
                {
                    if (loomsManagementEntity.tblProfeListMsts.Where(m => m.Name == tblProfeListMstDTO.Name && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }

                    tblProfeListMst objProofMst = tblProfeListMstDTO.ToEntity();
                    loomsManagementEntity.tblProfeListMsts.Add(objProofMst);
                }
                else
                {
                    if (loomsManagementEntity.tblProfeListMsts.Where(m => m.Name == tblProfeListMstDTO.Name && m.ProfeID != tblProfeListMstDTO.ProfeID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblProfeListMst objProofMst = loomsManagementEntity.tblProfeListMsts.Where(m => m.ProfeID == tblProfeListMstDTO.ProfeID && m.IsDelete == false).FirstOrDefault();
                        if (objProofMst != null)
                        {
                            objProofMst.ProfeID = tblProfeListMstDTO.ProfeID;
                            objProofMst.Name = tblProfeListMstDTO.Name;
                            objProofMst.UpdateBy = tblProfeListMstDTO.UpdateBy;
                            objProofMst.UpdateDateTime = tblProfeListMstDTO.UpdateDateTime;
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

        public List<tblProfeListMstDTO> GetAllProofDetails()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblProfeListMsts.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public tblProfeListMstDTO GetProofDetails(int ProofId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblProfeListMsts.Where(m => m.ProfeID == ProofId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteProof(int ProofId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                tblProfeListMst objProofMst = loomsManagementEntity.tblProfeListMsts.Where(m => m.ProfeID == ProofId && m.IsDelete == false).FirstOrDefault();
                if (objProofMst != null)
                {
                    objProofMst.IsDelete = true;
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
