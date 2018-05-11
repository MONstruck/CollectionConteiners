using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json;
namespace CollectionConteiners
{
    public class ContainersCollection:Container
    {

        Container container = new Container();
        Matrix matrix = new Matrix();
        Position position = new Position();
        Point point = new Point();

        private List<Container> containerList = new List<Container>();

        public List<Container> ContainerList { get => containerList; private set => containerList = value; }

        public void CreateContainerList(uint numContainer)
        {


            for (int i = 0; i < numContainer; i++)
            {
                container = new Container();
                ContainerList.Add(container);
            }

        }
        public void Automatic(uint numbersContainers,uint numbersMatrix,uint numbersPosition,uint numberPoints)
        {
            CreateContainerList(numbersContainers);
            CreateMatrixList(numbersMatrix);
            CreatePositionList(numbersPosition);
           AutoGenereted2DPosition(numberPoints);

        }
        public void ShowCollections(string filesListCommandJson)
        {

            foreach (Container item in ContainerList)
            {
                 filesListCommandJson = JsonConvert.SerializeObject(ContainerList);
                
                Console.WriteLine($"{item} Container");
                foreach (Matrix itemC in MatrixList)
                {
                     filesListCommandJson += JsonConvert.SerializeObject(MatrixList);
                    Console.WriteLine($"{itemC} Matrix");

                    foreach (Position itemM in PositionList)
                    {
                        filesListCommandJson += JsonConvert.SerializeObject(PositionList);
                        Console.WriteLine($"{itemM} Position");
                       foreach (Point itemP in PointsList)
                        {
                            filesListCommandJson += JsonConvert.SerializeObject(PointsList);
                            Console.WriteLine($" Points");
                            itemP.OutputIntPoint();
                           
                        }
                    }
                }

            }
            Console.Write(filesListCommandJson);
        }
        public void ShowContainer(uint item)
        {
            try
            {
                uint size = Convert.ToUInt32(MatrixList.Capacity) - 1;
        
                foreach (Container container in ContainerList)
                {
                    if (ContainerList[Convert.ToInt32(item)] == container)
                    {
                        Console.WriteLine($" Container");
                        container.ShowMatrix(size);
                        break;
                    }
                }
            }
            catch (ArgumentOutOfRangeException exp)
            { Console.WriteLine(exp); }
        }

      

        
    }
}