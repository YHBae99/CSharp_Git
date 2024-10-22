using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLReader_XMLWriter
{
    internal class CXMLControl
    {
        public static string _TEXT_DATA = "TEXT_DATA";
        public static string _CBOX_DATA = "CBOX_DATA";
        public static string _NUMBER_DATA = "NUMBER_DATA";

        /// <summary>
        /// read
        /// </summary>
        /// <param name="strXMLPath"></param>
        /// <returns></returns>
        public Dictionary<string, string> fXML_Reader(string strXMLPath)
        {
            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>();

            using (XmlReader rd = XmlReader.Create(strXMLPath))
            {
                while (rd.Read())
                {
                    if (rd.IsStartElement("SETTING"))
                    {
                        string strID = rd["id"];
                        rd.Read();

                        string strTEXT = rd.ReadElementContentAsString(_TEXT_DATA, "");
                        DXMLConfig.Add(_TEXT_DATA, strTEXT);

                        string strCBOX = rd.ReadElementContentAsString(_CBOX_DATA, "");
                        DXMLConfig.Add(_CBOX_DATA, strCBOX);

                        string strNUMBER = rd.ReadElementContentAsString(_NUMBER_DATA, "");
                        DXMLConfig.Add(_NUMBER_DATA, strNUMBER);
                    }
                }
            }

            return DXMLConfig;
        }

        /// <summary>
        /// write
        /// </summary>
        /// <param name="strXMLPath"></param>
        /// <param name="DXMLConfig"></param>
        public void fXML_Writer(string strXMLPath, Dictionary<string, string> DXMLConfig)
        {
            using (XmlWriter wr = XmlWriter.Create(strXMLPath))
            {
                wr.WriteStartDocument();

                // SETTING
                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");

                wr.WriteElementString(_TEXT_DATA, DXMLConfig[_TEXT_DATA]);
                wr.WriteElementString(_CBOX_DATA, DXMLConfig[_CBOX_DATA]);
                wr.WriteElementString(_NUMBER_DATA, DXMLConfig[_NUMBER_DATA]);

                wr.WriteEndElement();
                wr.WriteEndDocument();
            }
        }
    }
}
