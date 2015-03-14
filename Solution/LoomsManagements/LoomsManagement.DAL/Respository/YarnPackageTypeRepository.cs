using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
    public class YarnPackageTypeRepository
    {

        public int SaveYarnPackageTypeMasterDetail(tblYarnPackageTypeDTO tblYarnPackageTypeDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblYarnPackageTypeDTO.YarnPackageTypeID == 0)
                {
                    if (loomsManagementEntity.tblYarnPackageTypes.Where(m => m.YarnPackageTypeID == tblYarnPackageTypeDTO.YarnPackageTypeID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    tblYarnPackageType objYarnPackage = tblYarnPackageTypeDTO.ToEntity();
                    loomsManagementEntity.tblYarnPackageTypes.Add(objYarnPackage);
                }
                else
                {
                    if (loomsManagementEntity.tblYarnPackageTypes.Where(m => m.TypeName == tblYarnPackageTypeDTO.TypeName && m.YarnPackageTypeID != tblYarnPackageTypeDTO.YarnPackageTypeID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblYarnPackageType objYarnPackageType = loomsManagementEntity.tblYarnPackageTypes.Where(m => m.YarnPackageTypeID == tblYarnPackageTypeDTO.YarnPackageTypeID && m.IsDelete == false).FirstOrDefault();
                        if (objYarnPackageType != null)
                        {
                            objYarnPackageType.YarnPackageTypeID = tblYarnPackageTypeDTO.YarnPackageTypeID;
                            objYarnPackageType.TypeName = tblYarnPackageTypeDTO.TypeName;
                            objYarnPackageType.UpdatedBy = tblYarnPackageTypeDTO.UpdatedBy;
                            objYarnPackageType.UpdatedDateTime = tblYarnPackageTypeDTO.UpdatedDateTime;
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

        public static List<tblYarnPackageTypeDTO> GetAllyarnPackageTypeData()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblYarnPackageTypes.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public static tblYarnPackageTypeDTO GetYarnPackageTypeData(int YarnPackageTypeId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblYarnPackageTypes.Where(m => m.YarnPackageTypeID == YarnPackageTypeId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteYarnPackageTypeData(int YarnPackageTypeId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                tblYarnPackageType objYarnPackageType = loomsManagementEntity.tblYarnPackageTypes.Where(m => m.YarnPackageTypeID == YarnPackageTypeId && m.IsDelete == false).FirstOrDefault();
                if (objYarnPackageType != null)
                {
                    objYarnPackageType.IsDelete = true;
                    if (loomsManagementEntity.SaveChanges() > 0)
                        return 0;
                    else
                        return 2; ;
                }
                else
                {
                    return 3;
                }
            }

        }

    }
}
