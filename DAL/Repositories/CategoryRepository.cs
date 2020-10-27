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
        DataManagerCategory dataManager;
        List<Category> categoryList;

        public CategoryRepository()
        {
            categoryList = new List<Category>();
            dataManager = new DataManagerCategory();
            categoryList = GetAll();
        }
        public void Create(Category entity)
        {
            categoryList.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {

            List<Category> categoryListReturn = new List<Category>();
            if (categoryListReturn != null)
            {
                categoryListReturn = dataManager.Deserialize();
            }
            return categoryListReturn;

        }

        public void SaveChanges()
        {

            try
            {
                dataManager.Serialize(categoryList);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(int index, Category newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
