using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DAL.Exceptions;
using Models;

namespace DAL.Repositories
{
    public class PodRepository : IPodRepository<Pod>
    {
        DataManager dataManager;
        List<Pod> podList;
        public PodRepository()
        {
            podList = new List<Pod>();
            dataManager = new DataManager();
            podList = GetAll();
        }
        public void Create(Pod entity)
        {
            podList.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            podList.RemoveAt(index);
            SaveChanges();
        }

        public List<Pod> GetAll()
        {
            List<Pod> podListReturn = new List<Pod>();
            try
            {
                
                if (podListReturn != null)
                {
                    podListReturn = dataManager.Deserialize();
                }
                
            }
            catch (SerializerException)
            {

                Console.WriteLine("kunde inte deserialize:a pods.xml");
            }
            
            return podListReturn;
        }

        public async Task <List<Episode>> getEpisodes(string url)
        {
            XmlReader rssReader = XmlReader.Create(url);
            SyndicationFeed rssFeed = await Task.Run(() => SyndicationFeed.Load(rssReader));

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

        public int GetIndexOfName(string name)

        {
            return GetAll().FindIndex(e => e.Name.Equals(name));
        }
        
        public int GetIndexOfCategory(string category)
        {
            return GetAll().FindIndex(e => e.Category.Equals(category));
        }

        public void SaveChanges()
        {         
            dataManager.Serialize(podList);      
        }

        public void Update(int index, Pod newEntity)
        {
            if (index >= 0)
            {
                podList[index] = newEntity;
            }
            SaveChanges();
        }
    }
}
