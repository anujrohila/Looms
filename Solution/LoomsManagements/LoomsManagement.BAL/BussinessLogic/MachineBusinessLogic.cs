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
           var MachineRepository = new MachineRepository();
           return MachineRepository.SavaMachine(tblMachineMSTDTO);
       }

       public static List<tblMachineMSTDTO> GetAllMachineDetails()
       {
           var MachineRepository = new MachineRepository();
           return MachineRepository.GetAllMachineDetails();
       }

       public static tblMachineMSTDTO GetMachineDetails(int MachineId)
       {
           var MachineRepository = new MachineRepository();
           return MachineRepository.GetMachineDetails(MachineId);
       }

       public static int DeleteMachine(int MachineId)
       {
           var MachineRepository = new MachineRepository();
           return MachineRepository.DeleteMachine(MachineId);
       }

       #endregion

       #region [MachineType]

       public static int SavaMachineType(tblMachineTypeMSTDTO tblMachineTypeMSTDTO)
       {
           var MachineRepository = new MachineRepository();
           return MachineRepository.SavaMachineType(tblMachineTypeMSTDTO);
       }

       public static List<tblMachineTypeMSTDTO> GetAllMachineTypeDetails()
       {
           var MachineRepository = new MachineRepository();
           return MachineRepository.GetAllMachineTypeDetails();
       }

       public static tblMachineTypeMSTDTO GetMachineTypeDetails(int MachineTypeId)
       {
           var MachineRepository = new MachineRepository();
           return MachineRepository.GetMachineTypeDetails(MachineTypeId);
       }

       public static int DeleteMachineType(int MachineTypeId)
       {
           var MachineRepository = new MachineRepository();
           return MachineRepository.DeleteMachineType(MachineTypeId);
       }

       #endregion

   }
}
