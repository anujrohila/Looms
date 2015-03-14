using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
    public static class MachineTypeBusinessLogic
    {
        public static int SavaMachineTypeData(tblMachineTypeMSTDTO tblMachineTypeMSTDTO)
        {
            var MachineTypeRepository = new MachineTypeRepository();
            return MachineTypeRepository.SavaMachineTypeData(tblMachineTypeMSTDTO);
        }

        public static List<tblMachineTypeMSTDTO> GetAllMachineTypeDate()
        {
            var MachineTypeRepository = new MachineTypeRepository();
            return MachineTypeRepository.GetAllMachineTypeDate();
        }

        public static tblMachineTypeMSTDTO GetMachineTypeData(int MachineTypeId)
        {
            var MachineTypeRepository = new MachineTypeRepository();
            return MachineTypeRepository.GetMachineTypeData(MachineTypeId);
        }

        public static int DeleteMachineTypeData(int MachineTypeId)
        {
            var MachineTypeRepository = new MachineTypeRepository();
            return MachineTypeRepository.DeleteMachineTypeData(MachineTypeId);
        }
    }
}
