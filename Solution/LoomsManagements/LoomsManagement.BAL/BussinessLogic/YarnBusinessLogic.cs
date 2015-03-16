using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
   public static class YarnBusinessLogic
   {
       #region [YarnPackegeType]

       public static int SaveYarnPackageType(tblYarnPackageTypeDTO tblYarnPackageTypeDTO)
       {
           var YarnPackageTypeRepository = new YarnPackageTypeRepository();
           return YarnPackageTypeRepository.SaveYarnPackageType(tblYarnPackageTypeDTO);
       }

       public static List<tblYarnPackageTypeDTO> GetAllyarnPackageTypeDetails()
       {
           var YarnPackageTypeRepository = new YarnPackageTypeRepository();
           return YarnPackageTypeRepository.GetAllyarnPackageTypeDetails();
       }

       public static tblYarnPackageTypeDTO GetYarnPackageTypeDetails(int YarnPackageTypeId)
       {
           var YarnPackageTypeRepository = new YarnPackageTypeRepository();
           return YarnPackageTypeRepository.GetYarnPackageTypeDetails(YarnPackageTypeId);
       }

       public static int DeleteYarnPackageType(int YarnPackageTypeId)
       {
           var YarnPackageTypeRepository = new YarnPackageTypeRepository();
           return YarnPackageTypeRepository.DeleteYarnPackageType(YarnPackageTypeId);
       }


       #endregion

       #region [YarnQuality]

       public static int SavaYarnQuality(tblYarnQualityMSTDTO tblYarnQualityMSTDTO)
       {
           var YarnQualityMasterRepository = new YarnQualityMasterRepository();
           return YarnQualityMasterRepository.SavaYarnQuality(tblYarnQualityMSTDTO);
       }

       public static List<tblYarnQualityMSTDTO> GetAllYarnQualityDetails()
       {
           var YarnQualityMasterRepository = new YarnQualityMasterRepository();
           return YarnQualityMasterRepository.GetAllYarnQualityDetails();
       }

       public static tblYarnQualityMSTDTO GetYarnQualityDetails(int YarnQualityId)
       {
           var YarnQualityMasterRepository = new YarnQualityMasterRepository();
           return YarnQualityMasterRepository.GetYarnQualityDetails(YarnQualityId);
       }

       public static int DeleteYarnQuality(int YarnQualityId)
       {
           var YarnQualityMasterRepository = new YarnQualityMasterRepository();
           return YarnQualityMasterRepository.DeleteYarnQuality(YarnQualityId);
       }


       #endregion

       #region [YarnType]

       public static int SaveYarnType(tblYarnTypeMSTDTO tblYarnTypeDTO)
       {
           var YarnTypeRepository = new YarnTypeRepository();
           return YarnTypeRepository.SaveYarnType(tblYarnTypeDTO);
       }

       public static List<tblYarnTypeMSTDTO> GetAllYarnTypeDetails()
       {
           var YarnTypeRepository = new YarnTypeRepository();
           return YarnTypeRepository.GetAllYarnTypeDetails();
       }

       public static tblYarnTypeMSTDTO GetYarnTypeDetails(int YarnTypeId)
       {
           var YarnTypeRepository = new YarnTypeRepository();
           return YarnTypeRepository.GetYarnTypeDetails(YarnTypeId);
       }

       public static int DeleteYarnType(int YarnTypeId)
       {
           var YarnTypeRepository = new YarnTypeRepository();
           return YarnTypeRepository.DeleteYarnType(YarnTypeId);
       }

       #endregion
   }
}
