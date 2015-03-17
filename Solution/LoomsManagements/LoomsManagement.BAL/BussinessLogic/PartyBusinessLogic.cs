using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
    public static class PartyBusinessLogic
    {
        #region Party Master

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

        #endregion

        #region Broker Master

        public static int SaveBroker(tblBrokersMSTDTO tblBrokersMSTDTO)
        {

            var PartyRepositotry = new PartyRepositotry();
            return PartyRepositotry.SaveBroker(tblBrokersMSTDTO);
        }

        public static List<tblBrokersMSTDTO> GetAllBrokerDetails()
        {
            var PartyRepositotry = new PartyRepositotry();
            return PartyRepositotry.GetAllBrokerDetails();
        }

        public static tblBrokersMSTDTO GetBrokerDetails(int BrokerId)
        {
            var PartyRepositotry = new PartyRepositotry();
            return PartyRepositotry.GetBrokerDetails(BrokerId);
        }

        public static int DeleteBroker(int BrokerId)
        {
            var PartyRepositotry = new PartyRepositotry();
            return PartyRepositotry.DeleteBroker(BrokerId);
        }

        #endregion
    }
}
