﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayerrr
{
   public class OrderDB : IOrderDB
    {
        fandomDBDataContext db = new fandomDBDataContext();
        public void deleteOrder(Order order)
        {
            db.Orders.DeleteOnSubmit(order);
            db.SubmitChanges();
        }

        public void updateOrder(Order order)
        {
            var Order1 = db.Orders.SingleOrDefault(O => O.orderID == order.orderID);

            Order1.invoiceDate = order.invoiceDate;
            Order1.invoiceDueDate = order.invoiceDueDate;
            Order1.orderStatusID = order.orderStatusID;
            db.SubmitChanges();
        }


        public Order findOrderById(int id)
        {
            var orders = db.Orders;
            var order = (from o in orders where o.orderID == id select o).SingleOrDefault();
            return order;            
        }

        public void insertOrder(Order order)
        {
            db.Orders.InsertOnSubmit(order);
            db.SubmitChanges();
        }
        
        public IEnumerable<Order> OrdersByProductId(int id)
        {
            return null;
            /*
            var orders = db.Orders;
            var orderss = (from o in orders select o).AsEnumerable();
            var oderlines = db.OrderLines;

            
            List<Order> orders1 = new List<Order>();
            foreach (var order in orderss)
            {
             foreach (OrderLine orderline in order.OrderLines)
                {
                    orderline.productID.GetValue == id;
                }

          }*/
        } 
        

    
    }
}
