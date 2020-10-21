using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repositories;

namespace BL.Controllers
{
    public class CategoryController
    {
        IRepository<Category> categoryRepository;
        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }

        public List<Category> getAllCategories()
        {
            return categoryRepository.GetAll();
        }

        public void createCategory(string name)
        {
            Category newCategory = new Category(name);
            categoryRepository.Create(newCategory);
        }
    }
}
