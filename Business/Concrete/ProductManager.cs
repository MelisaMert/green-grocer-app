using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Constants;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal productDal;
        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;      
        }
        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(productDal.Get(filter: p => p.Id == productId));
        }
        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(productDal.GetList().ToList());
        }
        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
          return new SuccessDataResult<List<Product>>(productDal.GetList(filter: p => p.CategoryId == categoryId).ToList());
        }
        public IResult Add(Product product)
        {
            productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }
        public IResult Delete(Product product)
        {
            productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }
        public IResult Update(Product product)
        {
            productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
