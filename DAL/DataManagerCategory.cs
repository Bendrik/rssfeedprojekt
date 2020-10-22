using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Models;
using DAL.Exceptions;
using System.Net;

namespace DAL
{
    internal class DataManagerCategory
    {
        public void Serialize(List<Category> categoryList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(categoryList.GetType());
                using (FileStream outfile = new FileStream("categories.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(outfile, categoryList);
                }
            }
            catch (Exception)
            {
                throw new SerializerException("categories.xml", "could not serialize");
            }

        }

        public List<Category> Deserialize()
        {

            try
            {
                List<Category> listOfCategories;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
                using (FileStream infile = new FileStream("categories.xml", FileMode.Open, FileAccess.Read))
                {
                    listOfCategories = (List<Category>)xmlSerializer.Deserialize(infile);
                }
                return listOfCategories;
            }
            catch (Exception)
            {
                throw new SerializerException("categories.xml", "could not deserialize");
            }
        }
    }
}
