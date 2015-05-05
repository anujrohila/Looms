using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
   public class YarnPurchaseRepository
    {
       public int SaveYarnPurchase(tblYarnPurchaseDTO tblYarnPurchaseDTO)
       {
           using (var loomsManagementEntity = new LoomsManagementEntities())
           {
               if (tblYarnPurchaseDTO.PurchaseID == 0)
               {
                   if (loomsManagementEntity.tblYarnPurchases.Where(m => m.SRNo == tblYarnPurchaseDTO.SRNo && m.IsDelete == false).ToList().Count() > 0)
                   {
                       return 1;
                   }
                   else
                   {
                       tblYarnPurchase objYarnPurchase = tblYarnPurchaseDTO.ToEntity();
                       loomsManagementEntity.tblYarnPurchases.Add(objYarnPurchase);
                   }
               }
               else
               {
                   if (loomsManagementEntity.tblYarnPurchases.Where(m =>m.SRNo==tblYarnPurchaseDTO.SRNo && m.PurchaseID != tblYarnPurchaseDTO.PurchaseID && m.IsDelete == false).ToList().Count() > 0)
                   {
                       return 1;
                   }
                   else
                   {
                       tblYarnPurchase objYarnPurchase = loomsManagementEntity.tblYarnPurchases.Where(m => m.PurchaseID == tblYarnPurchaseDTO.PurchaseID && m.IsDelete == false).FirstOrDefault();
                       {
                           if (objYarnPurchase != null)
                           {
                               objYarnPurchase.PurchaseID = tblYarnPurchaseDTO.PurchaseID;
                               objYarnPurchase.BrokerID = tblYarnPurchaseDTO.BrokerID;
                               objYarnPurchase.ChallanNo = tblYarnPurchaseDTO.ChallanNo;
                               objYarnPurchase.CompanyID = tblYarnPurchaseDTO.CompanyID;
                               objYarnPurchase.EmployeeId = tblYarnPurchaseDTO.EmployeeId;
                               objYarnPurchase.Grade = tblYarnPurchaseDTO.Grade;
                               objYarnPurchase.LRNo = tblYarnPurchaseDTO.LRNo;
                               objYarnPurchase.PartyID = tblYarnPurchaseDTO.PartyID;
                               objYarnPurchase.PurchaseDate = tblYarnPurchaseDTO.PurchaseDate;
                               objYarnPurchase.RecieveAt = tblYarnPurchaseDTO.RecieveAt;
                               objYarnPurchase.SRNo = tblYarnPurchaseDTO.SRNo;
                               objYarnPurchase.YearID = tblYarnPurchaseDTO.YearID;
                               objYarnPurchase.UpdatedBy = tblYarnPurchaseDTO.UpdatedBy;
                               objYarnPurchase.UpDatedDateTime = tblYarnPurchaseDTO.UpDatedDateTime;
                           }
                           else
                           {
                               return 2;
                           }
                       }
                   }
               }
                 if (loomsManagementEntity.SaveChanges() > 0)
                    return 0;
                else
                    return 2;
           }
       }

       public static List<tblYarnPurchaseDTO> GetAllYarnPurchase()
       {
           using (var loomsManagementEntity = new LoomsManagementEntities())
           {
               return loomsManagementEntity.tblYarnPurchases.Where(m => m.IsDelete == false).ToList().ToDTOs();
           }
       }

       public tblYarnPurchaseDTO GetYarnPurchase(int PurchaseId)
       {
           using (var loomsManagementEntity = new LoomsManagementEntities())
           {
               return loomsManagementEntity.tblYarnPurchases.Where(m => m.PurchaseID == PurchaseId && m.IsDelete == false).FirstOrDefault().ToDTO();
           }
       }

       public int DeleteYarPurchase(int PurchaseId)
       {
           using (var loomsManagementEntity = new LoomsManagementEntities())
           {
               tblYarnPurchase objYarnPurchase = loomsManagementEntity.tblYarnPurchases.Where(m => m.PurchaseID == PurchaseId && m.IsDelete == false).FirstOrDefault();
               {
                   if (objYarnPurchase != null)
                   {
                       objYarnPurchase.IsDelete = true;
                       if (loomsManagementEntity.SaveChanges() > 0)
                       {
                           return 0;
                       }
                       else
                       {
                           return 2;
                       }
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
