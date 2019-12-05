using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayerrr
{
        public interface IProductDB
    {
        void insertProduct(Product Product);
        Product getProductByID(int id);
        IEnumerable<Product> GetProducts();

        void removeProduct(Product product);

        void UpdateProduct(Product product);

        Product GetProductByName(string name);

<<<<<<< HEAD
=======
        void productToUnviasable(Product product);

        void productToviasble(Product product);

        IEnumerable<Product> GetlikeProdctNames(string name);
>>>>>>> parent of 371b918... Order
    }
}
