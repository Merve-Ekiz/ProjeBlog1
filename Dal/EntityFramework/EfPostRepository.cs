using Dal.Abstract;
using Dal.Concreate;
using Dal.Repository;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.EntityFramework
{
    public class EfPostRepository : GenericRepository<Post>, IPostDal
    {
        public List<Post> GetlistWithCategory()
        {
            using (var c=new Context())
            {
                return c.Posts.Include(x => x.Category).ToList();
            }
        }
    }
}
