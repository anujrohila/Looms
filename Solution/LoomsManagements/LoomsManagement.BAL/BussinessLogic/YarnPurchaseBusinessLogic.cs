using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;


namespace LoomsManagement.BAL
{
    public static class YarnPurchaseBusinessLogic
    {
        
        public static int SaveYarnPurchase(tblYarnPurchaseDTO tblYarnPurchaseDTO)
        {
            var YarnPurchaseRepository = new YarnPurchaseRepository();
            return YarnPurchaseRepository.SaveYarnPurchase(tblYarnPurchaseDTO);
        }

        public static List<tblYarnPurchaseDTO> GetAllYarnPurchase()
        {
             var YarnPurchaseRepository = new YarnPurchaseRepository();
             return YarnPurchaseRepository.GetAllYarnPurchase();
        }

        public static tblYarnPurchaseDTO GetYarnPurchase(int PurchaseId)
        {
             var YarnPurchaseRepository = new YarnPurchaseRepository();
             return YarnPurchaseRepository.GetYarnPurchase(PurchaseId);
        }

        public static int DeleteYarPurchase(int PurchaseId)
        {
              var YarnPurchaseRepository = new YarnPurchaseRepository();
              return YarnPurchaseRepository.DeleteYarPurchase(PurchaseId);
        }

    }
}
