
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
    }
}