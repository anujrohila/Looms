using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
    public class YarnTypeRepository
    {
        public int SaveYarnTypeDetail(tblYarnTypeMSTDTO tblYarnTypeDTO)
        {
            using (var loomsManagementSystemEntity = new LoomsManagementEntities())
            {
                if (tblYarnTypeDTO.YarnTypeID == 0)
                {
                    if (loomsManagementSystemEntity.tblYarnTypeMSTs.Where(m => m.YarnTypeID == tblYarnTypeDTO.YarnTypeID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }

                    tblYarnTypeMST objYarnType = tblYarnTypeDTO.ToEntity();
                    loomsManagementSystemEntity.tblYarnTypeMSTs.Add(objYarnType);
                }
                else
                {
                    if (loomsManagementSystemEntity.tblYarnTypeMSTs.Where(m => m.YarnTypeName == tblYarnTypeDTO.YarnTypeName && m.YarnTypeID != tblYarnTypeDTO.YarnTypeID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblYarnTypeMST objYarnType = loomsManagementSystemEntity.tblYarnTypeMSTs.Where(m => m.YarnTypeID == tblYarnTypeDTO.YarnTypeID && m.IsDelete == false).FirstOrDefault();
                        if (objYarnType != null)
                        {
                            objYarnType.YarnTypeID = tblYarnTypeDTO.YarnTypeID;
                            objYarnType.YarnTypeName = tblYarnTypeDTO.YarnTypeName;
                            objYarnType.YarnQualityID = tblYarnTypeDTO.YarnQualityID;
                            objYarnType.Denier = tblYarnTypeDTO.Denier;
                            objYarnType.NumberOfFilaments = tblYarnTypeDTO.NumberOfFilaments;
                            objYarnType.Description = tblYarnTypeDTO.Description;
                            objYarnType.UpdateBy = tblYarnTypeDTO.UpdateBy;
                            objYarnType.UpdationDateTime = tblYarnTypeDTO.UpdationDateTime;
                        }
                        else
                        {
                            return 2;
                        }

                    }
                }

                if (loomsManagementSystemEntity.SaveChanges() > 0)
                    return 0;
                else
                    return 2;

            }
        }

        public static List<tblYarnTypeMSTDTO> GetAllYarnTypeDetails()
        {
            using (var loomsManagementSystemEntity = new LoomsManagementEntities())
            {
                return loomsManagementSystemEntity.tblYarnTypeMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public static tblYarnTypeMSTDTO GetYarnTypeDetails(int YarnTypeId)
        {
            using (var loomsManagementSystemEntity = new LoomsManagementEntities())
            {
                return loomsManagementSystemEntity.tblYarnTypeMSTs.Where(m => m.YarnTypeID == YarnTypeId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteYarnTypeDate(int YarnTypeId)
        {
            using (var loomsManagementSystemEntity = new LoomsManagementEntities())
            {
                tblYarnTypeMST objYarntype = loomsManagementSystemEntity.tblYarnTypeMSTs.Where(m => m.YarnTypeID == YarnTypeId && m.IsDelete == false).FirstOrDefault();
                {
                    if (objYarntype != null)
                    {
                        objYarntype.IsDelete = true;
                        if (loomsManagementSystemEntity.SaveChanges() > 0)
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

        public static List<tblYarnQualityMSTDTO> GetAllYarnQuality()
        {
            using (var loomsManagementSystemEntity = new LoomsManagementEntities())
            {
                return loomsManagementSystemEntity.tblYarnQualityMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }
    }
}
