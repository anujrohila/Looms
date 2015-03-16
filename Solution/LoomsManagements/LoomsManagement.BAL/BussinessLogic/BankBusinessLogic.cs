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
            var BankRepository = new BankRepository();
            return BankRepository.SaveBank(tblBankMSTDTO);
        }

        public static List<tblBankMSTDTO> GetAllBankDetails()
        {
            var BankRepository = new BankRepository();
            return BankRepository.GetAllBankDetails();
        }

        public static tblBankMSTDTO GetBankDetails(int BankId)
        {
            var BankRepository = new BankRepository();
            return BankRepository.GetBankDetails(BankId);
        }

        public static int DeleteBank(int bankId)
        {
            var BankRepository = new BankRepository();
            return BankRepository.DeleteBank(bankId);
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
            var BankRepository = new BankRepository();
            return BankRepository.SaveBranch(tblBranchMSTDTO);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<tblBranchMSTDTO> GetAllBranchDetails()
        {
            var BankRepository = new BankRepository();
            return BankRepository.GetAllBranchDetails();
        }

        public static tblBranchMSTDTO GetBranchDetails(int BranchId)
        {
            var BankRepository = new BankRepository();
            return BankRepository.GetBranchDetails(BranchId);
        }

        public static int DeleteBranch(int BranchId)
        {
            var BankRepository = new BankRepository();
            return BankRepository.DeleteBranch(BranchId);
        }

       
        #endregion

    }
}
