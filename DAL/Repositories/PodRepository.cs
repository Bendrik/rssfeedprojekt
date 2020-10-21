using System;
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
        public void Create(Pod entity) /////kanske inte får ha dessa metoder utan måste skapa egna?
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public List<Pod> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(int index, Pod newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
