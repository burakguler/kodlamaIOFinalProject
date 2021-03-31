using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,ProductName="Lenovo V1",UnitPrice=15000,UnitsInStock=20},
                new Product{ProductId=2,ProductName="Lenovo V2",UnitPrice=17000,UnitsInStock=15},
                new Product{ProductId=3,ProductName="Lenovo V3",UnitPrice=19000,UnitsInStock=20},
                new Product{ProductId=4,ProductName="Lenovo V3",UnitPrice=21000,UnitsInStock=20}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {   
            //linq - language integrated query
            Product productToDelete = _products.SingleOrDefault(p=> p.ProductId == product.ProductId);  
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public void Update(Product product)
        {
            //find the sent product id in products list
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock; 
        }
    }
}
