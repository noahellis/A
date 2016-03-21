using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetA
{
    class RotatedNumbers
    {
        List<int> moveSpot = new List<int>();
        public void RotateOneSpot()
       {
            
            for (int i = 0; i < moveSpot.Count; i++)
                moveSpot.Insert(0, moveSpot.Count);
            moveSpot.Remove(0);
       }

        public void RotateSecondSpot()
        {
            
            for (int i = 0; i < moveSpot.Count; i++)
                moveSpot.Insert(0, moveSpot.Count);
            moveSpot.Remove(0);
        }

        public void AddFive()
        {
            for (int i = 0; i < moveSpot.Count; i++)
            {
                i=i + 5;
            }
                
        }

        public void AddToList()
        {
            moveSpot.Add(1);
            moveSpot.Add(2);
            moveSpot.Add(3);
            moveSpot.Add(4);
            moveSpot.Add(5);
            moveSpot.Add(6);
            RotateOneSpot();
            RotateSecondSpot();
            AddFive();
            Console.WriteLine();

        }
    }
}
