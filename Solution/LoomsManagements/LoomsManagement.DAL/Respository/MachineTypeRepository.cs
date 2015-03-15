using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;

namespace LoomsManagement.DAL
{
   public class MachineTypeRepository
    {

       public int SavaMachineTypeData(tblMachineTypeMSTDTO tblMachineTypeMSTDTO)
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
                    if(loomsManagementEntity.tblMachineTypeMSTs.Where(m=>m.TypeName==tblMachineTypeMSTDTO.TypeName && m.MachineTypeID!=tblMachineTypeMSTDTO.MachineTypeID && m.IsDelete==false).ToList().Count()>0)
                       {
                           return 1;
                       }
                       else
                       {
                           tblMachineTypeMST objMachineType= loomsManagementEntity.tblMachineTypeMSTs.Where(m=>m.MachineTypeID==tblMachineTypeMSTDTO.MachineTypeID && m.IsDelete==false).FirstOrDefault();
                           if(objMachineType!=null)
                           {
                               objMachineType.MachineTypeID=tblMachineTypeMSTDTO.MachineTypeID;
                               objMachineType.TypeName=tblMachineTypeMSTDTO.TypeName;
                               objMachineType.Description=tblMachineTypeMSTDTO.Description;
                               objMachineType.UpdatedBy=tblMachineTypeMSTDTO.UpdatedBy;
                               objMachineType.UpdatedDateTime=tblMachineTypeMSTDTO.UpdatedDateTime;
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
       
       public static List<tblMachineTypeMSTDTO> GetAllMachineTypeDate()
       {
           using (var loomsManagementEntity = new LoomsManagementEntities())
           {
               return loomsManagementEntity.tblMachineTypeMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
           }
       }

       public static tblMachineTypeMSTDTO GetMachineTypeData(int MachineTypeId)
       {
           using (var loomsManagementEntity = new LoomsManagementEntities())
           {
               return loomsManagementEntity.tblMachineTypeMSTs.Where(m => m.MachineTypeID == MachineTypeId && m.IsDelete == false).FirstOrDefault().ToDTO();
           }
       }

       public int DeleteMachineTypeData(int MachineTypeId)
       {
           using (var loomsManagementEntity = new LoomsManagementEntities())
           {
               tblMachineTypeMST objMachineType = loomsManagementEntity.tblMachineTypeMSTs.Where(m=>m.MachineTypeID==MachineTypeId && m.IsDelete==false).FirstOrDefault();
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

    }
}
