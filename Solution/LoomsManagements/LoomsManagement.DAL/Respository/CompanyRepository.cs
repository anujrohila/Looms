using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
    public class CompanyRepository
    {

        public int SaveCompanyData(tblCompanyDTO tblCompanyDTO)
        {
            using (var loomsManagementEntities = new LoomsManagementEntities())
            {
                if (tblCompanyDTO.CompanyID == 0)
                {
                    if (loomsManagementEntities.tblCompanies.Where(m => m.CompanyName == tblCompanyDTO.CompanyName && m.IsDelete == false).ToList().Count > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblCompany objcompany = tblCompanyDTO.ToEntity();
                        loomsManagementEntities.tblCompanies.Add(objcompany);
                    }
                }
                else
                {
                    if (loomsManagementEntities.tblCompanies.Where(m => m.CompanyName == tblCompanyDTO.CompanyName && m.CompanyID != tblCompanyDTO.CompanyID && m.IsDelete == false).ToList().Count > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblCompany objcompany = loomsManagementEntities.tblCompanies.Where(m => m.CompanyID == tblCompanyDTO.CompanyID && m.IsDelete == false).FirstOrDefault();
                        if (objcompany != null)
                        {
                            objcompany.CompanyName = tblCompanyDTO.CompanyName;
                            objcompany.ComapnyCode = tblCompanyDTO.ComapnyCode;
                            objcompany.OwnerName = tblCompanyDTO.OwnerName;
                            objcompany.StartDate = tblCompanyDTO.StartDate;
                            objcompany.InvestmentAmount = tblCompanyDTO.InvestmentAmount;
                            objcompany.ContactPersonName = tblCompanyDTO.ContactPersonName;
                            objcompany.Address = tblCompanyDTO.Address;
                            objcompany.PANNo = tblCompanyDTO.PANNo;
                            objcompany.CSTNo = tblCompanyDTO.CSTNo;
                            objcompany.ECCNo = tblCompanyDTO.ECCNo;
                            objcompany.SMSNO = tblCompanyDTO.SMSNO;
                            objcompany.UpdatedBy = tblCompanyDTO.UpdatedBy;
                            objcompany.UpdatedDateTime = tblCompanyDTO.UpdatedDateTime;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
                if (loomsManagementEntities.SaveChanges() > 0)
                    return 0;
                else
                    return 2;
            }
        }

        public static List<tblCompanyDTO> GetAllCompanyDetails()
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblCompanies.Where(m =>  m.IsDelete == false).ToList<tblCompany>().ToDTOs();
            }
        }

        public static tblCompanyDTO GetCompanyDetails(int CompanyID)
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblCompanies.Where(m => m.CompanyID == CompanyID && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteCompanyData(int CompanyID)
        {
            using (var loomsManagementEntities = new LoomsManagementEntities())
            {
                tblCompany objcompany = loomsManagementEntities.tblCompanies.Where(m => m.CompanyID == CompanyID && m.IsDelete == false).FirstOrDefault();
                if (objcompany != null)
                {
                    objcompany.IsDelete = true;
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
