using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;

namespace LoomsManagement.BAL
{
    public static class EmployeeBusinessLogic
    {
        public static int SaveEmployee(tblEmployeeDTO tblEmployeeMSTDTO)
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.SaveEmployee(tblEmployeeMSTDTO);
        }

        public static List<tblEmployeeDTO> GetAllEmployeeDetails()
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.GetAllEmployeeDetails();
        }

        public static tblEmployeeDTO GetEmployeeDetails(int EmployeeId)
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.GetEmployeeDetails(EmployeeId);
        }

        public static int DeleteEmployeeData(int EmployeeId)
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.DeleteEmployeeData(EmployeeId);
        }

        public static List<tblProfeListMstDTO> GetAllProfeList()
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.GetAllProfeList();
        }
    }
}
