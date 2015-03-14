using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoomsManagement.DAL
{
   public class EmployeeTypeRepository
    {
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

        public static List<tblEmployeeTypeMSTDTO> GetAllEmployeeTypeDetails()
        {
            using (var LoomsManagementEntities = new LoomsManagementEntities())
            {
                return LoomsManagementEntities.tblEmployeeTypeMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public static tblEmployeeTypeMSTDTO GetEmployeeTypeDetails(int EmployeeTypeId)
        {
            using (var loomsManagementEntities = new LoomsManagementEntities())
            {
                return loomsManagementEntities.tblEmployeeTypeMSTs.Where(m => m.EmployeeTypeID == EmployeeTypeId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteEmployeeTypeData(int EmployeeTypeId)
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
    }
}
