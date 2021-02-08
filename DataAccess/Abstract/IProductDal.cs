using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Interface'in kendisi public değildir ama içindeki fonksiyonlar publictir.Bu yüzden fonksiyonların başına ğublic yazılmaz ancak interface'in başına yazılır.
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails(); 
    }
}
