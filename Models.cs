using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Recursive_XML
{

    [Serializable]
    [XmlRoot]
    public class collection {
        private List<treeEntry> _entries = new List<treeEntry>();

        [XmlElement("item", typeof(item))]
        [XmlElement("folder", typeof(folder))]
        public List<treeEntry> entries {
            get { return _entries; }
        }
    }

    public abstract class treeEntry { }

    [Serializable]
    public class folder : treeEntry {
        private List<treeEntry> _entries = new List<treeEntry>();

        public folder() { }

        [XmlAttribute]
        public string name { get; set; }

        [XmlElement("item", typeof(item))]
        [XmlElement("folder", typeof(folder))]
        public List<treeEntry> entries {
            get { return _entries; }
        }
    }

    [Serializable]
    public class item : treeEntry { }



}