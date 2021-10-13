using DataAccessLayer;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using Project.DataAccessLayer.Abstract;

namespace Project.DataAccessLayer.Concrete
{
    public class EfCommentDal : GenericRepository<Comment, BlogContext>, ICommentDal
    {
        public EfCommentDal(BlogContext context) : base(context)
        {

        }
    }
}
