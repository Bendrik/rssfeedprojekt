using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repositories;

namespace BL.Controllers
{
    public class PodController
    {
        IRepository<Pod> podRepository;
        public PodController()
        {
            podRepository = new PodRepository();
        }

        public void CreatePod(string url, object frequency, object category)
        {
        }
    }
}
