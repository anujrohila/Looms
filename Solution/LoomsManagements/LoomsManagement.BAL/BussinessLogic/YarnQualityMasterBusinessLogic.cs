using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
   public static class YarnQualityMasterBusinessLogic
    {

        public static int SavaYarnQualityDetails(tblYarnQualityMSTDTO tblYarnQualityMSTDTO)
        {
            var YarnQualityMasterRepository = new YarnQualityMasterRepository();
           return  YarnQualityMasterRepository.SavaYarnQualityDetails(tblYarnQualityMSTDTO);
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

        public static int DeleteYarnQualityData(int YarnQualityId)
        {
            var YarnQualityMasterRepository = new YarnQualityMasterRepository();
            return YarnQualityMasterRepository.DeleteYarnQualityData(YarnQualityId);
        }

    }
}
