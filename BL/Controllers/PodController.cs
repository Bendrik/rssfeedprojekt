using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repositories;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace BL.Controllers
{
    public class PodController
    {
        IPodRepository<Pod> podRepository;
        public PodController()
        {
            podRepository = new PodRepository();
        }

        public void CreatePod(string name, string url, string frequency, string category)
        {
            //List<Episode> = new List<Episode> getEpisodes();
            List<Episode> episodes = getEpisodes(url);
            Pod newPod = new Pod(name, url, frequency, category, episodes);
            podRepository.Create(newPod);
        }

        public List<Pod> getAllPods()
        {
            return podRepository.GetAll();
        }

        public List<Episode> getEpisodes(string url)
        {            
            return podRepository.getEpisodes(url);
        }

        public void updatePod(string name, string url, string frequency, string category, int index)
        {
            List<Episode> episodeList = getEpisodes(url);
            Pod newPod = new Pod(name, url, frequency, category, episodeList);
            podRepository.Update(index, newPod);
        }

        public int getPodIndex(string name)
        {
            int index = podRepository.GetIndex(name);
            return index;
        }

        public void deletePod(string name)
        {
            DialogResult dialogResult = MessageBox.Show("Vill du ta bort podcasten " + name + "?", "Bekräfta", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int index = podRepository.GetIndex(name);
                podRepository.Delete(index);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }
    }
}
