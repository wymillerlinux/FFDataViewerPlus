using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace FFDataViewerPlus
{
    class XmlDataService
    {
        private readonly string _dataFilePath;

        public List<Character> ReadAll()
        {
            List<Character> characters = new List<Character>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Character>), new XmlRootAttribute("Characters"));

            try
            {
                StreamReader reader = new StreamReader(_dataFilePath);
                using (reader)
                {
                    characters = (List<Character>)serializer.Deserialize(reader);
                }

            }
            catch (Exception)
            {
                throw;
            }

            return characters;
        }

        public void WriteAll(List<Character> characters)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Character>), new XmlRootAttribute("Characters"));

            try
            {
                StreamWriter writer = new StreamWriter(_dataFilePath);
                using (writer)
                {
                    serializer.Serialize(writer, characters);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public XmlDataService()
        {

        }

        public XmlDataService(string datafile)
        {
            _dataFilePath = datafile;
        }
    }
}
