using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Models;

namespace Project_PSD.Factories
{
    public class StationeryFactory
    {
        public static MsStationery Create(int stationeryId, String  staioneryName, int stationeryPrice )
        {
            MsStationery stationery = new MsStationery();

            stationery.StationeryID = stationeryId;
            stationery.StationeryName = staioneryName;
            stationery.StationeryPrice = stationeryPrice;

            return stationery;
        }
    }
}