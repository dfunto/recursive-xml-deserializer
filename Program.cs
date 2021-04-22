using System;

namespace Recursive_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileInput = "input.xml";

            var handler = new RecursiveXMLHandler(fileInput);
        }
    }
}
