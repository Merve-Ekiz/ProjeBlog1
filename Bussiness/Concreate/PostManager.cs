using Bussiness.Abstract;
using Dal.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concreate
{
    public class PostManager : IPostService
    {
        IPostDal _postdal;

        public PostManager(IPostDal postdal)
        {
            _postdal = postdal;
        }

        public List<Post> Getlist()
        {
            return _postdal.GetListAll();
        }

        public Post GetlistById(int id)
        {
            return _postdal.GetById(id);
        }

        public List<Post> GetPostListWithCategory()
        {
            return _postdal.GetlistWithCategory();
        }

        public void TAdd(Post t)
        {
            _postdal.Insert(t);
        }

        public void TDelete(Post t)
        {
            _postdal.Delete(t);
        }

        public void TUpdate(Post t)
        {
            _postdal.Update(t);
        }
        public List<Post>GetPostById(int id)
        {
            return _postdal.GetListAll(x => x.PostId == id);
        }
    }
}
