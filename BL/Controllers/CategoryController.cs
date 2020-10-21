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
            return CategoryRepository.GetAll();
        }
    }
}
