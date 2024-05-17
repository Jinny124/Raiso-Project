using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Models;

namespace Project_PSD.Repository
{
    //Stationery Repository
    public class RaisoRepository
    {
        RAisoEntities1 db = Singleton.GetInstance();

        public List<MsStationery> GetStationeries()
        {
            return(from MsStationery in db.MsStationeries select MsStationery).ToList();
        }

        public MsStationery findID_Stationery(int stationeryID)
        {
            return (from MsStationery in db.MsStationeries
                    where MsStationery.StationeryID == stationeryID
                    select MsStationery).FirstOrDefault();
        }

    }
}