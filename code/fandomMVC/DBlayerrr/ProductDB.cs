
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayerrr
{
   public class ProductDB  : IProductDB
    {
        fandomDBDataContext db = new fandomDBDataContext();
        public void insertProduct(Product Product)
        {
            db.Products.InsertOnSubmit(Product);
            db.SubmitChanges();
        }

        public Product getProductByID(int id)
        {
            var products = db.Products;
            Product firstproduct = (from a in products
                                    where a.productID == id
                                    select a).SingleOrDefault();
            return firstproduct;
            
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = db.Products;
            var productss = (from p in products select p).AsEnumerable();
            return productss;

        }

        public void removeProduct(Product product)
        {
            db.Products.DeleteOnSubmit(product);
            db.SubmitChanges();
        }

        //need human test
        public void UpdateProduct(Product product)
        {
            Product product1 = db.Products.SingleOrDefault(p => p.productID == product.productID);

            product1.price = product.price;
            product1.productName = product.productName;
            product1.productDescription = product.productDescription;
            product1.supplierID = product.supplierID;
            product1.quantity = product.quantity;

            db.SubmitChanges();


            

        }

        public Product GetProductByName(string name)
        {
            var products = db.Products;
            Product firstproduct = (from a in products
                                    where a.productName == name
                                    select a).SingleOrDefault();
            return firstproduct;
        }
<<<<<<< HEAD
=======

        public void productToUnviasable(Product product)
        {
            Product product1 = db.Products.SingleOrDefault(p => p.productID == product.productID);

            product1.visible = false;
            db.SubmitChanges();
        }

        public void productToviasble(Product product)
        {
            Product product1 = db.Products.SingleOrDefault(p => p.productID == product.productID);

            product1.visible = true;
            db.SubmitChanges();
        }

        public IEnumerable<Product> GetlikeProdctNames(string name)
        {
            var products = db.Products;
            var productss = (from p in products where p.productName.IndexOf(name)>= 0 select p).AsEnumerable();
            return productss;
        }
>>>>>>> parent of 371b918... Order
    }
}