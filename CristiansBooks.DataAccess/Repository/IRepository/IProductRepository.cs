using CristiansBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristiansBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<ProductRepository>
    {
        void Update(ProductRepository product);
    }
}

