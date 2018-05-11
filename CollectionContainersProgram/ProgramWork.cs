using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionConteiners;

namespace CollectionContainersProgram
{
    class ProgramWork
    {
        public static void ContainerNumber(uint buffer, ContainersCollection containersCollection)
        {
            try
            {
                Console.WriteLine("Please Write Number of Containers");
                buffer = uint.Parse(Console.ReadLine());
                containersCollection.CreateContainerList(buffer);
            }
            catch (ArgumentNullException exp)
            {

                Console.WriteLine(exp);
                ContainerNumber(buffer, containersCollection);
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp);
                ContainerNumber(buffer, containersCollection);
            }
        }
        public static void MatrixNumber(uint buffer, ContainersCollection containersCollection)
        {
            try
            {

                Console.WriteLine("Please Write Number of Matrix");
                buffer = uint.Parse(Console.ReadLine());
                containersCollection.CreateMatrixList(buffer);
            }
            catch (ArgumentNullException exp)
            {
                Console.WriteLine(exp);
                MatrixNumber(buffer, containersCollection);

            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp);
                MatrixNumber(buffer, containersCollection);

            }
        }
        public static void PositionNumber(uint buffer, ContainersCollection containersCollection)
        {
            try
            {

                Console.WriteLine("Please Write Number of Position");
                buffer = uint.Parse(Console.ReadLine());
                containersCollection.CreatePositionList(buffer);
            }
            catch (ArgumentNullException exp)
            {
                Console.WriteLine(exp);
                PositionNumber(buffer, containersCollection);
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp);
                PositionNumber(buffer, containersCollection);
            }
        }
        public static uint PointType(uint buffer, ContainersCollection containersCollection)
        {
            try
            {
                Console.WriteLine("Please Write Type of Points (1d, 2d, 3d) ");
                buffer = uint.Parse(Console.ReadLine());
                return buffer;
            }
            catch (ArgumentNullException exp)
            {

                Console.WriteLine(exp);
                return PointType(buffer, containersCollection);

            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp);
                return PointType(buffer, containersCollection);

            }
        }
        public static void PointNumber(uint buffer, ContainersCollection containersCollection)
        {
            try
            {
                switch (ProgramWork.PointType(buffer, containersCollection))
                {
                    case 1:
                        Console.WriteLine("Please Write Number Points  ");
                        buffer = uint.Parse(Console.ReadLine());
                        containersCollection.AutoGenereted1DPosition(buffer);

                        break;
                    case 2:
                        Console.WriteLine("Please Write Number Points  ");
                        buffer = uint.Parse(Console.ReadLine());
                        containersCollection.AutoGenereted2DPosition(buffer);
                        break;
                    case 3:
                        Console.WriteLine("Please Write Number Points  ");
                        buffer = uint.Parse(Console.ReadLine());
                        containersCollection.AutoGenereted3DPosition(buffer);
                        break;
                    default: PointNumber(buffer, containersCollection);
                        break;
                }
            }
            catch (ArgumentNullException exp)
            {

                Console.WriteLine(exp);
                PointNumber(buffer, containersCollection);
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp);
                PointNumber(buffer, containersCollection);
            }
        }
    }
}
