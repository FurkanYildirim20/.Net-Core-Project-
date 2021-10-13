using DataAccessLayer;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using Project.DataAccessLayer.Abstract;

namespace Project.DataAccessLayer.Concrete
{
    public class EfBlogDal : GenericRepository<Blog, BlogContext>, IBlogDal
    {
        public EfBlogDal(BlogContext context) : base(context)
        {

        }
    }
}
