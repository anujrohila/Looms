using LoomsManagement.BAL;
using LoomsManagement.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoomsManagement.Windows.Classes
{
    public static class UserContext
    {
        #region [Variable]

        public static int SelectedCompanyCode { get; set; }

        public static List<tblBeamMSTDTO> UserContexttblBeamMSTDTO { get; set; }

        public static tblEmployeeDTO UserContextUserInfo { get; set; }

        public static List<tblEmployeeDTO> UserContexttblEmployeeDTO { get; set; }

        public static List<tblEmployeeTypeMSTDTO> UserContexttblEmployeeTypeMSTDTO { get; set; }

        public static List<tblMachineMSTDTO> UserContexttblMachineMSTDTO { get; set; }

        public static List<tblMachineTypeMSTDTO> UserContexttblMachineTypeMSTDTO { get; set; }

        public static List<tblCompanyDTO> UserContexttblCompanyDTO { get; set; }

        public static List<tblCompanyMachineMSTDTO> UserContexttblCompanyMachineMSTDTO { get; set; }

        public static List<tblYarnPackageTypeDTO> UserContexttblYarnPackageTypeDTO { get; set; }

        public static List<tblYarnQualityMSTDTO> UserContexttblYarnQualityMSTDTO { get; set; }

        public static List<tblYarnTypeMSTDTO> UserContexttblYarnTypeMSTDTO { get; set; }

        public static List<tblBankMSTDTO> UserContexttblBankMSTDTO { get; set; }

        public static List<tblBranchMSTDTO> UserContexttblBranchMSTDTO { get; set; }

        public static List<tblPartysMSTDTO> UserContexttblPartysMSTDTO { get; set; }

        public static List<tblPenaltyMSTDTO> UserContexttblPenaltyMSTDTO { get; set; }

        public static List<tblBrokersMSTDTO> UserContexttblBrokersMSTDTO { get; set; }

        public static List<tblProfeListMstDTO> UserContexttblProofMSTDTO { get; set; }

        public static List<tblYarnPurchaseDTO> UserContexttblYarnPurchaseDTO { get; set; }

        public static List<tblWorkingYearDTO> UserContexttblWorkingYearDTO { get; set; }

        #endregion

        #region [Method]


        public static void LoadAllData()
        {
            GetALLBeamMSTDTO();
            GetALLtblCompanyDTO();
            //Employee
            GetALLtblEmployeeDTO();
            GetALLEmployeeTypeMSTDTO();
            GetALLtblPenaltyMSTDTO();
            
            //machine Details
            GetALLtblMachineMSTDTO();
            GetALLtblMachineTypeMSTDTO();
            GetALLtblCompanyMachineMSTDTO();
            
            //Yarn
            GetALLtblYarnPackageTypeDTO();
            GetALLtblYarnQualityMSTDTO();
            GetALLtblYarnTypeMSTDTO();

            //Bank
            GetALLtblBankMSTDTO();
            GetALLtblBranchMSTDTO();

            //party
            GetALLtblPartysMSTDTO();
            GetALLtblBrokersMSTDTO();

            //Proof
            GetALLtblProofMSTDTO();

            //Yarn Purchase
            GetALLtblYarnPurchaseDTO();

            //Year

            GetALLtblWorkingYearDTO();
            
        }

        public static void GetALLBeamMSTDTO()
        {
            UserContexttblBeamMSTDTO = BeamMasterBussinesLogic.GetAllBeamMasterDetails();
        }

        public static void GetALLtblEmployeeDTO()
        {
            UserContexttblEmployeeDTO = EmployeeBusinessLogic.GetAllEmployeeDetails();
        }

        public static void GetALLEmployeeTypeMSTDTO() {
            UserContexttblEmployeeTypeMSTDTO = EmployeeBusinessLogic.GetAllEmployeeTypeDetails();
        }

        public static void GetALLtblMachineMSTDTO() {
            UserContexttblMachineMSTDTO = MachineBusinessLogic.GetAllMachineDetails();
        }

        public static void GetALLtblMachineTypeMSTDTO() {
           UserContexttblMachineTypeMSTDTO = MachineBusinessLogic.GetAllMachineTypeDetails();
        }

        public static void GetALLtblCompanyDTO() {
            UserContexttblCompanyDTO = CompnayBussinesLogic.GetAllCompanyDetails();
        }

        public static void GetALLtblCompanyMachineMSTDTO() {
            
        }

        public static void GetALLtblYarnPackageTypeDTO() {
            UserContexttblYarnPackageTypeDTO = YarnBusinessLogic.GetAllyarnPackageTypeDetails();
        }

        public static void GetALLtblYarnQualityMSTDTO() {
            UserContexttblYarnQualityMSTDTO = YarnBusinessLogic.GetAllYarnQualityDetails();
        }

        public static void GetALLtblYarnTypeMSTDTO() {
            UserContexttblYarnTypeMSTDTO = YarnBusinessLogic.GetAllYarnTypeDetails();
        }

        public static void GetALLtblBankMSTDTO() {
            UserContexttblBankMSTDTO = BankBusinessLogic.GetAllBankDetails();
        }

        public static void GetALLtblBranchMSTDTO() {
            UserContexttblBranchMSTDTO = BankBusinessLogic.GetAllBranchDetails();
        }

        public static void GetALLtblPartysMSTDTO() {
            UserContexttblPartysMSTDTO = PartyBusinessLogic.GetAllPartyDetails();
        }

        public static void GetALLtblPenaltyMSTDTO() {
            UserContexttblPenaltyMSTDTO = EmployeeBusinessLogic.GetAllPenaltyDetails();
        }

        public static void GetALLtblBrokersMSTDTO() 
        {
            UserContexttblBrokersMSTDTO = PartyBusinessLogic.GetAllBrokerDetails();
        }

        public static void GetALLtblProofMSTDTO()
        {
            UserContexttblProofMSTDTO = ProofBusinessLogic.GetAllProofDetails();
        }

        public static void GetALLtblYarnPurchaseDTO()
        {
            UserContexttblYarnPurchaseDTO = YarnPurchaseBusinessLogic.GetAllYarnPurchase();
        }

        public static void GetALLtblWorkingYearDTO()
        {
            UserContexttblWorkingYearDTO = ProofBusinessLogic.GetAllWorkoingYearDetails();
        }

        #endregion
    }
}
