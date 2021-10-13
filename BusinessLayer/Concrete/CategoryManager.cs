using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly BlogContext _context;
        public CategoryManager(BlogContext context)
        {
            _context = context;
        }
        public void AddCategory(Category category)
        {
                _context.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            _context.Remove(category);
        }

        public Category GetById(int id)
        {
            return _context.Set<Category>().Find(id);
        }

        public List<Category> GetList()
        {
            return _context.Set<Category>().ToList();
        }

        public void UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }
    }
}
