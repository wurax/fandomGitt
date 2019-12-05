using Contracts;
using DBlayerrr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services 
{
  public  class OrderService : IOrderService
       
    {
        IOrderDB _OrderDB = null;
        public void deleteOrder(OrderData order)
        {
            IOrderDB orderDB = _OrderDB ?? new OrderDB();
            Order deleteOrder = new Order();
            Order check = orderDB.findOrderById(order.orderID);
        if (order != null && check != null)
            {
                deleteOrder.orderID = order.orderID;
                deleteOrder.invoiceDate = order.invoiceDate;
                deleteOrder.invoiceDueDate = order.invoiceDueDate;
                deleteOrder.paymentID = order.paymentID;
                deleteOrder.orderStatusID = order.orderStatusID;
                // need refactoring
                deleteOrder.OrderLines = new System.Data.Linq.EntitySet<OrderLine>();
                orderDB.deleteOrder(deleteOrder);

            }
        
        }

        public OrderData findOrderById(int id)
        {
            OrderData orderdata = null;
            IOrderDB orderDB = _OrderDB ?? new OrderDB();
            Order orderEntity = orderDB.findOrderById(id);
            if (orderEntity != null)
            {
                orderdata = new OrderData();
                orderdata.orderID = orderEntity.orderID;
                orderdata.invoiceDate = orderEntity.invoiceDate;
                orderdata.invoiceDueDate = orderEntity.invoiceDueDate;
                orderdata.paymentID = orderEntity.paymentID;
                orderdata.orderStatusID = orderEntity.orderStatusID;
            }
            return orderdata;
        }

        public void InsertOrder(OrderData order)
        {
            IOrderDB orderDB = _OrderDB ?? new OrderDB();
            Order insertOrder = new Order();
            Order check = orderDB.findOrderById(order.orderID);
            if (order != null && check == null)
            {
                insertOrder.orderID = order.orderID;
                insertOrder.invoiceDate = order.invoiceDate;
                insertOrder.invoiceDueDate = order.invoiceDueDate;
                insertOrder.paymentID = order.paymentID;
                insertOrder.orderStatusID = order.orderStatusID;
                // need refactoring
                insertOrder.OrderLines = new System.Data.Linq.EntitySet<OrderLine>();
                orderDB.insertOrder(insertOrder);
            }
        }

        public void updateOrder(OrderData order)
        {
            IOrderDB orderDB = _OrderDB ?? new OrderDB();
            Order updateOrder = new Order();
            Order check = orderDB.findOrderById(order.orderID);
            if (order != null && check == null)
            {
                updateOrder.orderID = order.orderID;
                updateOrder.invoiceDate = order.invoiceDate;
                updateOrder.invoiceDueDate = order.invoiceDueDate;
                updateOrder.paymentID = order.paymentID;
                updateOrder.orderStatusID = order.orderStatusID;
                // need refactoring
                orderDB.updateOrder(updateOrder);
            }

        }
    }
}
