using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repositories;
using DAL;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace BL.Controllers
{
    public class PodController
    {
        IPodRepository<Pod> podRepository;
        Validering validering;

        public DateTime NextUpdate { get; set; }
        public PodController()
        {
            podRepository = new PodRepository();
            validering = new Validering();
        }

        public async Task<bool> FixUpdate()
        {
            bool updated = false;

            foreach (var onePod in getAllPods())
            {
                NextUpdate = onePod.NextUpdate;
                int interval = Int32.Parse(onePod.Frequency);

                if (onePod.podUpdate)
                {
                    onePod.NextUpdate = DateTime.Now.AddSeconds(interval);
                    int index = GetPodIndexOfName(onePod.Name);
                    List<Episode> episodes = await podRepository.getEpisodes(onePod.PodUrl);
                    Pod newPod = new Pod(onePod.Name, onePod.PodUrl, onePod.Frequency, onePod.Category, onePod.NextUpdate, episodes);
                    podRepository.Update(index, newPod);
                    updated = true;
                }
            }
            return updated;            
        }

        public async void CreatePod(string name, string url, string frequency, string category)
        {
            if (validering.textEmpty(name))
            {
                if (validering.validateURL(url))
                {
                    List<Episode> episodes = await podRepository.getEpisodes(url);
                    DateTime nextUpdate = DateTime.Now;
                    Pod newPod = new Pod(name, url, frequency, category, nextUpdate, episodes);
                    podRepository.Create(newPod);
                }
                else
                {
                    MessageBox.Show("URLen är ogiltig");
                }
            }
            else
            {
                MessageBox.Show("Du måste fylla i ett namn");
            }
        }

        public List<Pod> getAllPods()
        {
            return podRepository.GetAll();
        }
        public async void updatePod(string name, string url, string frequency, string category, int index)
        {
            if (validering.validateURL(url))
            {
                List<Episode> episodeList = await podRepository.getEpisodes(url);
                DateTime nextUpdate = DateTime.Now;
                Pod newPod = new Pod(name, url, frequency, category, nextUpdate, episodeList);
                podRepository.Update(index, newPod);
            }
            else
            {
                MessageBox.Show("URLen är ogiltig");
            }
        }

        public int GetPodIndexOfName(string name)
        {
            int index = podRepository.GetIndexOfName(name);
            return index;
        }
        public int GetPodIndexOfCategory(string category)
        {
            int index = podRepository.GetIndexOfCategory(category);
            return index;
        }

        public bool deletePod(string name)
        {

            DialogResult dialogResult = MessageBox.Show("Vill du ta bort podcasten " + name + "?", "Bekräfta", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }       
        }

        public void deletePod(int index)
        {
            podRepository.Delete(index);
        }
    }
}
