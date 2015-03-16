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
            return EmployeeRepository.DeleteEmployeeData(EmployeeId);
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

        public static int DeleteEmployeeType(int EmployeeTypeId)
        {
            var EmployeeTypeRepository = new EmployeeTypeRepository();
            return EmployeeTypeRepository.DeleteEmployeeType(EmployeeTypeId);
        }

        #endregion

        #region [Penalty]

        public static int SavePenalty(tblPenaltyMSTDTO tblPenaltyMSTDTO)
        {
            var PenaltyMasterRepository = new PenaltyMasterRepository();
            return PenaltyMasterRepository.SavePenalty(tblPenaltyMSTDTO);
        }

        public static List<tblPenaltyMSTDTO> GetAllPenaltyMasterDetails()
        {
            var PenaltyMasterRepository = new PenaltyMasterRepository();
            return PenaltyMasterRepository.GetAllPenaltyMasterDetails();
        }

        public static tblPenaltyMSTDTO GetPenaltyMasterDetails(int PenaltyId)
        {
            var PenaltyMasterRepository = new PenaltyMasterRepository();
            return PenaltyMasterRepository.GetPenaltyMasterDetails(PenaltyId);
        }

        public static int DeletePenalty(int PenaltyId)
        {
            var PenaltyMasterRepository = new PenaltyMasterRepository();
            return PenaltyMasterRepository.DeletePenalty(PenaltyId);
        }
        #endregion

    }
}
