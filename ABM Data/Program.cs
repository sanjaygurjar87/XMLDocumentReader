using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace ABM_Data
{
   public class Program
    {
       public static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                StringBuilder text = new StringBuilder();
                doc.Load(@"..\Debug\XMLFile1.xml");

                XmlNodeList xnl = doc.SelectNodes("/InputDocument/DeclarationList/DeclarationHeader/Reference");
                foreach (XmlNode node in xnl)
                {

                    if (node.Attributes["RefCode"].InnerText == "MWB")
                    {
                        XmlNodeList MWB = doc.SelectNodes("/InputDocument/DeclarationList/DeclarationHeader/Reference[@RefCode='" + "MWB" + "']");
                        foreach (XmlNode mwb in MWB)
                        {
                            text.Append("MWB=" + mwb["RefText"].InnerText + "\n");
                            //text = text + "<br>" + mwb["RefText"].InnerText;

                        }
                    }

                    if (node.Attributes["RefCode"].InnerText == "TRV")
                    {
                        XmlNodeList TRV = doc.SelectNodes("/InputDocument/DeclarationList/DeclarationHeader/Reference[@RefCode='" + "TRV" + "']");
                        foreach (XmlNode trv in TRV)
                        {
                            text.Append("TRV=" + trv["RefText"].InnerText + "\n");

                        }
                    }
                    if (node.Attributes["RefCode"].InnerText == "CAR")
                    {
                        XmlNodeList CAR = doc.SelectNodes("/InputDocument/DeclarationList/DeclarationHeader/Reference[@RefCode='" + "CAR" + "']");
                        foreach (XmlNode car in CAR)
                        {
                            text.Append("CAR=" + car["RefText"].InnerText + "\n");

                        }
                    }


                }
                Console.WriteLine(text);
                Console.ReadLine();

            }


            catch (Exception ex)
            {

            } 
        }

        }
    }
