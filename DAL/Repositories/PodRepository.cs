using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Exceptions;
using Models;

namespace DAL.Repositories
{
    public class PodRepository : IPodRepository<Pod>
    {

        //"https://api.sr.se/api/rss/pod/22209" title="Creepypodden i P3"

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
