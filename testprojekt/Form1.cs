using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BL.Controllers;

namespace testprojekt
{
    public partial class Form1 : Form
    {
        CategoryController categoryController;
        public Form1()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            getCategories();
        }

        public void getCategories()
        {
            catList.Items.Clear();
            //catList.Items.Add("grej");

            foreach (var item in categoryController.getAllCategories())
            {
                if (item != null)
                {
                    //var listViewItem = new ListViewItem(item.Name);
                    //catList.Items.Add(listViewItem);
                    catList.Items.Add(item.Name);
                    
                }
            }
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //lägg till ny pod
            //PodController.CreatePod(txtPodName.Text, textBoxUrl.Text, comboBoxFreq.SelectedItem, comboBoxCat.SelectedItem);
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            //uppdatera kategori i xml
            //getCategories();
        }

        private void btnNewCat_Click(object sender, EventArgs e)
        {
            //lägg ny kategori i xml
            //behövs validering
            categoryController.createCategory(txtCategory.Text);
            getCategories();
        }

        private void catList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tror inte denna behövs (action när man trycker på en kategori i listan)
        }
    }
}
