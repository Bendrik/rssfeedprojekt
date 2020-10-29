using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repositories;
using System.Collections.Specialized;
using System.Windows.Forms;

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
        public int getCatIndex(string name)
        {
            int index = categoryRepository.GetIndexOfName(name);
            return index;
        }

        public void removeCategory(string name)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort " + name + "?", "Bekräfta", MessageBoxButtons.YesNo);

            
            if (dialogResult == DialogResult.Yes)
            {
                int index = categoryRepository.GetIndexOfName(name);
                categoryRepository.Delete(index);
            }
            else if (dialogResult == DialogResult.No)
            {

            }                                 
        }
    }
}
