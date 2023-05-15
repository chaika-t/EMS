using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmployeeManagementSystem.Common.Models
{
    public class SettingsSerializer
    {
        public void Serialize(DataBaseSettings dataBaseSettings)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(DataBaseSettings));
            using (FileStream fs = new FileStream("DataBaseSettings.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, dataBaseSettings);
            }
        }

        public DataBaseSettings  Deserialize()
        {
            DataBaseSettings dataBaseSettings = new DataBaseSettings();
            XmlSerializer formatter = new XmlSerializer(typeof(DataBaseSettings));
            using (FileStream fs = new FileStream("DataBaseSettings.xml", FileMode.OpenOrCreate))
            {
                dataBaseSettings = (DataBaseSettings)formatter.Deserialize(fs);
                
            }

            return dataBaseSettings;
        }
    }
}
