using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);//şu fiyat aralığında olan ürünleri getir.
        IDataResult< List<ProductDetailDto>> GetProductDetails();
        IDataResult< Product> GetById(int productId);//sadece product döndürür.Sadece ilgili ürünün detayı.
        IResult Add(Product product);

    
    }
}
