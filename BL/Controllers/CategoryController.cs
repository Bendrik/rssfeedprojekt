using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repositories;
using DAL;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace BL.Controllers
{
    public class CategoryController
    {
        IRepository<Category> categoryRepository;
        Validering validering;
        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
            validering = new Validering();
        }

        public List<Category> getAllCategories()
        {
            return categoryRepository.GetAll();
        }

        public void createCategory(string name)
        {
            if (validering.textEmpty(name))
            {
                Category newCategory = new Category(name);
                categoryRepository.Create(newCategory);
            }
            else
            {
                MessageBox.Show("Kategorin måste ha ett namn");
            }
        }

        public int getCatIndex(string name)
        {
            int index = categoryRepository.GetIndexOfName(name);
            return index;
        }

        public bool removeCategory(string name)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort " + name + "?", "Bekräfta", MessageBoxButtons.YesNo);


            if (dialogResult == DialogResult.Yes)
            {
                int index = categoryRepository.GetIndexOfName(name);
                categoryRepository.Delete(index);
                return true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return false;
            }
            return false;
        }
        public bool updateCategory(string name, string newName)
        {
            bool updated = false;
            if (validering.textEmpty(newName))
            {
                int index = getCatIndex(name);
                Category newCategory = new Category(newName);
                categoryRepository.Update(index, newCategory);
                updated = true;
            }
            else
            {
                MessageBox.Show("Kategorin måste ha ett namn");
                updated = false;
            }
            return updated;
        }
    }
}
