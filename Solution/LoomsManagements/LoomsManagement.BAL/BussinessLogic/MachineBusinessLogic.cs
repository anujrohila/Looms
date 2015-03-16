using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
   public static class MachineBusinessLogic
   {

       #region [Machine]

       public static int SavaMachine(tblMachineMSTDTO tblMachineMSTDTO)
       {
           var MachineMasterRepository = new MachineMasterRepository();
           return MachineMasterRepository.SavaMachine(tblMachineMSTDTO);
       }

       public static List<tblMachineMSTDTO> GetAllMachineDetails()
       {
           var MachineMasterRepository = new MachineMasterRepository();
           return MachineMasterRepository.GetAllMachineDetails();
       }

       public static tblMachineMSTDTO GetMachineDetails(int MachineId)
       {
           var MachineMasterRepository = new MachineMasterRepository();
           return MachineMasterRepository.GetMachineDetails(MachineId);
       }

       public static int DeleteMachine(int MachineId)
       {
           var MachineMasterRepository = new MachineMasterRepository();
           return MachineMasterRepository.DeleteMachine(MachineId);
       }

       #endregion

       #region [MachineType]

       public static int SavaMachineType(tblMachineTypeMSTDTO tblMachineTypeMSTDTO)
       {
           var MachineTypeRepository = new MachineTypeRepository();
           return MachineTypeRepository.SavaMachineType(tblMachineTypeMSTDTO);
       }

       public static List<tblMachineTypeMSTDTO> GetAllMachineType()
       {
           var MachineTypeRepository = new MachineTypeRepository();
           return MachineTypeRepository.GetAllMachineTypeDetails();
       }

       public static tblMachineTypeMSTDTO GetMachineTypeDetails(int MachineTypeId)
       {
           var MachineTypeRepository = new MachineTypeRepository();
           return MachineTypeRepository.GetMachineTypeDetails(MachineTypeId);
       }

       public static int DeleteMachineType(int MachineTypeId)
       {
           var MachineTypeRepository = new MachineTypeRepository();
           return MachineTypeRepository.DeleteMachineType(MachineTypeId);
       }

       #endregion


   }
}
