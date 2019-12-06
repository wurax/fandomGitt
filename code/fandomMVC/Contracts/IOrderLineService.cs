using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IOrderLineService
    {
        [OperationContract]
        void InsertOrderLine(OrderLineData orderline);
        [OperationContract]
        void insertOrderLines(IEnumerable<OrderLineData> orderline);
        [OperationContract]
        void deleteOrderLine(OrderLineData orderline);
        [OperationContract]
        void UpdateOrderLine(OrderLineData orderline);
        [OperationContract]
        IEnumerable<OrderLineData> findOrderLinesByProductID(int productID);
        [OperationContract]
        IEnumerable<OrderLineData> findorderLineByOrderId(int orderID);
      
            


 
    }
}
