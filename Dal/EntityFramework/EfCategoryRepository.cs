using Dal.Abstract;
using Dal.Repository;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.EntityFramework
{
    public class EfCategoryRepository:GenericRepository<Category>,ICategoryDal
    {
    }
}
