using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CollectionConteiners;
using Newtonsoft.Json;
namespace CollectionContainersProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            ContainersCollection containersCollection = new ContainersCollection();

            Dialog(containersCollection);//work program
            string s = "";
            containersCollection.ShowCollections(s);//show collection, and json,
            ToXML(containersCollection);//write XML file
            Console.ReadKey();
        }

        public static void ToXML(ContainersCollection containersCollection)
        {
            XDocument xd = File.Exists("results.xml") ? XDocument.Load("results.xml") : new XDocument(new XElement("root"));
            xd.Root.Add(new XElement("CollectionContainer",
            new XElement("Container", containersCollection.ContainerList),
            new XElement("Matrix", containersCollection.MatrixList),
            new XElement("Position", containersCollection.PositionList),
            new XElement("Point", containersCollection.PointsList)));
            xd.Save("results.xml");
        }

        public static void Dialog(ContainersCollection containersCollection)
        {
            string answer;
            uint buffer = 0;
            Console.WriteLine("Genereted Collection Automatic? Please Write Y/N");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                containersCollection.Automatic(2, 2, 2, 2);
            }
            else if (answer == "n")
            {
                ProgramWork.ContainerNumber(buffer, containersCollection);
                ProgramWork.MatrixNumber(buffer, containersCollection);
                ProgramWork.PositionNumber(buffer, containersCollection);                
                ProgramWork.PointNumber(buffer, containersCollection);
            }
            else
            {
                Dialog(containersCollection);
           }
        }      
    }
}
 