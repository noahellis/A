﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetA
{
    class DancingMan
    {
        public void PutArmUP()
        {
            Console.WriteLine(@"

                     *  * 
                   *      * 
                     *  *        * 
                       *      * 
                   *  *  * 
                 *    *     
               *      *       
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      * ");
        }

        public void PutArmDown()
        {
            Console.WriteLine(@"

                     *  * 
                   *      * 
                     *  *
                       *
                   *  *  * 
                 *    *     *
               *      *       *
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      * ");
        }

        public void MoveLegsApart()
        {
            Console.WriteLine(@"

                     *  * 
                   *      * 
                     *  *
                       *
                   *  *  * 
                 *    *     *
               *      *       *
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      * ");
        }

        public void BringLegsTogether()
        {
            Console.WriteLine(@"

                     *  * 
                   *      * 
                     *  *
                       *
                   *  *  * 
                 *    *     *
               *      *       *
                       * 
                   *      * 
                 *          * 
               *              * 
                 *         * 
               *             * ");
        }
        public void MoveArm()
        {
            
            for (int i = 0; i < 10; i++)
            {
                
                if (i % 2 == 0)

                {
                    Console.Clear();
                    PutArmUP();             
                    Console.ReadKey();
                }

                else
                {
                    Console.Clear();
                    PutArmDown();                    
                    Console.ReadKey();
                }
            }
        }
        public void MoveLegs()
        {
            for (int i = 10; i < 20; i++)
            {
                 if ((i > 10) && (i %2 ==0))
                 {
                    Console.Clear();
                    BringLegsTogether();
                    Console.ReadKey();
                 }

                 else
                {
                    Console.Clear();
                    MoveLegsApart();
                    Console.ReadKey();
                }
            }
                
                
        }
    }
}
