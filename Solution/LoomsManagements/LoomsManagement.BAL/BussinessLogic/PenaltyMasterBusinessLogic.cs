using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
   public static class PenaltyMasterBusinessLogic
    {
       public static int SavePenaltyMasterData(tblPenaltyMSTDTO tblPenaltyMSTDTO)
       {
           var PenaltyMasterRepository = new PenaltyMasterRepository();
           return PenaltyMasterRepository.SavePenaltyMasterData(tblPenaltyMSTDTO);
       }

       public static List<tblPenaltyMSTDTO> GetAllPenaltyMasterData()
       {
           var PenaltyMasterRepository = new PenaltyMasterRepository();
           return PenaltyMasterRepository.GetAllPenaltyMasterData();
       }

       public static tblPenaltyMSTDTO GetPenaltyMasterData(int PenaltyId)
       {
           var PenaltyMasterRepository = new PenaltyMasterRepository();
           return PenaltyMasterRepository.GetPenaltyMasterData(PenaltyId);
       }

       public static int DeletePenaltyMasterData(int PenaltyId)
       {
            var PenaltyMasterRepository = new PenaltyMasterRepository();
            return PenaltyMasterRepository.DeletePenaltyMasterData(PenaltyId);
       }
    }
}
