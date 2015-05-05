using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
    public class FiscalYearRepository
   {

       #region Machine 

        /// <summary>
        /// Save Fiscal Year
        /// </summary>
        /// <param name="tblFiscalYearDTO"></param>
        /// <returns></returns>
        public int SavaFiscalYear(tblFiscalYearDTO tblFiscalYearDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblFiscalYearDTO.FiscalYearId == 0)
                {
                    if (loomsManagementEntity.tblFiscalYears.Where(m => m.FiscalName == tblFiscalYearDTO.FiscalName && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        var tblFiscalYear = tblFiscalYearDTO.ToEntity();
                        loomsManagementEntity.tblFiscalYears.Add(tblFiscalYear);
                    }
                }
                else
                {
                    if (loomsManagementEntity.tblFiscalYears.Where(m => m.FiscalName == tblFiscalYearDTO.FiscalName && m.FiscalYearId != tblFiscalYearDTO.FiscalYearId && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        var objFiscalYear = loomsManagementEntity.tblFiscalYears.Where(m => m.FiscalYearId == tblFiscalYearDTO.FiscalYearId && m.IsDelete == false).FirstOrDefault();
                        if (objFiscalYear != null)
                        {
                            objFiscalYear.FiscalYearId = tblFiscalYearDTO.FiscalYearId;
                            objFiscalYear.FiscalName = tblFiscalYearDTO.FiscalName;
                            objFiscalYear.StartDate = tblFiscalYearDTO.StartDate;
                            objFiscalYear.EndDate = tblFiscalYearDTO.EndDate;
                            objFiscalYear.IsActive = tblFiscalYearDTO.IsActive;
                            objFiscalYear.IsDelete = tblFiscalYearDTO.IsDelete;
                            objFiscalYear.CreatedBy = tblFiscalYearDTO.CreatedBy;
                            objFiscalYear.CreatedDateTime = tblFiscalYearDTO.CreatedDateTime;
                            objFiscalYear.UpdatedBy = tblFiscalYearDTO.UpdatedBy;
                            objFiscalYear.UpdatedDateTime = tblFiscalYearDTO.UpdatedDateTime;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }

                if (loomsManagementEntity.SaveChanges() > 0)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }

            }
        }

        /// <summary>
        /// Get All Fiscal Year List
        /// </summary>
        /// <returns></returns>
        public List<tblFiscalYearDTO> GetAllFiscalYear()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblFiscalYears.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        /// <summary>
        /// Get Fiscal Year 
        /// </summary>
        /// <param name="fiscalYearId"></param>
        /// <returns></returns>
        public tblFiscalYearDTO GetFiscalYear(int fiscalYearId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblFiscalYears.Where(m => m.FiscalYearId == fiscalYearId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        /// <summary>
        /// Delete Fiscal Year
        /// </summary>
        /// <param name="fiscalYearId"></param>
        /// <returns></returns>
        public int DeleteFiscalYear(int fiscalYearId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                var objFiscalYear = loomsManagementEntity.tblFiscalYears.Where(m => m.FiscalYearId == fiscalYearId && m.IsDelete == false).FirstOrDefault();
                {
                    if (objFiscalYear != null)
                    {
                        objFiscalYear.IsDelete = true;
                        if (loomsManagementEntity.SaveChanges() > 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

       #endregion

    }
}
