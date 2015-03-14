using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
   public static class MachineMasterBusinessLogic
    {
       
       public int SavaMachineMasterData(tblMachineMSTDTO tblMachineMSTDTO)
       {
           var MachineMasterRepository = new MachineMasterRepository();
           return MachineMasterRepository.SavaMachineMasterData(tblMachineMSTDTO);
       }

       public static List<tblMachineMSTDTO> GetAllMachineData()
       {
           var MachineMasterRepository = new MachineMasterRepository();
           return MachineMasterRepository.GetAllMachineData();
       }

       public static tblMachineMSTDTO GetMachineMasterData(int MachineId)
       {
           var MachineMasterRepository = new MachineMasterRepository();
           return MachineMasterRepository.GetMachineMasterData(MachineId);
       }

       public int DeleteMachineMasterData(int MachineId)
       {
           var MachineMasterRepository = new MachineMasterRepository();
           return MachineMasterRepository.DeleteMachineMasterData(MachineId);
       }

       public static List<tblMachineTypeMSTDTO> GetAllMachineTypeData()
       {
             var MachineMasterRepository = new MachineMasterRepository();
             return MachineMasterRepository.GetAllMachineTypeData();
       }

    }
}
