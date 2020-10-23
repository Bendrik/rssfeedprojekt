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
        PodController podController;
        public Form1()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            podController = new PodController();
            getCategories();
        }

        public void getCategories()
        {
            catList.Items.Clear();
            comboBoxCat.Items.Clear();

            foreach (var item in categoryController.getAllCategories())
            {
                if (item != null)
                {
                    catList.Items.Add(item.Name);
                    comboBoxCat.Items.Add(item.Name);
                }
            }
            comboBoxCat.SelectedIndex = 0;
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //lägg till ny pod
            podController.CreatePod(txtPodName.Text, textBoxUrl.Text, comboBoxFreq.SelectedItem.ToString(), comboBoxCat.SelectedItem.ToString());
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

        private void comboBoxFreq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
