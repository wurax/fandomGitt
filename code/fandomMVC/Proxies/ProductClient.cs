﻿using System;
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
        public IEnumerable<ProductData> GetlikeProdctNames(string name)
        {
            return Channel.GetlikeProdctNames(name);
        }

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

        public void setVisibleTofalse(ProductData productData)
        {
            Channel.setVisibleTofalse(productData);
        }

        public void setVisibleTotrue(ProductData productData)
        {
            Channel.setVisibleTotrue(productData);
        }

        public void updateProduct(ProductData productData)
        {
            Channel.updateProduct(productData);
        }
    }
}
