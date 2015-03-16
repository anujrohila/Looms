using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
    public static class BankBusinessLogic
    {

        #region [Bank]

        public static int SaveBank(tblBankMSTDTO tblBankMSTDTO)
        {
            var BankMasterRepository = new BankMasterRepository();
            return BankMasterRepository.SaveBank(tblBankMSTDTO);
        }

        public static List<tblBankMSTDTO> GetAllBankMasterDetails()
        {
            var BankMasterRepository = new BankMasterRepository();
            return BankMasterRepository.GetAllBankMasterDetails();
        }

        public static tblBankMSTDTO GetBankMasterDetails(int BankId)
        {
            var BankMasterRepository = new BankMasterRepository();
            return BankMasterRepository.GetBankMasterDetails(BankId);
        }

        public static int DeleteBank(int bankId)
        {
            var BankMasterRepository = new BankMasterRepository();
            return BankMasterRepository.DeleteBank(bankId);
        }
        
        #endregion

        #region [Branch]

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblBranchMSTDTO"></param>
        /// <returns></returns>
        public static int SaveBranch(tblBranchMSTDTO tblBranchMSTDTO)
        {
            var BranchMasterRepository = new BranchMasterRepository();
            return BranchMasterRepository.SaveBranch(tblBranchMSTDTO);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<tblBranchMSTDTO> GetAllBranchMasterDetails()
        {
            var BranchMasterRepository = new BranchMasterRepository();
            return BranchMasterRepository.GetAllBranchMasterDetails();
        }

        public static tblBranchMSTDTO GetBranchDetails(int BranchId)
        {
            var BranchMasterRepository = new BranchMasterRepository();
            return BranchMasterRepository.GetBranchDetails(BranchId);
        }

        public static int DeleteBranch(int BranchId)
        {
            var BranchMasterRepository = new BranchMasterRepository();
            return BranchMasterRepository.DeleteBranch(BranchId);
        }

       
        #endregion

    }
}
