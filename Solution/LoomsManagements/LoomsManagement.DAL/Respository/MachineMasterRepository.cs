using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
   public class MachineMasterRepository
    {

        public int SavaMachineMasterData(tblMachineMSTDTO tblMachineMSTDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblMachineMSTDTO.MachineID == 0)
                {
                    if (loomsManagementEntity.tblMachineMSTs.Where(m => m.MachineID == tblMachineMSTDTO.MachineID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblMachineMST objMachineMst = tblMachineMSTDTO.ToEntity();
                        loomsManagementEntity.tblMachineMSTs.Add(objMachineMst);
                    }
                }
                else
                {
                    if (loomsManagementEntity.tblMachineMSTs.Where(m => m.MachineName == tblMachineMSTDTO.MachineName && m.MachineID != tblMachineMSTDTO.MachineID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblMachineMST objMachineMst = loomsManagementEntity.tblMachineMSTs.Where(m => m.MachineID == tblMachineMSTDTO.MachineID && m.IsDelete == false).FirstOrDefault();
                        if (objMachineMst != null)
                        {
                            objMachineMst.MachineID = tblMachineMSTDTO.MachineID;
                            objMachineMst.MachineTypeID = tblMachineMSTDTO.MachineTypeID;
                            objMachineMst.MachineName = tblMachineMSTDTO.MachineName;
                            objMachineMst.AboutMachine = tblMachineMSTDTO.AboutMachine;
                            objMachineMst.UpdatedBy = tblMachineMSTDTO.UpdatedBy;
                            objMachineMst.UpdatedDateTime = tblMachineMSTDTO.UpdatedDateTime;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }

                if (loomsManagementEntity.SaveChanges() > 0)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }

            }
        }

        public static List<tblMachineMSTDTO> GetAllMachineData()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblMachineMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public static tblMachineMSTDTO GetMachineMasterData(int MachineId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblMachineMSTs.Where(m => m.MachineID == MachineId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteMachineMasterData(int MachineId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                tblMachineMST objMachineMst = loomsManagementEntity.tblMachineMSTs.Where(m => m.MachineID == MachineId && m.IsDelete == false).FirstOrDefault();
                {
                    if (objMachineMst != null)
                    {
                        objMachineMst.IsDelete = true;
                        if (loomsManagementEntity.SaveChanges() > 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        public static List<tblMachineTypeMSTDTO> GetAllMachineTypeData()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblMachineTypeMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

     }
}
