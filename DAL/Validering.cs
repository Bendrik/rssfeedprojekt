using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public class Validering
    {
        bool works = false;

        public bool validateURL(string url)
        {
            try
            {
                XmlReader reader = XmlReader.Create(url);
                Rss20FeedFormatter formatter = new Rss20FeedFormatter();
                formatter.ReadFrom(reader);
                reader.Close();
                works = true;
            }
            catch
            {
                works = false;
            }
            return works;
        }

        public bool textEmpty(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                works = false;
            }
            else
            {
                works = true;
            }
            return works;
        }


    }
}


