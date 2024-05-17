using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Models;

namespace Project_PSD.Repository
{
    public class CartRepository
    {
        RAisoEntities1 db = Singleton.GetInstance();

        public List<Cart> GetCart()
        {
            return(from Cart in db.Carts select Cart).ToList();
        }

        public Cart findId_cart(int userID, int stnID)
        {
            return (from Cart in db.Carts
                    where Cart.UserID == userID && Cart.StationeryID == stnID
                    select Cart
                   ).FirstOrDefault();
        }
    }
}