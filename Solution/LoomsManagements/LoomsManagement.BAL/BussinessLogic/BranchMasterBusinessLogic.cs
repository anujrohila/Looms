using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
   public static class BranchMasterBusinessLogic
    {

       public static int SaveBranchMasterData(tblBranchMSTDTO tblBranchMSTDTO)
       {
           var BranchMasterRepository = new BranchMasterRepository();
           return  BranchMasterRepository.SaveBranchMasterData(tblBranchMSTDTO);
       }

       public static List<tblBranchMSTDTO> GetAllBranchMasterData()
       {
           var BranchMasterRepository = new BranchMasterRepository();
           return BranchMasterRepository.GetAllBranchMasterData();
       }

       public static tblBranchMSTDTO GetBranchData(int BranchId)
       {
             var BranchMasterRepository = new BranchMasterRepository();
             return BranchMasterRepository.GetBranchData(BranchId);
       }

       public static int DeleteBranchMasterData(int BranchId)
       {
            var BranchMasterRepository = new BranchMasterRepository();
            return BranchMasterRepository.DeleteBranchMasterData(BranchId);
       }

       public static List<tblBankMSTDTO> GetAllBankMasterData()
       {
           var BranchMasterRepository = new BranchMasterRepository();
           return BranchMasterRepository.GetAllBankMasterData();
       }

    }
}
