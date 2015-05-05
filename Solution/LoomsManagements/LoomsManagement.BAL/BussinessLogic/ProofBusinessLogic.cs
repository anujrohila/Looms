using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoomsManagement.Domain.DTO;
using LoomsManagement.DAL;


namespace LoomsManagement.BAL
{
    public static class ProofBusinessLogic
    {
        #region ProofMaster 

        public static int SaveProof(tblProfeListMstDTO tblProfeListMstDTO)
        {
           var ProofRepository = new ProofRepository();
            return ProofRepository.SaveProof(tblProfeListMstDTO);
        }

        public static List<tblProfeListMstDTO> GetAllProofDetails()
        {
            var ProofRepository = new ProofRepository();
            return ProofRepository.GetAllProofDetails();
        }

        public static tblProfeListMstDTO GetProofDetails(int ProofId)
        {
            var ProofRepository = new ProofRepository();
            return ProofRepository.GetProofDetails(ProofId);
        }

        public static int DeleteProof(int ProofId)
        {
            var ProofRepository = new ProofRepository();
            return ProofRepository.DeleteProof(ProofId);
        }

        #endregion

        #region Year

        public static List<tblWorkingYearDTO> GetAllWorkoingYearDetails()
        {
             var ProofRepository = new ProofRepository();
             return ProofRepository.GetAllWorkoingYearDetails();
        }

        #endregion
    }
}
