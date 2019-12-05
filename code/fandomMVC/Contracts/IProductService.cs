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
        ProductData GetProductByID(int ID);
        [OperationContract]
        void Insertproduct(ProductData productData);
        [OperationContract]
        void RemoveProduct(ProductData productData);
        [OperationContract]
        void updateProduct(ProductData productData);
        [OperationContract]
        List<ProductData> GetProducts();
        [OperationContract]
        ProductData GetProductByName(string Name);
<<<<<<< HEAD
=======
        [OperationContract]
        void setViasableTofalse(ProductData productData);
        [OperationContract]
        void setViasableTotrue(ProductData productData);
        [OperationContract]
        IEnumerable<ProductData> GetlikeProdctNames(string name);
>>>>>>> parent of 371b918... Order
    }
}
