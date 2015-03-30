using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
    public static class FiscalYearBusinessLogic
    {

        #region [Machine]

        /// <summary>
        /// Save Fiscal Year
        /// </summary>
        /// <param name="tblFiscalYearDTO"></param>
        /// <returns></returns>
        public static int SavaFiscalYear(tblFiscalYearDTO tblFiscalYearDTO)
        {
            var fiscalYearRepository = new FiscalYearRepository();
            return fiscalYearRepository.SavaFiscalYear(tblFiscalYearDTO);
        }

        /// <summary>
        /// Get All Fiscal Year List
        /// </summary>
        /// <returns></returns>
        public static List<tblFiscalYearDTO> GetAllFiscalYear()
        {
            var fiscalYearRepository = new FiscalYearRepository();
            return fiscalYearRepository.GetAllFiscalYear();
        }

        /// <summary>
        /// Get Fiscal Year 
        /// </summary>
        /// <param name="fiscalYearId"></param>
        /// <returns></returns>
        public static tblFiscalYearDTO GetFiscalYear(int fiscalYearId)
        {
            var fiscalYearRepository = new FiscalYearRepository();
            return fiscalYearRepository.GetFiscalYear(fiscalYearId);
        }

        /// <summary>
        /// Delete Fiscal Year
        /// </summary>
        /// <param name="fiscalYearId"></param>
        /// <returns></returns>
        public static int DeleteFiscalYear(int fiscalYearId)
        {
            var fiscalYearRepository = new FiscalYearRepository();
            return fiscalYearRepository.DeleteFiscalYear(fiscalYearId);
        }

        #endregion

    }
}
