using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetA
{
    class RotatedNumbers
    {
        
        public List<int> RotateRight()
        {
            List<int> moveSpot = new List<int>();

            moveSpot.Add(1);
            moveSpot.Add(2);
            moveSpot.Add(3);
            moveSpot.Add(4);
            moveSpot.Add(5);
            moveSpot.Add(6);

             int listLength = moveSpot.Count;
            for (int i = 0; i < listLength; i++)
            {
                moveSpot.Insert(0, moveSpot[i - 1]);
                moveSpot.Remove(listLength);
                moveSpot.Insert(0, moveSpot[i - 1]);
                moveSpot.Remove(listLength);
            }
            for (int i = 0; i < moveSpot.Count; i++)
            {
                i = i + 5;
                Console.WriteLine(moveSpot);
            }
            Console.WriteLine(moveSpot);
            return moveSpot;
            
        }            
    }
}
