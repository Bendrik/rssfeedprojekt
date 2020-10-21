using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository<Category>
    {
        DataManager dataManager;
        List<Category> categoryList;

        public CategoryRepository()
        {
            categoryList = new List<Category>();
            dataManager = new DataManager();
            categoryList = GetAll();
        }
        public void Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            List<Category> categoryListReturn = new List<Category>();
            categoryListReturn = DataManager.Deserialize();
            return categoryListReturn;
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(int index, Category newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
