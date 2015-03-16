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

        #region [Employee]

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
            return EmployeeRepository.DeleteEmployee(EmployeeId);
        }

        public static List<tblProfeListMstDTO> GetAllProfeList()
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.GetAllProfeList();
        }
        
        #endregion

        #region [EmpoyeeType]

        public static int SaveEmployeeType(tblEmployeeTypeMSTDTO tblEmployeeTypeMSTDTO)
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.SaveEmployeeType(tblEmployeeTypeMSTDTO);
        }

        public static List<tblEmployeeTypeMSTDTO> GetAllEmployeeTypeDetails()
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.GetAllEmployeeTypeDetails();
        }

        public static tblEmployeeTypeMSTDTO GetEmployeeTypeDetails(int EmployeeTypeId)
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.GetEmployeeTypeDetails(EmployeeTypeId);
        }

        public static int DeleteEmployeeType(int EmployeeTypeId)
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.DeleteEmployeeType(EmployeeTypeId);
        }

        #endregion

        #region [Penalty]

        public static int SavePenalty(tblPenaltyMSTDTO tblPenaltyMSTDTO)
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.SavePenalty(tblPenaltyMSTDTO);
        }

        public static List<tblPenaltyMSTDTO> GetAllPenaltyDetails()
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.GetAllPenaltyDetails();
        }

        public static tblPenaltyMSTDTO GetPenaltyDetails(int PenaltyId)
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.GetPenaltyDetails(PenaltyId);
        }

        public static int DeletePenalty(int PenaltyId)
        {
            var EmployeeRepository = new EmployeeRepository();
            return EmployeeRepository.DeletePenalty(PenaltyId);
        }
        #endregion

    }
}
