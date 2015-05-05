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

        #region [Employee]

        public  int SaveEmployee(tblEmployeeDTO tblEmployeeMSTDTO)
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

        public  List<tblEmployeeDTO> GetAllEmployeeDetails()
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblEmployees.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public  tblEmployeeDTO GetEmployeeDetails(int EmployeeId)
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblEmployees.Where(m => m.EmployeeID == EmployeeId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public  int DeleteEmployee(int EmployeeId)
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

        public  List<tblProfeListMstDTO> GetAllProfeList()
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblProfeListMsts.ToList().ToDTOs();
            }
        }
        
        #endregion

        #region [EmployeeType]
        public int SaveEmployeeType(tblEmployeeTypeMSTDTO tblEmployeeTypeMSTDTO)
        {
            using (var loomsManagementEntities = new LoomsManagementEntities())
            {
                if (tblEmployeeTypeMSTDTO.EmployeeTypeID == 0)
                {
                    if (loomsManagementEntities.tblEmployeeTypeMSTs.Where(m => m.TypeName == tblEmployeeTypeMSTDTO.TypeName && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblEmployeeTypeMST objEmployeeType = tblEmployeeTypeMSTDTO.ToEntity();
                        loomsManagementEntities.tblEmployeeTypeMSTs.Add(objEmployeeType);
                    }
                }
                else
                {
                    if (loomsManagementEntities.tblEmployeeTypeMSTs.Where(m => m.TypeName == tblEmployeeTypeMSTDTO.TypeName && m.EmployeeTypeID != tblEmployeeTypeMSTDTO.EmployeeTypeID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblEmployeeTypeMST objEmployeeType = loomsManagementEntities.tblEmployeeTypeMSTs.Where(m => m.EmployeeTypeID == tblEmployeeTypeMSTDTO.EmployeeTypeID && m.IsDelete == false).FirstOrDefault();
                        if (objEmployeeType != null)
                        {
                            objEmployeeType.EmployeeTypeID = tblEmployeeTypeMSTDTO.EmployeeTypeID;
                            objEmployeeType.TypeName = tblEmployeeTypeMSTDTO.TypeName;
                            objEmployeeType.UpdatedBy = tblEmployeeTypeMSTDTO.UpdatedBy;
                            objEmployeeType.UpdatedDateTime = tblEmployeeTypeMSTDTO.UpdatedDateTime;
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

        public  List<tblEmployeeTypeMSTDTO> GetAllEmployeeTypeDetails()
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblEmployeeTypeMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public  tblEmployeeTypeMSTDTO GetEmployeeTypeDetails(int EmployeeTypeId)
        {
            using (var loomsManagementEntities = new LoomsManagementEntities())
            {
                return loomsManagementEntities.tblEmployeeTypeMSTs.Where(m => m.EmployeeTypeID == EmployeeTypeId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteEmployeeType(int EmployeeTypeId)
        {
            using (var loomsManagementEntities = new LoomsManagementEntities())
            {
                tblEmployeeTypeMST objEmployeeType = loomsManagementEntities.tblEmployeeTypeMSTs.Where(m => m.EmployeeTypeID == EmployeeTypeId && m.IsDelete == false).FirstOrDefault();
                if (objEmployeeType != null)
                {
                    objEmployeeType.IsDelete = true;
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

        #endregion

        #region [Penalty]

        public int SavePenalty(tblPenaltyMSTDTO tblPenaltyMSTDTO)
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

        public  List<tblPenaltyMSTDTO> GetAllPenaltyDetails()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblPenaltyMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public  tblPenaltyMSTDTO GetPenaltyDetails(int PenaltyId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblPenaltyMSTs.Where(m => m.PenaltyID == PenaltyId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeletePenalty(int PenaltyId)
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

        #endregion

    }
}
