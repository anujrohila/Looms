using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoomsManagement.BAL
{
    public static class  CompnayBussinesLogic
    {
        /// <summary>
        /// Save Company Data
        /// </summary>
        /// <param name="tblCompanyDTO"></param>
        /// <returns></returns>
        public static int SaveCompanyData(tblCompanyDTO tblCompanyDTO)
        {
            var CompanyRepository = new CompanyRepository();
            return CompanyRepository.SaveCompanyData(tblCompanyDTO);
        }

        /// <summary>
        /// Get All Comapany Details
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public static List<tblCompanyDTO> GetAllCompanyDetails()
        {
            var CompanyRepository = new CompanyRepository();
            return CompanyRepository.GetAllCompanyDetails();
        }

        /// <summary>
        /// Get Perticuler Company Details
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public static tblCompanyDTO GetCompanyDetails(int CompanyID)
        {
            var CompanyRepository = new CompanyRepository();
            return CompanyRepository.GetCompanyDetails(CompanyID);
        }

        /// <summary>
        /// Delete Company
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public static int DeleteCompanyData(int CompanyID)
        {
            var CompanyRepository = new CompanyRepository();
            return CompanyRepository.DeleteCompanyData(CompanyID);
        }
    }
}
