using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;


namespace LoomsManagement.BAL
{
   public static class EmployeetypeBusinessLogic
    {
        public static int SaveEmployeeType(tblEmployeeTypeMSTDTO tblEmployeeTypeMSTDTO)
        {
            var EmployeeTypeRepository = new EmployeeTypeRepository();
            return EmployeeTypeRepository.SaveEmployeeType(tblEmployeeTypeMSTDTO);
        }

        public static List<tblEmployeeTypeMSTDTO> GetAllEmployeeTypeDetails()
        {
            var EmployeeTypeRepository = new EmployeeTypeRepository();
            return EmployeeTypeRepository.GetAllEmployeeTypeDetails();
        }

        public static tblEmployeeTypeMSTDTO GetEmployeeTypeDetails(int EmployeeTypeId)
        {
            var EmployeeTypeRepository = new EmployeeTypeRepository();
            return EmployeeTypeRepository.GetEmployeeTypeDetails(EmployeeTypeId);
        }

        public static int DeleteEmployeeTypeData(int EmployeeTypeId)
        {
            var EmployeeTypeRepository = new EmployeeTypeRepository();
            return EmployeeTypeRepository.DeleteEmployeeTypeData(EmployeeTypeId);
        }
    }
}
