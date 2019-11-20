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
        [OperationContract]
        void Insertproduct(ProductData productData);

        void RemoveProduct(ProductData productData);

        void updateProduct(ProductData productData);
    }
}
