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

        public static int DeleteEmployeeType(int EmployeeTypeId)
        {
            var EmployeeTypeRepository = new EmployeeTypeRepository();
            return EmployeeTypeRepository.DeleteEmployeeType(EmployeeTypeId);
        }

        #region [Penalty]

        public static int SavePenalty(tblPenaltyMSTDTO tblPenaltyMSTDTO)
        {
            var PenaltyMasterRepository = new PenaltyMasterRepository();
            return PenaltyMasterRepository.SavePenalty(tblPenaltyMSTDTO);
        }

        public static List<tblPenaltyMSTDTO> GetAllPenaltya()
        {
            var PenaltyMasterRepository = new PenaltyMasterRepository();
            return PenaltyMasterRepository.GetAllPenaltyDetails();
        }

        public static tblPenaltyMSTDTO GetPenaltya(int PenaltyId)
        {
            var PenaltyMasterRepository = new PenaltyMasterRepository();
            return PenaltyMasterRepository.GetPenaltyDetails(PenaltyId);
        }

        public static int DeletePenaltya(int PenaltyId)
        {
            var PenaltyMasterRepository = new PenaltyMasterRepository();
            return PenaltyMasterRepository.DeletePenalty(PenaltyId);
        }

        #endregion
    }
}
