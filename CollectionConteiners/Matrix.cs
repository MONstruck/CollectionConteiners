using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionConteiners
{
    public class Matrix :Position,  IEnumerator<Position>, IEnumerable<Position>
    {
        private List<Position> positionList = new List<Position>();
       
        Position position = new Position();

        public List<Position> PositionList { get => positionList; private set => positionList = value; }


        public void CreatePositionList(uint numList)
        {
            for (int i = 0; i < numList; i++)
            {
               // position = new Position();
                PositionList.Add(position);
            }
        }
        int counter = -1;
       new  public bool  MoveNext()
        {
            if (++counter >= PositionList.Count)
            {
                return false;
            }
            else
            {
                
                position = PositionList[counter];
            }
            return true;
        }
        new public void Reset()
        {
            counter = -1;
        }
        new public void Dispose() { }
        new public Position Current
        {
            get
            {
                return position;
            }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
      new public IEnumerator<Position> GetEnumerator()
        {
            return PositionList.GetEnumerator();
        }
      IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void ShowPosition(uint item)
        {
            try
            {
                uint iterator = Convert.ToUInt32(PositionList.Capacity) - 1;
                uint size = Convert.ToUInt32(item) - 1;
              
                foreach (Position position in PositionList)
                {
                    if (PositionList[Convert.ToInt32(size)] == position)
                    {
                        Console.WriteLine($"{position} Position");
                        position.ShowPoint(iterator);
                        break;
                    }

                }
            }
            catch (ArgumentOutOfRangeException exp)
            { Console.WriteLine(exp); }
        }
    }
}


