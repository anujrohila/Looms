using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
    public static class BankMasterBusinessLogic
    {
        public static int SaveBankMasterData(tblBankMSTDTO tblBankMSTDTO)
        {
            var BankMasterRepository = new BankMasterRepository();
            return BankMasterRepository.SaveBankMasterData(tblBankMSTDTO);
        }

        public static List<tblBankMSTDTO> GetAllBankMasterData()
        {
             var BankMasterRepository = new BankMasterRepository();
             return BankMasterRepository.GetAllBankMasterData();
        }

        public static tblBankMSTDTO GetBankMasterData(int BankId)
        {
             var BankMasterRepository = new BankMasterRepository();
             return BankMasterRepository.GetBankMasterData(BankId);
        }

        public static int DeleteBankMasterData(int bankId)
        {
             var BankMasterRepository = new BankMasterRepository();
             return BankMasterRepository.DeleteBankMasterData(bankId);
        }
    }
}
