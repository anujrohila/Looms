using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
    public static class PartyBusinessLogic
    {
        public static int SaveParty(tblPartysMSTDTO tblPartyMSTDTO)
        {
            var PartyRepositotry = new PartyRepositotry();
            return PartyRepositotry.SaveParty(tblPartyMSTDTO);
        }

        public static List<tblPartysMSTDTO> GetAllPartyDetails()
        {
            var PartyRepositotry = new PartyRepositotry();
            return PartyRepositotry.GetAllPartyDetails();
        }

        public static tblPartysMSTDTO GetPartyDetails(int PartyId)
        {
            var PartyRepositotry = new PartyRepositotry();
            return PartyRepositotry.GetPartyDetails(PartyId);
        }

        public static int DeleteParty(int PartyId)
        {
            var PartyRepositotry = new PartyRepositotry();
            return PartyRepositotry.DeleteParty(PartyId);
        }
    }
}
