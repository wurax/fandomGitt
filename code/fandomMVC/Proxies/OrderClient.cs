using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Proxies
{

     public class OrderClient : ClientBase<IOrderService>, IOrderService
    {
        public void deleteOrder(OrderData order)
        {
            Channel.deleteOrder(order);
        }

        public OrderData findOrderById(int id)
        {
            return Channel.findOrderById(id);
        }

        public void InsertOrder(OrderData order)
        {
            Channel.InsertOrder(order);
        }

        public void updateOrder(OrderData order)
        {
            Channel.updateOrder(order);
        }
    }
}
