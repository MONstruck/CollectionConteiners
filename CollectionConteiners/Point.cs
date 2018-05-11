using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConteiners
{
    public class Point
    {
        public Point point;
        private double d_pointX;
        private double d_pointY;
        private double d_pointZ;

        private int i_pointX;
        private int i_pointY;
        private int i_pointZ;

        private decimal m_pointX;
        private decimal m_pointY;
        private decimal m_pointZ;

        public double D_pointX { get => d_pointX; private set => d_pointX = value; }
        public double D_pointY { get => d_pointY; private set => d_pointY = value; }
        public double D_pointZ { get => d_pointZ; private set => d_pointZ = value; }
        public int I_pointX { get => i_pointX; private set => i_pointX = value; }
        public int I_pointY { get => i_pointY; private set => i_pointY = value; }
        public int I_pointZ { get => i_pointZ; private set => i_pointZ = value; }
        public decimal PointX { get => m_pointX; private set => m_pointX = value; }
        public decimal PointY { get => m_pointY; private set => m_pointY = value; }
        public decimal PointZ { get => m_pointZ; private set => m_pointZ = value; }

        private Random random = new Random();
        public Point()
        {

        }

        public Point(int pointX)
        {

            I_pointX = pointX;
        }
        public Point(int pointX, int pointY)
        {

            I_pointX = pointX;
            I_pointY = pointY;
        }
        public Point(int pointX, int pointY, int pointZ)
        {

            I_pointX = pointX;
            I_pointY = pointY;
            I_pointZ = pointZ;
        }

        public Point(double pointX)
        {

            D_pointX = pointX;
        }
        public Point(double pointX, double pointY)
        {

            D_pointX = pointX;
            D_pointY = pointY;
        }
        public Point(double pointX, double pointY, double pointZ)
        {

            D_pointX = pointX;
            D_pointY = pointY;
            D_pointZ = pointZ;
        }
        public Point(decimal pointX)
        {

            PointX = pointX;
        }
        public Point(decimal pointX, decimal pointY)
        {

            PointX = pointX;
            PointY = pointY;
        }
        public Point(decimal pointX, decimal pointY, decimal pointZ)
        {

            PointX = pointX;
            PointY = pointY;
            PointZ = pointZ;
        }
        public void OutputIntPoint()
        {

            Console.WriteLine($"{I_pointX}");
            Console.WriteLine($"{I_pointY}");
            Console.WriteLine($"{I_pointZ}");

        }
        public void OutputDoublePoint()
        {

            Console.WriteLine($"{D_pointX}");
            Console.WriteLine($"{D_pointY}");
            Console.WriteLine($"{D_pointZ}");

        }
        public void OutputDecimalPoint()
        {

            Console.WriteLine($"{PointX}");
            Console.WriteLine($"{PointY}");
            Console.WriteLine($"{PointZ}");

        }

        public Point AutoGenereted1DPoint()
        {
            return point = new Point(random.Next(-100, 100));
        }
        public Point AutoGenereted2DPoint()
        {

            return point = new Point(random.Next(-100, 100), random.Next(-100, 100));


        }

        public Point AutoGenereted3DPoint()
        {

            return point = new Point(random.Next(-100, 100), random.Next(-100, 100), random.Next(-100, 100));
        }





    }


}


