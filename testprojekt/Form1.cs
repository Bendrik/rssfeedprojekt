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
using System.Collections;

namespace testprojekt
{
    public partial class Form1 : Form
    {
        CategoryController categoryController;
        PodController podController;
        private Timer theTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            podController = new PodController();
            getCategories();
            fillFrequencyBox();
            getPods();

            dataGridViewPodcast.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            theTimer.Interval = 1000;
            theTimer.Tick += theTimer_Tick;
            theTimer.Start();        
        }

        private async void theTimer_Tick(object sender, EventArgs e)
        {
            bool updated = await podController.FixUpdate();
            if (updated)
            {
                foreach (var onePod in podController.getAllPods())
                {
                    if (onePod != null)
                    {
                        for (int i = 0; i < dataGridViewPodcast.Rows.Count; i++)
                        {
                            if (onePod.Name.Equals(dataGridViewPodcast.Rows[i].Cells[0].Value))
                            {
                                var episodeAmount = onePod.Episodes.Count().ToString();
                                if (episodeAmount.Equals(dataGridViewPodcast.Rows[i].Cells[3].Value))
                                {

                                }
                                else
                                {
                                    dataGridViewPodcast.Rows[i].Cells[4].Value = "Ja";
                                    dataGridViewPodcast.Rows[i].Cells[3].Value = episodeAmount;
                                }
                            }
                        }
                        

                    }
                }
            }
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
                    comboBoxCat.SelectedIndex = 0;
                }
            }
        }

        private void fillFrequencyBox()
        {
            comboBoxFreq.Items.Clear();

            comboBoxFreq.Items.Add("10");
            comboBoxFreq.Items.Add("20");
            comboBoxFreq.Items.Add("40");

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
                    dataGridViewPodcast.Rows.Add(item.Name, item.Category, item.Frequency, episodeAmount, "Nej");
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = txtPodName.Text;
                string newUrl = textBoxUrl.Text;
                string newFrequency = comboBoxFreq.SelectedItem.ToString();
                string newCategory = comboBoxCat.SelectedItem.ToString();

                string oldName = getSelectedPodName();

                int podIndex = podController.GetPodIndexOfName(oldName);

                podController.updatePod(newName, newUrl, newFrequency, newCategory, podIndex);
                getPods();
                _ = useDelay();
            }
            catch (Exception)
            {
                MessageBox.Show("Du måste välja en podcast i listan");
            }
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            if (catList.SelectedIndex != -1)
            {
                string selectedCat = getSelectedCat();
                string newCatName = txtCategory.Text;

                if (categoryController.updateCategory(selectedCat, newCatName))
                {
                    foreach (var onePod in podController.getAllPods())
                    {
                        if (onePod.Category.Equals(selectedCat))
                        {
                            int podIndex = podController.GetPodIndexOfName(onePod.Name);
                            podController.updatePod(onePod.Name, onePod.PodUrl, onePod.Frequency, newCatName, podIndex);
                        }
                    }
                    getCategories();
                    getPods();
                }
            }
            else
            {
                MessageBox.Show("Välj en kategori i listan");
            }
        }

        private void btnNewCat_Click(object sender, EventArgs e)
        {
            categoryController.createCategory(txtCategory.Text);
            getCategories();
            txtCategory.Clear();

        }

        private void catList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCategory.Text = getSelectedCat();
        }

        private void comboBoxFreq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNy_Click(object sender, EventArgs e)
        {

            if (comboBoxCat.SelectedIndex == -1)
            {
                MessageBox.Show("Du måste skapa en kategori först");
            }
            else
            {
                podController.CreatePod(txtPodName.Text, textBoxUrl.Text, comboBoxFreq.SelectedItem.ToString(), comboBoxCat.SelectedItem.ToString());
                getPods();
                _ = useDelay();
            }
        }

        async Task useDelay()
        {
            await Task.Delay(200);
            getPods();
        }

        private void dataGridViewPodcast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getEpisodeDescription();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPodcast_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            setNewEpisodeToNo();
            fillPodcastBoxes();
            getEpisodes();
        }
        private void dataGridViewPodcast_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setNewEpisodeToNo();
            fillPodcastBoxes();
            getEpisodes();
        }

        private void setNewEpisodeToNo()
        {
            int selectedrowindex = dataGridViewPodcast.SelectedCells[0].RowIndex;
            if (dataGridViewPodcast.Rows[selectedrowindex].Cells[0].Value != null)
            {
                dataGridViewPodcast.Rows[selectedrowindex].Cells[4].Value = "Nej";
            }
        }

        private void fillPodcastBoxes()
        {
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

            try
            {
                string selectedPod = getSelectedPodName();

                if (podController.deletePod(selectedPod))
                {
                    podController.deletePod(podController.GetPodIndexOfName(selectedPod));
                    getPods();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Du måste välja en podcast i listan");
            }
            
        }

        private string getSelectedPodName()
        {
            int selectedrowindex = dataGridViewPodcast.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPodcast.Rows[selectedrowindex];
            string selectedPod = Convert.ToString(selectedRow.Cells[0].Value);

            return selectedPod;
        }


        private void btnRemoveCat_Click(object sender, EventArgs e)
        {
            if (catList.SelectedIndex != -1)
            {
                string selectedCat = getSelectedCat();

                if (categoryController.removeCategory(selectedCat))
                {
                    foreach (var checkPodCat in podController.getAllPods())
                    {
                        Console.WriteLine(checkPodCat + selectedCat);

                        if (checkPodCat.Category.Equals(selectedCat))
                        {
                            int podIndex = podController.GetPodIndexOfCategory(selectedCat);
                            podController.deletePod(podIndex);
                        }
                    }
                    getCategories();
                    getPods();
                }
            }
            else
            {
                MessageBox.Show("Välj en kategori i listan");
            }
        }

        private string getSelectedCat()
        {
            string selectedCat = "";

            if (catList.SelectedIndex != -1)
            {
                selectedCat = catList.SelectedItem.ToString();
            }

            return selectedCat;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (catList.SelectedIndex != -1)
            {
                dataGridViewPodcast.Rows.Clear();
                dataGridViewEpisodes.Rows.Clear();
                lblEpisodeName.Text = "";
                episodeInfo.Text = "";

                string category = catList.SelectedItem.ToString();
                foreach (var item in podController.getAllPods())
                {
                    if (item.Category.Equals(category))
                    {
                        var episodeAmount = item.Episodes.Count().ToString();
                        dataGridViewPodcast.Rows.Add(item.Name, item.Category, item.Frequency, episodeAmount, "Nej");
                    }
                }
            }
            else
            {
                MessageBox.Show("Välj en kategori i listan");
            }
        }
        private void btnRemoveFilter_Click(object sender, EventArgs e)
        {
            getPods();
        }
    }
}
