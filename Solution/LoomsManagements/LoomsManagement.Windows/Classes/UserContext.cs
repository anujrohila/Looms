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

        public static tblEmployeeDTO UserContextUserInfo { get; set; }

        public static List<tblEmployeeDTO> UserContexttblEmployeeDTO { get; set; }

        public static List<tblEmployeeTypeMSTDTO> UserContexttblEmployeeTypeMSTDTO { get; set; }

        public static  List<tblMachineMSTDTO> UserContexttblMachineMSTDTO { get; set; }

        public static  List<tblMachineTypeMSTDTO> UserContexttblMachineTypeMSTDTO { get; set; }

        public static  List<tblCompanyDTO> UserContexttblCompanyDTO { get; set; }

        public static  List<tblCompanyMachineMSTDTO> UserContexttblCompanyMachineMSTDTO { get; set; }

        public static  List<tblYarnPackageTypeDTO> UserContexttblYarnPackageTypeDTO { get; set; }

        public static  List<tblYarnQualityMSTDTO> UserContexttblYarnQualityMSTDTO { get; set; }

        public static  List<tblYarnTypeMSTDTO> UserContexttblYarnTypeMSTDTO { get; set; }

        public static  List<tblBankMSTDTO> UserContexttblBankMSTDTO { get; set; }

        public static  List<tblBranchMSTDTO> UserContexttblBranchMSTDTO { get; set; }

        public static  List<tblPartysMSTDTO> UserContexttblPartysMSTDTO { get; set; }

        public static  List<tblPenaltyMSTDTO> UserContexttblPenaltyMSTDTO { get; set; }

        public static  List<tblBrokersMSTDTO> UserContexttblBrokersMSTDTO { get; set; }
       
        #endregion

        #region [Method]

        

        #endregion
    }
}
