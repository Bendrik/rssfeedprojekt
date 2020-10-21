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
        public Form1()
        {
            InitializeComponent();
            getCategories();
        }

        public void getCategories()
        {
            catList.Items.Clear();
            //catList.Items.Add("grej");
            //CategoryController.getAllCategories();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //PodController.CreatePod(textBoxUrl.Text, comboBoxFreq.SelectedItem, comboBoxCat.SelectedItem);
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            //uppdatera kategori i xml
            //getCategories();
        }

        private void btnNewCat_Click(object sender, EventArgs e)
        {
            //lägg ny kategori i xml
            //getCategories();
        }

        private void catList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tror inte denna behövs (action när man trycker på en kategori i listan)
        }
    }
}
