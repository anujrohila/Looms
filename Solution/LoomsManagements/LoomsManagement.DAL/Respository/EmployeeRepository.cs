using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
namespace LoomsManagement.DAL
{
    public class EmployeeRepository
    {

        public static int SaveEmployee(tblEmployeeDTO tblEmployeeMSTDTO)
        {
            using (var loomsManagementEntities = new LoomsManagementEntities())
            {
                if (tblEmployeeMSTDTO.EmployeeID == 0)
                {
                    if (loomsManagementEntities.tblEmployees.Where(m => m.EmployeeID == tblEmployeeMSTDTO.EmployeeID && m.IsDelete == false).ToList().Count > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        var objEmployee = tblEmployeeMSTDTO.ToEntity();
                        loomsManagementEntities.tblEmployees.Add(objEmployee);
                    }
                }
                else
                {
                    if (loomsManagementEntities.tblEmployees.Where(m => m.FirstName == tblEmployeeMSTDTO.FirstName && m.EmployeeID != tblEmployeeMSTDTO.EmployeeID && m.IsDelete == false).ToList().Count > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        var objEmployee = loomsManagementEntities.tblEmployees.Where(m => m.EmployeeID == tblEmployeeMSTDTO.EmployeeID && m.IsDelete == false).FirstOrDefault();
                        if (objEmployee != null)
                        {
                            objEmployee.EmployeeTypeID = tblEmployeeMSTDTO.EmployeeTypeID;
                            objEmployee.EmployeeCode = tblEmployeeMSTDTO.EmployeeCode;
                            objEmployee.JobTitle = tblEmployeeMSTDTO.JobTitle;
                            objEmployee.FirstName = tblEmployeeMSTDTO.FirstName;
                            objEmployee.MiddleName = tblEmployeeMSTDTO.MiddleName;
                            objEmployee.LastName = tblEmployeeMSTDTO.LastName;
                            objEmployee.ResidentialAddress = tblEmployeeMSTDTO.ResidentialAddress;
                            objEmployee.PermanentAddress = tblEmployeeMSTDTO.PermanentAddress;
                            objEmployee.MobileNo = tblEmployeeMSTDTO.MobileNo;
                            objEmployee.EmailID = tblEmployeeMSTDTO.EmailID;
                            objEmployee.DOB = tblEmployeeMSTDTO.DOB;
                            objEmployee.Gender = tblEmployeeMSTDTO.Gender;
                            objEmployee.IDProfe = tblEmployeeMSTDTO.IDProfe;
                            objEmployee.IDProfeNo = tblEmployeeMSTDTO.IDProfeNo;
                            objEmployee.Photo = tblEmployeeMSTDTO.Photo;
                            objEmployee.JoinDate = tblEmployeeMSTDTO.JoinDate;
                            objEmployee.LeaveDate = tblEmployeeMSTDTO.LeaveDate;
                            objEmployee.SponsorsID = tblEmployeeMSTDTO.SponsorsID;
                            objEmployee.Shift = tblEmployeeMSTDTO.Shift;
                            objEmployee.Salary = tblEmployeeMSTDTO.Salary;
                            objEmployee.PerDayWorkingHours = tblEmployeeMSTDTO.PerDayWorkingHours;
                            objEmployee.PerHourSalary = tblEmployeeMSTDTO.PerHourSalary;
                            objEmployee.PaymentType = tblEmployeeMSTDTO.PaymentType;
                            objEmployee.BankName = tblEmployeeMSTDTO.BankName;
                            objEmployee.BranchName = tblEmployeeMSTDTO.BranchName;
                            objEmployee.AccountNo = tblEmployeeMSTDTO.AccountNo;
                            objEmployee.RTGSNo = tblEmployeeMSTDTO.RTGSNo;
                            objEmployee.IFSCCode = tblEmployeeMSTDTO.IFSCCode;
                            objEmployee.OpeningBalance = tblEmployeeMSTDTO.OpeningBalance;
                            objEmployee.UpdatedBy = tblEmployeeMSTDTO.UpdatedBy;
                            objEmployee.UpdatedDate = tblEmployeeMSTDTO.UpdatedDate;
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

        public static List<tblEmployeeDTO> GetAllEmployeeDetails()
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblEmployees.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public static tblEmployeeDTO GetEmployeeDetails(int EmployeeId)
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblEmployees.Where(m => m.EmployeeID == EmployeeId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public static int DeleteEmployeeData(int EmployeeId)
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                var objcompany = LoomsManagementEntities.tblEmployees.Where(m => m.EmployeeID == EmployeeId && m.IsDelete == false).FirstOrDefault();
                if (objcompany != null)
                {
                    objcompany.IsDelete = true;
                    if (LoomsManagementEntities.SaveChanges() > 0)
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

        public static List<tblProfeListMstDTO> GetAllProfeList()
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblProfeListMsts.ToList().ToDTOs();
            }
        }
    }
}
