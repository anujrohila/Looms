using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
   public static class PartyMasterBusinessLogic
    {
        public static int SavePartyMasterData(tblPartysMSTDTO tblPartyMSTDTO)
        {
            var PartyMasterRepositotry = new PartyMasterRepositotry();
            return PartyMasterRepositotry.SavePartyMasterData(tblPartyMSTDTO);
        }

        public static List<tblPartysMSTDTO> GetAllPartyMasterDetails()
        {
            var PartyMasterRepositotry = new PartyMasterRepositotry();
            return PartyMasterRepositotry.GetAllPartyMasterDetails();
        }

        public static tblPartysMSTDTO GetPartyDetails(int PartyId)
        {
            var PartyMasterRepositotry = new PartyMasterRepositotry();
            return PartyMasterRepositotry.GetPartyDetails(PartyId);
        }

        public static int DeletePartyData(int PartyId)
        {
            var PartyMasterRepositotry = new PartyMasterRepositotry();
            return PartyMasterRepositotry.DeletePartyData(PartyId);
        }

        public static List<tblCompanyDTO> GetCompanyCode()
        {
            var PartyMasterRepositotry = new PartyMasterRepositotry();
            return PartyMasterRepositotry.GetCompanyCode();
        }
    }
}
