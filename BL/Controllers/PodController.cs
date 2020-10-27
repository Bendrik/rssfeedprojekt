using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repositories;
using System.Xml;
using System.ServiceModel.Syndication;

namespace BL.Controllers
{
    public class PodController
    {
        IRepository<Pod> podRepository;
        public PodController()
        {
            podRepository = new PodRepository();
        }

        /*public void CreatePod(string name, string url, string frequency, string category)
        {
            //List<Episode> = new List<Episode> getEpisodes();
            List<Episode> episodes = getEpisodes(url);
            Pod newPod = new Pod(name, url, frequency, category, episodes);
            podRepository.Create(newPod);
        }*/

        public List<Pod> getAllPods()
        {
            return podRepository.GetAll();
        }

        public List<Episode> getEpisodes(string url)
        {
            //XmlReader rssReader = XmlReader.Create("https://www.svt.se/nyheter/rss.xml");
            XmlReader rssReader = XmlReader.Create(url);
            SyndicationFeed rssFeed = SyndicationFeed.Load(rssReader);

            List<Episode> episodeList = new List<Episode>();

            foreach (var item in rssFeed.Items)
            {
                Episode newEpisode = new Episode();
                newEpisode.Name = item.Title.Text;
                newEpisode.Description = item.Summary.Text;
                episodeList.Add(newEpisode);
            }

            return episodeList;
        }
    }
}
