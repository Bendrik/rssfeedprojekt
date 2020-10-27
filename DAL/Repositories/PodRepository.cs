﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (podListReturn != null)
            {
                podListReturn = dataManager.Deserialize();
            }
            return podListReturn;
        }

        public int GetIndex(string name)
        {
            return GetAll().FindIndex(e => e.Name.Equals(name));
        }

        public void SaveChanges()
        {         
            dataManager.Serialize(podList);      
        }

        public void Update(int index, Pod newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
