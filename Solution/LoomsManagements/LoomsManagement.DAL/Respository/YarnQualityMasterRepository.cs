using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
   public class YarnQualityMasterRepository
    {

       public int SavaYarnQualityDetails(tblYarnQualityMSTDTO tblYarnQualityMSTDTO)
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

       public static List<tblYarnQualityMSTDTO> GetAllYarnQualityDetails()
       {
           using (var loomsManagementEntity = new LoomsManagementEntities())
           {
               return loomsManagementEntity.tblYarnQualityMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
           }
       }

       public static tblYarnQualityMSTDTO GetYarnQualityDetails(int YarnQualityId)
       {
           using (var loomsManagementEntity = new LoomsManagementEntities())
           {
               return loomsManagementEntity.tblYarnQualityMSTs.Where(m => m.YarnQualityID == YarnQualityId && m.IsDelete == false).FirstOrDefault().ToDTO();
           }
       }

       public int DeleteYarnQualityData(int YarnQualityId)
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

    }
}
