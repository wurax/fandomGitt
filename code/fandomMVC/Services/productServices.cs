using Contracts;
using DBlayerrr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductServices : IProductService
    {
        IProductDB _productDB = null;
       public ProductServices()
        {
        }
       
        public ProductServices(IProductDB productDB)
        {
             this._productDB = productDB;
        }

        public ProductData GetProductName(int ID)
        {

            ProductData productData = null;
            IProductDB productDB = _productDB ?? new ProductDB();
            Product productEntity = productDB.getProductByID(ID);
            if (productEntity !=null)
            {
                productData = new ProductData();
                productData.productName = productEntity.productName;
                productData.productID = productEntity.productID;
                productData.productDescription = productEntity.productDescription;
                productData.quantity = productEntity.quantity;
                productData.supplierID = productEntity.supplierID;
                productData.price = productEntity.price;

                
            }
            return productData;
        }
    }
}
