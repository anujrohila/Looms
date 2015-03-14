using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
   public static class YarnPackageTypeMasterBusinessLogic
    {

        public static int SaveYarnPackageTypeMasterDetail(tblYarnPackageTypeDTO tblYarnPackageTypeDTO)
        {
            var YarnPackageTypeRepository = new YarnPackageTypeRepository();
            return YarnPackageTypeRepository.SaveYarnPackageTypeMasterDetail(tblYarnPackageTypeDTO);
        }

        public static List<tblYarnPackageTypeDTO> GetAllyarnPackageTypeData()
        {
            var YarnPackageTypeRepository = new YarnPackageTypeRepository();
            return YarnPackageTypeRepository.GetAllyarnPackageTypeData();
        }

        public static tblYarnPackageTypeDTO GetYarnPackageTypeData(int YarnPackageTypeId)
        {
            var YarnPackageTypeRepository = new YarnPackageTypeRepository();
           return  YarnPackageTypeRepository.GetYarnPackageTypeData(YarnPackageTypeId);
        }

        public int DeleteYarnPackageTypeData(int YarnPackageTypeId)
        {
            var YarnPackageTypeRepository = new YarnPackageTypeRepository();
            return YarnPackageTypeRepository.DeleteYarnPackageTypeData(YarnPackageTypeId);
        }

    }
}
