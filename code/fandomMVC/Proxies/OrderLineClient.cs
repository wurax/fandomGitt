using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Contracts;

namespace Proxies
{
    public class OrderLineClient : ClientBase<IOrderLineService>, IOrderLineService
    {
        public void deleteOrderLine(OrderLineData orderline)
        {
            Channel.deleteOrderLine(orderline);
        }

        public IEnumerable<OrderLineData> findorderLineByOrderId(int orderID)
        {
            return Channel.findorderLineByOrderId(orderID);
        }

        public IEnumerable<OrderLineData> findOrderLinesByProductID(int productID)
        {
            return Channel.findorderLineByOrderId(productID);
        }

        public void InsertOrderLine(OrderLineData orderline)
        {
            Channel.InsertOrderLine(orderline);
        }

        public void insertOrderLines(IEnumerable<OrderLineData> orderline)
        {
            Channel.insertOrderLines(orderline);
        }

        public void UpdateOrderLine(OrderLineData orderline)
        {
        Channel.UpdateOrderLine(orderline);
        }
    }
}
