using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repositories
{
    public interface IPodRepository<T>:IRepository<T> where T:Pod
    {
        List<Episode> getEpisodes(string url);
    }
}
