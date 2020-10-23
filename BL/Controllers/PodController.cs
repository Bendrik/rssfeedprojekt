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

        public void CreatePod(string name, string url, string frequency, string category)
        {
            Pod newPod = new Pod(name, url, frequency, category);
            Console.WriteLine(name + " " + url + " " + frequency + " " + category );
            podRepository.Create(newPod);
        }

        public void test()
        {
            XmlReader rssReader = XmlReader.Create("https://www.svt.se/nyheter/rss.xml");
            SyndicationFeed rssFeed = SyndicationFeed.Load(rssReader);
            string podcastTitle = rssFeed.Title.Text;
            string podcastDescription = rssFeed.Description.Text;
            Console.WriteLine(podcastTitle);
            Console.WriteLine(podcastDescription);
        }
    }
}
