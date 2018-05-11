using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionConteiners
{
    public class Position : Point, IEnumerator<Point>, IEnumerable<Point>

    {
        Point point = new Point();

        private List<Point> pointsList = new List<Point>();

        public List<Point> PointsList { get => pointsList; private set => pointsList = value; }





        public void createPointList(uint numPoint)
        {

            for (int i = 0; i < numPoint; i++)
            {
                point = new Point();
                PointsList.Add(point);
            }

        }

        public void AutoGenereted1DPosition(uint num)
        {
            for (int i = 0; i < num; i++)
            {
                point = new Point();
                PointsList.Add(point.AutoGenereted1DPoint());

            }
        }
        public void AutoGenereted2DPosition(uint num)
        {
            for (int i = 0; i < num; i++)
            {
                point = new Point();
                PointsList.Add(point.AutoGenereted2DPoint());
            }
        }
        public void AutoGenereted3DPosition(uint num)
        {
            for (int i = 0; i < num; i++)
            {
                Point point = new Point();
                PointsList.Add(point.AutoGenereted3DPoint());

            }
        }

        int counter = -1;




        public bool MoveNext()
        {
            Point point = new Point();
            if (++counter >= PointsList.Count)
            {
                return false;
            }
            else
            {
                // Set current box to next item in collection.
                point = PointsList[counter];
            }
            return true;
        }
        public void Reset()
        {
            counter = -1;
        }
        public void Dispose() { }
        public Point Current
        {
            get
            {
                return point;
            }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
        public IEnumerator<Point> GetEnumerator()
        {
            return PointsList.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public void ShowPoint(uint item)
        {
            uint size = Convert.ToUInt32(item) - 1;

            foreach (Point point in PointsList)
            {
                try
                {
                    if (PointsList[Convert.ToInt32(size)] == point)
                    {
                        Console.WriteLine($" Points");
                        point.OutputIntPoint();
                        break;
                    }
                }
                catch (ArgumentOutOfRangeException exp)
                { Console.WriteLine(exp); }
            }
        }
    }
}







