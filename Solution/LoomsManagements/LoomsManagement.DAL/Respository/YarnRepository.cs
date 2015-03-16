using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
    public class YarnRepository
    {

        #region Yarn Quality

        public int SavaYarnQuality(tblYarnQualityMSTDTO tblYarnQualityMSTDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblYarnQualityMSTDTO.YarnQualityID == 0)
                { 
                    if (loomsManagementEntity.tblYarnQualityMSTs.Where(m => m.YarnQualityName == tblYarnQualityMSTDTO.YarnQualityName && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    tblYarnQualityMST objYarnQuality = tblYarnQualityMSTDTO.ToEntity();
                    loomsManagementEntity.tblYarnQualityMSTs.Add(objYarnQuality);
                }
                else
                {
                    if (loomsManagementEntity.tblYarnQualityMSTs.Where(m => m.YarnQualityName == tblYarnQualityMSTDTO.YarnQualityName && m.YarnQualityID != tblYarnQualityMSTDTO.YarnQualityID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblYarnQualityMST objYarnQuality = loomsManagementEntity.tblYarnQualityMSTs.Where(m => m.YarnQualityID == tblYarnQualityMSTDTO.YarnQualityID && m.IsDelete == false).FirstOrDefault();
                        if (objYarnQuality != null)
                        {
                            objYarnQuality.YarnQualityID = tblYarnQualityMSTDTO.YarnQualityID;
                            objYarnQuality.YarnQualityName = tblYarnQualityMSTDTO.YarnQualityName;
                            objYarnQuality.Description = tblYarnQualityMSTDTO.Description;
                            objYarnQuality.UpdateBy = tblYarnQualityMSTDTO.UpdateBy;
                            objYarnQuality.UpdationDateTime = tblYarnQualityMSTDTO.UpdationDateTime;
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

        public List<tblYarnQualityMSTDTO> GetAllYarnQualityDetails()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblYarnQualityMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public tblYarnQualityMSTDTO GetYarnQualityDetails(int YarnQualityId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblYarnQualityMSTs.Where(m => m.YarnQualityID == YarnQualityId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteYarnQuality(int YarnQualityId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                tblYarnQualityMST objYarnQuality = loomsManagementEntity.tblYarnQualityMSTs.Where(m => m.YarnQualityID == YarnQualityId && m.IsDelete == false).FirstOrDefault();
                {
                    if (objYarnQuality != null)
                    {
                        objYarnQuality.IsDelete = true;
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

        }

        #endregion

        #region Yarn Type

        public int SaveYarnType(tblYarnTypeMSTDTO tblYarnTypeDTO)
        {
            using (var loomsManagementSystemEntity = new LoomsManagementEntities())
            {
                if (tblYarnTypeDTO.YarnTypeID == 0)
                {
                    if (loomsManagementSystemEntity.tblYarnTypeMSTs.Where(m => m.YarnTypeName == tblYarnTypeDTO.YarnTypeName && m.IsDelete == false).ToList().Count() > 0)
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

        public List<tblYarnTypeMSTDTO> GetAllYarnTypeDetails()
        {
            using (var loomsManagementSystemEntity = new LoomsManagementEntities())
            {
                return loomsManagementSystemEntity.tblYarnTypeMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public tblYarnTypeMSTDTO GetYarnTypeDetails(int YarnTypeId)
        {
            using (var loomsManagementSystemEntity = new LoomsManagementEntities())
            {
                return loomsManagementSystemEntity.tblYarnTypeMSTs.Where(m => m.YarnTypeID == YarnTypeId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteYarnType(int YarnTypeId)
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

        #endregion

        #region Yarn Package Type

        public int SaveYarnPackageType(tblYarnPackageTypeDTO tblYarnPackageTypeDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblYarnPackageTypeDTO.YarnPackageTypeID == 0)
                {
                    if (loomsManagementEntity.tblYarnPackageTypes.Where(m => m.TypeName == tblYarnPackageTypeDTO.TypeName && m.IsDelete == false).ToList().Count() > 0)
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

        public List<tblYarnPackageTypeDTO> GetAllyarnPackageTypeDetails()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblYarnPackageTypes.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public tblYarnPackageTypeDTO GetYarnPackageTypeDetails(int YarnPackageTypeId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblYarnPackageTypes.Where(m => m.YarnPackageTypeID == YarnPackageTypeId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteYarnPackageType(int YarnPackageTypeId)
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

        #endregion

    }
}
