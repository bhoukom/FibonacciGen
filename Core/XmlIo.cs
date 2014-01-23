using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Core
{
    public class XmlIo
    {
        public static int ReadFile(string fileName)
        {
            try
            {
                var xDoc = XDocument.Load(fileName);
                var rootName = xDoc.Root.Name;

                if (rootName != "fibinput")
                {
                    throw new System.InvalidOperationException("Root name unexpected! Expected: <fibinput>");
                }

                var desc = xDoc.Descendants("fibinput").Single().Value;
                var returnDesc = Convert.ToInt32(desc);

                if (returnDesc < 0)
                {
                    throw new System.InvalidOperationException("Number is not positive: " + returnDesc);
                }

                if (returnDesc == 0)
                {
                    throw new System.InvalidOperationException("Number must be larger than zero.");
                }

                return returnDesc;
            }

                //Catch any exceptions that might crop up.
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file does not exist. ");
            }

            catch (AccessViolationException)
            {
                Console.WriteLine("You do not have permisson to open this file.");
            }

            catch (Exception e)
            {
                Console.WriteLine("Something went terribly wrong: " + e);
            }

            return 0;
        }

        [XmlRoot("fiboutput", Namespace = null)]
        public class ResultClass
        {
            [XmlElement("result")]
            public string[] Number { get; set; }
        }

        public static void ToXml(string fileName, IEnumerable<int> numberList)
        {
            try
            {
                var stringList = numberList.Select(i => i.ToString()).ToArray();
                var myObject = new ResultClass() { Number = stringList };
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add(string.Empty, string.Empty);

                using (var fileStream = File.Create(fileName))
                using (var textWriter = new XmlTextWriter(fileStream, Encoding.UTF8))
                {
                    var mysSerializer = new XmlSerializer(typeof(ResultClass));
                    mysSerializer.Serialize(textWriter, myObject, namespaces);
                }
                

                


                //Setting up my XML seralizer to take in my filename and numberlist.
            }

                //Catch any exceptions that might crop up.
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file does not exist. ");
            }

            catch (AccessViolationException)
            {
                Console.WriteLine("You do not have permisson to open this file.");
            }

            catch (Exception e)
            {
                Console.WriteLine("Something went terribly wrong: " + e);
            }

            //If all went well, go back to Main.
            return;
        }
    }
}