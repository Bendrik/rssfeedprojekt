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
    internal class DataManagerCategory
    {
        public void Serialize(List<Category> categoryList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(categoryList.GetType());
            using (FileStream outfile = new FileStream("categories.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(outfile, categoryList);
            }

        }

        public List<Category> Deserialize()
        {
            List<Category> listOfCategories;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
            using (FileStream infile = new FileStream("categories.xml", FileMode.Open, FileAccess.Read))
            {
                listOfCategories = (List<Category>)xmlSerializer.Deserialize(infile);
            }
            return listOfCategories;
        }
    }
}
