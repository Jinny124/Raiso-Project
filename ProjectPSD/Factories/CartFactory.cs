using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Factories
{
    public class CartFactory
    {
        

        public static Cart Create(int UserID, int stationeryID, int qty)
        {
            Cart cart = new Cart();

            cart.UserID = UserID;
            cart.StationeryID = stationeryID;
            cart.Quantity = qty;

            return cart;
        }
    }
}