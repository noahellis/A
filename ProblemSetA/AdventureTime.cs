using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetA
{
    class AdventureTime
    {
       
        public void GiveBMODirections(string directions)
        {
            Console.WriteLine(directions);
        }

        public void DoComboMove()
        {
            GiveBMODirections("Up");
            GiveBMODirections("Down");
            GiveBMODirections("Left");
            GiveBMODirections("Left");
            GiveBMODirections("Right");
            GiveBMODirections("Right");
            GiveBMODirections("Down");
            GiveBMODirections("Spin");
            GiveBMODirections("Down");
            GiveBMODirections("Up");
            GiveBMODirections("Left");
            GiveBMODirections("Right");
            GiveBMODirections("Left");
            GiveBMODirections("Down");
            GiveBMODirections("Spin");
            GiveBMODirections("Up");
            GiveBMODirections("Down");
            GiveBMODirections("Jump"); 

            

            //Up, Down, Left, Left, Right, Right, Down, Spin, Down, Up, Left, Right, Left, Down, Spin, Up, Down, Jump.
        }
    }
}
