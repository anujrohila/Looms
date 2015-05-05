using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LoomsManagement.DAL
{
   public class MachineRepository
   {

       #region Machine 

       public int SavaMachine(tblMachineMSTDTO tblMachineMSTDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblMachineMSTDTO.MachineID == 0)
                {
                    if (loomsManagementEntity.tblMachineMSTs.Where(m => m.MachineName == tblMachineMSTDTO.MachineName && m.IsDelete == false).ToList().Count() > 0)
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

        public  List<tblMachineMSTDTO> GetAllMachineDetails()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblMachineMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public  tblMachineMSTDTO GetMachineDetails(int MachineId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblMachineMSTs.Where(m => m.MachineID == MachineId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteMachine(int MachineId)
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

       #endregion

       #region Machine Type

        public int SavaMachineType(tblMachineTypeMSTDTO tblMachineTypeMSTDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblMachineTypeMSTDTO.MachineTypeID == 0)
                {
                    if (loomsManagementEntity.tblMachineTypeMSTs.Where(m => m.TypeName == tblMachineTypeMSTDTO.TypeName && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblMachineTypeMST objMachineType = tblMachineTypeMSTDTO.ToEntity();
                        loomsManagementEntity.tblMachineTypeMSTs.Add(objMachineType);
                    }
                }
                else
                {
                    if (loomsManagementEntity.tblMachineTypeMSTs.Where(m => m.TypeName == tblMachineTypeMSTDTO.TypeName && m.MachineTypeID != tblMachineTypeMSTDTO.MachineTypeID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblMachineTypeMST objMachineType = loomsManagementEntity.tblMachineTypeMSTs.Where(m => m.MachineTypeID == tblMachineTypeMSTDTO.MachineTypeID && m.IsDelete == false).FirstOrDefault();
                        if (objMachineType != null)
                        {
                            objMachineType.MachineTypeID = tblMachineTypeMSTDTO.MachineTypeID;
                            objMachineType.TypeName = tblMachineTypeMSTDTO.TypeName;
                            objMachineType.Description = tblMachineTypeMSTDTO.Description;
                            objMachineType.UpdatedBy = tblMachineTypeMSTDTO.UpdatedBy;
                            objMachineType.UpdatedDateTime = tblMachineTypeMSTDTO.UpdatedDateTime;
                        }
                        else
                        {
                            return 2;
                        }

                    }
                }

                if (loomsManagementEntity.SaveChanges() > 0)
                    return 0;
                else
                    return 2;

            }
        }

        public  List<tblMachineTypeMSTDTO> GetAllMachineTypeDetails()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblMachineTypeMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public  tblMachineTypeMSTDTO GetMachineTypeDetails(int MachineTypeId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblMachineTypeMSTs.Where(m => m.MachineTypeID == MachineTypeId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteMachineType(int MachineTypeId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                tblMachineTypeMST objMachineType = loomsManagementEntity.tblMachineTypeMSTs.Where(m => m.MachineTypeID == MachineTypeId && m.IsDelete == false).FirstOrDefault();
                if (objMachineType != null)
                {
                    objMachineType.IsDelete = true;
                    if (loomsManagementEntity.SaveChanges() > 0)
                        return 0;
                    else
                        return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        #endregion

    }
}
