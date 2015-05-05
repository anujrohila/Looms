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
           var YarnRepository = new YarnRepository();
           return YarnRepository.SaveYarnPackageType(tblYarnPackageTypeDTO);
       }

       public static List<tblYarnPackageTypeDTO> GetAllyarnPackageTypeDetails()
       {
           var YarnRepository = new YarnRepository();
           return YarnRepository.GetAllyarnPackageTypeDetails();
       }

       public static tblYarnPackageTypeDTO GetYarnPackageTypeDetails(int YarnPackageTypeId)
       {
           var YarnRepository = new YarnRepository();
           return YarnRepository.GetYarnPackageTypeDetails(YarnPackageTypeId);
       }

       public static int DeleteYarnPackageType(int YarnPackageTypeId)
       {
           var YarnRepository = new YarnRepository();
           return YarnRepository.DeleteYarnPackageType(YarnPackageTypeId);
       }


       #endregion

       #region [YarnQuality]

       public static int SavaYarnQuality(tblYarnQualityMSTDTO tblYarnQualityMSTDTO)
       {
           var YarnRepository = new YarnRepository();
           return YarnRepository.SavaYarnQuality(tblYarnQualityMSTDTO);
       }

       public static List<tblYarnQualityMSTDTO> GetAllYarnQualityDetails()
       {
           var YarnRepository = new YarnRepository();
           return YarnRepository.GetAllYarnQualityDetails();
       }

       public static tblYarnQualityMSTDTO GetYarnQualityDetails(int YarnQualityId)
       {
           var YarnRepository = new YarnRepository();
           return YarnRepository.GetYarnQualityDetails(YarnQualityId);
       }

       public static int DeleteYarnQuality(int YarnQualityId)
       {
           var YarnRepository = new YarnRepository();
           return YarnRepository.DeleteYarnQuality(YarnQualityId);
       }


       #endregion

       #region [YarnType]

       public static int SaveYarnType(tblYarnTypeMSTDTO tblYarnTypeDTO)
       {
           var YarnRepository = new YarnRepository();
           return YarnRepository.SaveYarnType(tblYarnTypeDTO);
       }

       public static List<tblYarnTypeMSTDTO> GetAllYarnTypeDetails()
       {
           var YarnRepository = new YarnRepository();
           return YarnRepository.GetAllYarnTypeDetails();
       }

       public static tblYarnTypeMSTDTO GetYarnTypeDetails(int YarnTypeId)
       {
           var YarnRepository = new YarnRepository();
           return YarnRepository.GetYarnTypeDetails(YarnTypeId);
       }

       public static int DeleteYarnType(int YarnTypeId)
       {
           var YarnRepository = new YarnRepository();
           return YarnRepository.DeleteYarnType(YarnTypeId);
       }

       #endregion
   }
}
