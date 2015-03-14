using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoomsManagement.BAL
{
  public static  class YarnTypeBusinessLogic
    {
      public static int SaveYarnTypeDetail(tblYarnTypeMSTDTO tblYarnTypeDTO)
      {
          var YarnTypeRepository = new YarnTypeRepository();
         return YarnTypeRepository.SaveYarnTypeDetail(tblYarnTypeDTO);
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

      public static int DeleteYarnTypeDate(int YarnTypeId)
      {
          var YarnTypeRepository = new YarnTypeRepository();
          return YarnTypeRepository.DeleteYarnTypeDate(YarnTypeId);
      }

           public static List<tblYarnQualityMSTDTO> GetAllYarnQuality()
           {
                 var YarnTypeRepository = new YarnTypeRepository();
               return YarnTypeRepository.GetAllYarnQuality();
           }
    }
}
