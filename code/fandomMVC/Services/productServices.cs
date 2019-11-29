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

        public ProductData GetProductByID(int ID)
        {

            ProductData productData = null;
            IProductDB productDB = _productDB ?? new ProductDB();
            Product productEntity = productDB.getProductByID(ID);
            if (productEntity != null)
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

        public ProductData GetProductByName(string Name)
        {
            ProductData productData = null;
            IProductDB productDB = _productDB ?? new ProductDB();
            Product productEntity = productDB.GetProductByName(Name);
            if (productEntity != null)
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

        public List<ProductData> GetProducts()
        {
            List<ProductData> productsData = new List<ProductData>();
            IEnumerable<Product> data = null; 
            IProductDB productDB = _productDB ?? new ProductDB();
            data = productDB.GetProducts();
            if(data !=null)
            {
                foreach (var product in data)
                {
                   ProductData productData = new ProductData();
                    productData.productName = product.productName;
                    productData.productID = product.productID;
                    productData.productDescription = product.productDescription;
                    productData.quantity = product.quantity;
                    productData.supplierID = product.supplierID;
                    productData.price = product.price;
                    productsData.Add(productData);
                }
            }
            return productsData;
        }


        // ask  michael how to test
        public void Insertproduct(ProductData productData)
        {
            IProductDB productDB = _productDB ?? new ProductDB();
            Product Insertingproduct = new Product();
            ProductData check = GetProductByID(productData.productID);
            if (productData != null && check == null)
            {
                Insertingproduct.productName = productData.productName;
                Insertingproduct.productID = productData.productID;
                Insertingproduct.price = productData.price;
                Insertingproduct.quantity = productData.quantity;
                Insertingproduct.productDescription = productData.productDescription;
                Insertingproduct.supplierID = productData.supplierID;
                // need refactoring
                Insertingproduct.Stocks = new System.Data.Linq.EntitySet<Stock>();
                Insertingproduct.Locations = new System.Data.Linq.EntitySet<Location>();
                Insertingproduct.OrderLines = new System.Data.Linq.EntitySet<OrderLine>();
                Insertingproduct.ProdPropertyValues = new System.Data.Linq.EntitySet<ProdPropertyValue>();
                Insertingproduct.ProductFandoms = new System.Data.Linq.EntitySet<ProductFandom>();
                Insertingproduct.Supplier = new Supplier();
                productDB.insertProduct(Insertingproduct);
            }


        }

        public void RemoveProduct(ProductData productData)
        {
            IProductDB productDB = _productDB ?? new ProductDB();
            Product removeProduct = new Product();
            ProductData check = GetProductByID(productData.productID);
            if (productData != null && check != null)
            {
                removeProduct.productName = productData.productName;
                removeProduct.productID = productData.productID;
                removeProduct.price = productData.price;
                removeProduct.quantity = productData.quantity;
                removeProduct.productDescription = productData.productDescription;
                removeProduct.supplierID = productData.supplierID;
                // need refactoring
                removeProduct.Stocks = new System.Data.Linq.EntitySet<Stock>();
                removeProduct.Locations = new System.Data.Linq.EntitySet<Location>();
                removeProduct.OrderLines = new System.Data.Linq.EntitySet<OrderLine>();
                removeProduct.ProdPropertyValues = new System.Data.Linq.EntitySet<ProdPropertyValue>();
                removeProduct.ProductFandoms = new System.Data.Linq.EntitySet<ProductFandom>();
                removeProduct.Supplier = new Supplier();
                productDB.removeProduct(removeProduct);
            }
        }

        public void updateProduct(ProductData productData)
        {
            IProductDB productDB = _productDB ?? new ProductDB();
            Product updateproduct = new Product();
            ProductData check = GetProductByID(productData.productID);
            if (productData != null && check != null)
            {
                updateproduct.productName = productData.productName;
                updateproduct.productID = productData.productID;
                updateproduct.price = productData.price;
                updateproduct.quantity = productData.quantity;
                updateproduct.productDescription = productData.productDescription;
                updateproduct.supplierID = productData.supplierID;
                // need refactoring
                updateproduct.Stocks = new System.Data.Linq.EntitySet<Stock>();
                updateproduct.Locations = new System.Data.Linq.EntitySet<Location>();
                updateproduct.OrderLines = new System.Data.Linq.EntitySet<OrderLine>();
                updateproduct.ProdPropertyValues = new System.Data.Linq.EntitySet<ProdPropertyValue>();
                updateproduct.ProductFandoms = new System.Data.Linq.EntitySet<ProductFandom>();
                updateproduct.Supplier = new Supplier();
                productDB.UpdateProduct(updateproduct);
            }
        }
    }
}
