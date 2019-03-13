using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace KClient
{
    [Serializable]
    public class Settings
    {
        [XmlElement("OPCServerURL")]
        public String OPCServerURL { get; set; }

        [XmlElement("TagRamp1")]
        public String TagRamp1 { get; set; }
        [XmlElement("TagRandom1")]
        public String TagRandom1 { get; set; }
        [XmlElement("TagSin1")]
        public String TagSin1 { get; set; }

        public Settings()
        {
            OPCServerURL = "opcda://localhost/Kepware.KEPServerEX.V6/";
            TagRamp1 = "Simulation Examples.Functions.Ramp1";
            TagRandom1 = "Simulation Examples.Functions.Random1";
            TagSin1 = "Simulation Examples.Functions.Sine1";
        }
        public String SerializeToString()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
            StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, this);
            return textWriter.ToString();
        }
        public void DeserializeFromString(String stringData)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
            using (TextReader reader = new StringReader(stringData))
            {
                Settings temp = (Settings)xmlSerializer.Deserialize(reader);

                this.OPCServerURL = temp.OPCServerURL;
                this.TagRamp1 = temp.TagRamp1;
                this.TagRandom1 = temp.TagRandom1;
                this.TagSin1 = temp.TagSin1;
            }
        }
        public void Load()
        {
            String dataFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            dataFile = Path.Combine(dataFile, "settings.dat");
            if (File.Exists(dataFile))
            {
                String serializedString = System.IO.File.ReadAllText(dataFile);                
                this.DeserializeFromString(serializedString);
            }
        }
        public void Save()
        {
            String dataFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            dataFile = Path.Combine(dataFile, "settings.dat");
            String serializedString = this.SerializeToString();
            System.IO.File.WriteAllText(dataFile, serializedString);
        }

    }
}
