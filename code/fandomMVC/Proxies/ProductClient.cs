using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Contracts;

namespace Proxies
{
     public class ProductClient : ClientBase<IProductService>, IProductService
    {
        public ProductData GetProductByID(int ID)
        {
            return Channel.GetProductByID(ID);
        }

        public ProductData GetProductByName(string Name)
        {
            return Channel.GetProductByName(Name);
        }

        public List<ProductData> GetProducts()
        {
            return Channel.GetProducts();
        }

        public void Insertproduct(ProductData productData)
        {
            Channel.Insertproduct(productData);
        }

        public void RemoveProduct(ProductData productData)
        {
            Channel.RemoveProduct(productData);
        }

<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 371b918... Order
        public void setViasableTofalse(ProductData productData)
        {
            Channel.setViasableTofalse(productData);
        }

        public void setViasableTotrue(ProductData productData)
        {
            Channel.setViasableTotrue(productData);
        }

>>>>>>> parent of 371b918... Order
        public void updateProduct(ProductData productData)
        {
            Channel.updateProduct(productData);
        }
    }
}
