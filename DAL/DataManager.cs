using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Models;

namespace DAL
{
    internal class DataManager
    {
        public void Serialize(List<Pod> podList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(podList.GetType());
            using (FileStream outfile = new FileStream("pods.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(outfile, podList);
            }

        }

        public List<Pod> Deserialize()
        {
            List<Pod> listOfPods;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pod>));
            using (FileStream infile = new FileStream("pods.xml", FileMode.Open, FileAccess.Read))
            {
                listOfPods = (List<Pod>) xmlSerializer.Deserialize(infile);
            }
            return listOfPods;
        }
    }
}
