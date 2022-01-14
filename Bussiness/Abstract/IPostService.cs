﻿using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IPostService : IGenericService<Post>
    {
        List<Post> GetPostListWithCategory();
    }
}
