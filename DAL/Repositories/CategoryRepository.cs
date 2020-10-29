using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Exceptions;
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
            categoryList.RemoveAt(index);
            SaveChanges();
        }

        public List<Category> GetAll()
        {

            List<Category> categoryListReturn = new List<Category>();

            try
            {
                if (categoryListReturn != null)
                {
                    categoryListReturn = dataManager.Deserialize();
                }
            }
            catch (SerializerException)
            {
                Console.WriteLine("kunde inte deserialize:a category.xml");
            }


            return categoryListReturn;

        }

        public int GetIndexOfName(string name)
        {
            return GetAll().FindIndex(e => e.Name.Equals(name));
        }

        public void SaveChanges()
        {
            try
            {
                dataManager.Serialize(categoryList);
            }
            catch (SerializerException)
            {
                Console.WriteLine("kunde inte serialize:a category.xml");
            }
        }

        public void Update(int index, Category newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
