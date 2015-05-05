using LoomsManagement.DAL;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;

namespace LoomsManagement.BAL
{
    public static class BeamMasterBussinesLogic
    {
        /// <summary>
        /// Save Beam Master
        /// </summary>
        /// <param name="tblBeamMSTDTO"></param>
        /// <returns></returns>
        public static int SaveBeamMaster(tblBeamMSTDTO tblBeamMSTDTO)
        {
            var beamMasterRepository = new BeamMasterRepository();
            return beamMasterRepository.SaveBeamMaster(tblBeamMSTDTO);
        }

        /// <summary>
        /// Get All Beam Master Details
        /// </summary>
        /// <returns></returns>
        public static List<tblBeamMSTDTO> GetAllBeamMasterDetails()
        {
            var beamMasterRepository = new BeamMasterRepository();
            return beamMasterRepository.GetAllBeamMasterDetails();
        }

        /// <summary>
        /// Get Beam Master Details
        /// </summary>
        /// <param name="beamID"></param>
        /// <returns></returns>
        public static tblBeamMSTDTO GetBeamMasterDetails(int beamID)
        {
            var beamMasterRepository = new BeamMasterRepository();
            return beamMasterRepository.GetBeamMasterDetails(beamID);
        }

        /// <summary>
        /// Delete Company Data
        /// </summary>
        /// <param name="beamID"></param>
        /// <returns></returns>
        public static int DeleteCompanyData(int beamID)
        {
            var beamMasterRepository = new BeamMasterRepository();
            return beamMasterRepository.DeleteCompanyData(beamID);
        }

    }
}
