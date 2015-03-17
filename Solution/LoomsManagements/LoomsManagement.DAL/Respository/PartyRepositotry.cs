using LoomsManagement.DAL.ORM;
using LoomsManagement.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoomsManagement.DAL
{
    public class PartyRepositotry
    {
        #region Party Master

        public int SaveParty(tblPartysMSTDTO tblPartyMSTDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblPartyMSTDTO.PartyID == 0)
                {
                    if (loomsManagementEntity.tblPartysMSTs.Where(m => m.PartyName == tblPartyMSTDTO.PartyName && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }

                    tblPartysMST objPartyMST = tblPartyMSTDTO.ToEntity();
                    loomsManagementEntity.tblPartysMSTs.Add(objPartyMST);
                }
                else
                {
                    if (loomsManagementEntity.tblPartysMSTs.Where(m => m.PartyName == tblPartyMSTDTO.PartyName && m.PartyID != tblPartyMSTDTO.PartyID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblPartysMST objPartyMst = loomsManagementEntity.tblPartysMSTs.Where(m => m.PartyID == tblPartyMSTDTO.PartyID && m.IsDelete == false).FirstOrDefault();
                        if (objPartyMst != null)
                        {
                            objPartyMst.PartyID = tblPartyMSTDTO.PartyID;
                            objPartyMst.PartyName = tblPartyMSTDTO.PartyName;
                            objPartyMst.CompanyCode = tblPartyMSTDTO.CompanyCode;
                            objPartyMst.City = tblPartyMSTDTO.City;
                            objPartyMst.ContactPersonName = tblPartyMSTDTO.ContactPersonName;
                            objPartyMst.CreationDateTime = tblPartyMSTDTO.CreationDateTime;
                            objPartyMst.CSTDate = tblPartyMSTDTO.CSTDate;
                            objPartyMst.CSTTINNo = tblPartyMSTDTO.CSTTINNo;
                            objPartyMst.ECCNo = tblPartyMSTDTO.ECCNo;
                            objPartyMst.EmailID = tblPartyMSTDTO.EmailID;
                            objPartyMst.ExtraDetails = tblPartyMSTDTO.ExtraDetails;
                            objPartyMst.MobileNo = tblPartyMSTDTO.MobileNo;
                            objPartyMst.OfficeAddress = tblPartyMSTDTO.OfficeAddress;
                            objPartyMst.PANNO = tblPartyMSTDTO.PANNO;
                            objPartyMst.PhoneNo = tblPartyMSTDTO.PhoneNo;
                            objPartyMst.ReferencePersonMobileNo = tblPartyMSTDTO.ReferencePersonMobileNo;
                            objPartyMst.ReferencePersonName = tblPartyMSTDTO.ReferencePersonName;
                            objPartyMst.ShippingAddress = tblPartyMSTDTO.ShippingAddress;
                            objPartyMst.SMSNo = tblPartyMSTDTO.SMSNo;
                            objPartyMst.State = tblPartyMSTDTO.State;
                            objPartyMst.TINDate = tblPartyMSTDTO.TINDate;
                            objPartyMst.TINNo = tblPartyMSTDTO.TINNo;
                            objPartyMst.UpdateBy = tblPartyMSTDTO.UpdateBy;
                            objPartyMst.UpdationDateTIme = tblPartyMSTDTO.UpdationDateTIme;
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

        public List<tblPartysMSTDTO> GetAllPartyDetails()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblPartysMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public tblPartysMSTDTO GetPartyDetails(int PartyId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblPartysMSTs.Where(m => m.PartyID == PartyId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteParty(int PartyId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                tblPartysMST objPartyMst = loomsManagementEntity.tblPartysMSTs.Where(m => m.PartyID == PartyId && m.IsDelete == false).FirstOrDefault();
                if (objPartyMst != null)
                {
                    objPartyMst.IsDelete = true;
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

        #region Broker Master

        public int SaveBroker(tblBrokersMSTDTO tblBrokersMSTDTO)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                if (tblBrokersMSTDTO.BrokerID == 0)
                {
                    if (loomsManagementEntity.tblBrokersMSTs.Where(m => m.BrokerName == tblBrokersMSTDTO.BrokerName && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }

                    tblBrokersMST objBrokerMst = tblBrokersMSTDTO.ToEntity();
                    loomsManagementEntity.tblBrokersMSTs.Add(objBrokerMst);
                }
                else
                {
                    if (loomsManagementEntity.tblBrokersMSTs.Where(m => m.BrokerName == tblBrokersMSTDTO.BrokerName && m.BrokerID != tblBrokersMSTDTO.BrokerID && m.IsDelete == false).ToList().Count() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        tblBrokersMST objBrokerMst = loomsManagementEntity.tblBrokersMSTs.Where(m => m.BrokerID == tblBrokersMSTDTO.BrokerID && m.IsDelete == false).FirstOrDefault();
                        if (objBrokerMst != null)
                        {
                            objBrokerMst.BrokerID = tblBrokersMSTDTO.BrokerID;
                            objBrokerMst.BrokerName = tblBrokersMSTDTO.BrokerName;
                            objBrokerMst.BrokerFirmName = tblBrokersMSTDTO.BrokerFirmName;
                            objBrokerMst.ContactNo = tblBrokersMSTDTO.ContactNo;
                            objBrokerMst.MobileNo = tblBrokersMSTDTO.MobileNo;
                            objBrokerMst.CreationDateTime = tblBrokersMSTDTO.CreationDateTime;
                            objBrokerMst.Address = tblBrokersMSTDTO.Address;
                            objBrokerMst.DealingIn = tblBrokersMSTDTO.DealingIn;
                            objBrokerMst.UpdateBy = tblBrokersMSTDTO.UpdateBy;
                            objBrokerMst.UpdationDateTime = tblBrokersMSTDTO.UpdationDateTime;
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

        public List<tblBrokersMSTDTO> GetAllBrokerDetails()
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblBrokersMSTs.Where(m => m.IsDelete == false).ToList().ToDTOs();
            }
        }

        public tblBrokersMSTDTO GetBrokerDetails(int BrokerId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                return loomsManagementEntity.tblBrokersMSTs.Where(m => m.BrokerID == BrokerId && m.IsDelete == false).FirstOrDefault().ToDTO();
            }
        }

        public int DeleteBroker(int BrokerId)
        {
            using (var loomsManagementEntity = new LoomsManagementEntities())
            {
                tblBrokersMST objBrokerMst = loomsManagementEntity.tblBrokersMSTs.Where(m => m.BrokerID == BrokerId && m.IsDelete == false).FirstOrDefault();
                if (objBrokerMst != null)
                {
                    objBrokerMst.IsDelete = true;
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
