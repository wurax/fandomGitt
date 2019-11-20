using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Contracts
{
        [ServiceContract]
        public interface IProductService
    {
        [OperationContract]
        ProductData GetProductName(int ID);
    }
}
