﻿using System;
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
using System.Xml;
using System.ServiceModel.Syndication;

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
            fillFrequencyBox();
            getPods();
        }

        private void getCategories()
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

        private void fillFrequencyBox()
        {
            comboBoxFreq.Items.Clear();

            comboBoxFreq.Items.Add("Var 5:e minut");
            comboBoxFreq.Items.Add("Var 10:e minut");
            comboBoxFreq.Items.Add("Var 20:e minut");

            comboBoxFreq.SelectedIndex = 0;
        }

        private void getPods()
        {
            dataGridViewPodcast.Rows.Clear();
            foreach (var item in podController.getAllPods())
            {
                if (item != null)
                {
                    var episodeAmount = item.Episodes.Count().ToString();
                    dataGridViewPodcast.Rows.Add(item.Name, item.Category, item.Frequency, episodeAmount);
                }
            }
            dataGridViewPodcast.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //uppdatera pod
            
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

        private void btnNy_Click(object sender, EventArgs e)
        {
            podController.CreatePod(txtPodName.Text, textBoxUrl.Text, comboBoxFreq.SelectedItem.ToString(), comboBoxCat.SelectedItem.ToString());
            //podController.test();
        }

        private void podBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewPodcast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPodcast_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewEpisodes.Rows.Clear();

            //if (dataGridViewPodcast.SelectedItems.Count == 1)
            //{

                var selectedPod = "creepy";   //ska vara selected item

                foreach (var item in podController.getAllPods())
                {

                    if (item.Name.Equals(selectedPod))
                    {

                        foreach (var episodes in item.Episodes)
                        {

                            dataGridViewEpisodes.Rows.Add(episodes.Name);
                        }
                    
                    dataGridViewEpisodes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                }

                }
            //}
        }
    }
}
