using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoomsManagement.BAL
{
    public static class YarnPurchaseBusinessLogic
    {
        
        public static int SaveYarnPurchase(tblYarnPurchaseDTO tblYarnPurchaseDTO)
        {
            var YarnPurchaseRepository = new YarnPurchaseRepository();
            return YarnPurchaseRepository.SaveYarnPurchase(tblYarnPurchaseDTO);
        }

        public List<tblYarnPurchaseDTO> GetAllYarnPurchase()
        {
             var YarnPurchaseRepository = new YarnPurchaseRepository();
             return YarnPurchaseRepository.GetAllYarnPurchase();
        }

        public tblYarnPurchaseDTO GetYarnPurchase(int PurchaseId)
        {
             var YarnPurchaseRepository = new YarnPurchaseRepository();
             return YarnPurchaseRepository.GetYarnPurchase(PurchaseId);
        }

        public int DeleteYarPurchase(int PurchaseId)
        {
              var YarnPurchaseRepository = new YarnPurchaseRepository();
              return YarnPurchaseRepository.DeleteYarPurchase(PurchaseId);
        }

    }
}
