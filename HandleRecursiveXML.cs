using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Recursive_XML
{
    public class RecursiveXMLHandler {

        public RecursiveXMLHandler(string fileInput) {

            // Deserialise
            FileStream fs = new FileStream(fileInput, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);
            var serializer = new XmlSerializer(typeof(collection));

            var newcol = (collection)serializer.Deserialize(reader);

            // Output to console
            serializer.Serialize(Console.Out, newcol);
        }
    }
}