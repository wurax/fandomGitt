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

    }
}
