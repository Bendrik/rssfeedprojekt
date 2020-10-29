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

        public DateTime NextUpdate { get; set; }
        public PodController()
        {
            podRepository = new PodRepository();
        }

        public void FixUpdate()
        {
            foreach (var onePod in getAllPods())
            {
                NextUpdate = onePod.NextUpdate;
                int interval = Int32.Parse(onePod.Frequency);

                if (onePod.podUpdate)
                {
                    //Console.WriteLine(onePod.Name + " nästa innan add: " + onePod.NextUpdate);
                    onePod.NextUpdate = DateTime.Now.AddSeconds(interval);
                    int index = GetPodIndexOfName(onePod.Name);
                    List<Episode> episodes = podRepository.getEpisodes(onePod.PodUrl);
                    Pod newPod = new Pod(onePod.Name, onePod.PodUrl, onePod.Frequency, onePod.Category, onePod.NextUpdate, episodes);
                    podRepository.Update(index, newPod);
                    //Console.WriteLine(onePod.Name + " nästa efter add: " + onePod.NextUpdate);
                }
            }
            
        }
        //public bool podUpdate
        //{

        //    get
        //    {
        //        return NextUpdate <= DateTime.Now;
        //    }
        //}

        public void CreatePod(string name, string url, string frequency, string category)
        {
            List<Episode> episodes = podRepository.getEpisodes(url);
            DateTime nextUpdate = DateTime.Now;
            Pod newPod = new Pod(name, url, frequency, category, nextUpdate, episodes);
            podRepository.Create(newPod);
        }

        public List<Pod> getAllPods()
        {
            return podRepository.GetAll();
        }

        public void updatePod(string name, string url, string frequency, string category, int index)
        {
            List<Episode> episodeList = podRepository.getEpisodes(url);
            DateTime nextUpdate = DateTime.Now;
            Pod newPod = new Pod(name, url, frequency, category, nextUpdate, episodeList);
            podRepository.Update(index, newPod);
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
                //int index = podRepository.GetIndexOfName(name);
                //podRepository.Delete(index);
                return true;
            }
            else //if (dialogResult == DialogResult.No)
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
