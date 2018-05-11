using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionConteiners
{
    public class Container : Matrix,  IEnumerator<Matrix>, IEnumerable<Matrix>
    {     
        private List<Matrix> matrixList = new List<Matrix>();
        Matrix matrix;

        public List<Matrix> MatrixList { get => matrixList; internal set => matrixList = value; }

 
        public void CreateMatrixList(uint numMatrix)
        {

            for (int i = 0; i < numMatrix; i++)
            {
                matrix = new Matrix();
                MatrixList.Add( matrix);
            }

        }

        int counter = -1;

        new public bool MoveNext()
        {
            if (++counter >= MatrixList.Count)
            {
                return false;
            }
            else
            {
                // Set current box to next item in collection.
                matrix = MatrixList[counter];
            }
            return true;
        }
        new public void Reset()
        {
            counter = -1;
        }
        new public void Dispose() { }
        new public Matrix Current
        {
            get
            {
                return matrix;
            }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
        new public IEnumerator<Matrix> GetEnumerator()
        {
            return MatrixList.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public void ShowMatrix(uint item)
        {
            try
            {
                
                uint size = Convert.ToUInt32(PositionList.Capacity) - 1;
     
                
                foreach (Matrix matrix in MatrixList)
                {
                    if (MatrixList[Convert.ToInt32(item)] == matrix)
                    {
                        Console.WriteLine($" Matrix");
                        matrix.ShowPosition(size);
                        break;
                    }

                }
            }
            catch (ArgumentOutOfRangeException exp)
            { Console.WriteLine(exp); }
        }



    }
}
