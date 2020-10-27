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

            dataGridViewPodcast.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            dataGridViewEpisodes.Rows.Clear();
            lblEpisodeName.Text = "";
            episodeInfo.Text = "";

            foreach (var item in podController.getAllPods())
            {
                if (item != null)
                {
                    var episodeAmount = item.Episodes.Count().ToString();
                    dataGridViewPodcast.Rows.Add(item.Name, item.Category, item.Frequency, episodeAmount);
                }
            }
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string newName = txtPodName.Text;
            string newUrl = textBoxUrl.Text;
            string newFrequency = comboBoxFreq.SelectedItem.ToString();
            string newCategory = comboBoxCat.SelectedItem.ToString();

            string oldName = getSelectedPodName();

            int podIndex = podController.getPodIndex(oldName);

            podController.updatePod(newName, newUrl, newFrequency, newCategory, podIndex);


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
            getPods();
        }

        private void podBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewPodcast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getEpisodeDescription();
        }
        //private void dataGridViewEpisode_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    getEpisodeDescription();
        //}


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPodcast_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fillPodcastBoxes();
            getEpisodes();
        }
        private void dataGridViewPodcast_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillPodcastBoxes();
            getEpisodes();
        }

        private void fillPodcastBoxes()
        {
            //int selectedrowindex = dataGridViewPodcast.SelectedCells[0].RowIndex;
            //DataGridViewRow selectedRow = dataGridViewPodcast.Rows[selectedrowindex];
            //string selectedPod = Convert.ToString(selectedRow.Cells[0].Value);

            string selectedPod = getSelectedPodName();

            string selectedUrl = "";

            foreach (var onePod in podController.getAllPods())
            {
                if (onePod.Name.Equals(selectedPod))
                {
                    selectedUrl = onePod.PodUrl;
                }
            }


            txtPodName.Text = selectedPod;
            textBoxUrl.Text = selectedUrl;
        }

        private void getEpisodes()
        {


            dataGridViewEpisodes.Rows.Clear();
            lblEpisodeName.Text = "";
            episodeInfo.Text = "";

            //var selectedPod = "creepy";   //ska vara selected item
            string hej = dataGridViewPodcast.SelectedRows[0].Index.ToString();

            //int selectedrowindex = dataGridViewPodcast.SelectedCells[0].RowIndex;
            //DataGridViewRow selectedRow = dataGridViewPodcast.Rows[selectedrowindex];
            //string selectedPod = Convert.ToString(selectedRow.Cells[0].Value);

            string selectedPod = getSelectedPodName();

            foreach (var onePod in podController.getAllPods())
            {

                if (onePod.Name.Equals(selectedPod))
                {

                    foreach (var episodes in onePod.Episodes)
                    {

                        dataGridViewEpisodes.Rows.Add(episodes.Name);
                    }

                    dataGridViewEpisodes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                }

            }
        }

        private void getEpisodeDescription()
        {
            episodeInfo.Clear();

            int selectedrowindex = dataGridViewEpisodes.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewEpisodes.Rows[selectedrowindex];
            string selectedEpisode = Convert.ToString(selectedRow.Cells[0].Value);

            foreach (var onePod in podController.getAllPods())
            {
                foreach (var episode in onePod.Episodes)
                {
                    if (episode.Name.Equals(selectedEpisode))
                    {
                        lblEpisodeName.Text = episode.Name;
                        episodeInfo.Text = episode.Description;
                    }
                }
            }

        }

        private void dataGridViewEpisodes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getEpisodeDescription();
        }

        private void dataGridViewEpisodes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getEpisodeDescription();
        }

        private void btnRemovePod_Click(object sender, EventArgs e)
        {
            //int selectedrowindex = dataGridViewPodcast.SelectedCells[0].RowIndex;
            //DataGridViewRow selectedRow = dataGridViewPodcast.Rows[selectedrowindex];
            //string selectedPod = Convert.ToString(selectedRow.Cells[0].Value);

            string selectedPod = getSelectedPodName();

            podController.deletePod(selectedPod);
            getPods();
        }

        private string getSelectedPodName()
        {
            int selectedrowindex = dataGridViewPodcast.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPodcast.Rows[selectedrowindex];
            string selectedPod = Convert.ToString(selectedRow.Cells[0].Value);

            return selectedPod;
        }
    }
}
