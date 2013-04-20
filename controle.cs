using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NKH.MindSqualls;

namespace KinectSkeletonApplication2
{
    class controle
    {
        private mouvement moove = new mouvement();
        public void speed(NxtBrick brick, double y, double Z)
        {
            int yFinal = (int)(y*100);
            if ((yFinal > 0) && (yFinal < 10))
            {
                moove.foward(brick, 10);
                Console.WriteLine("go foward");
            }
            if  ((yFinal > 10) &&(yFinal < 20))
            {
                moove.foward(brick, 20);
                Console.WriteLine("go foward");
            }
            if ((yFinal>20)&&(yFinal < 30))
            {
                moove.foward(brick, 30);
                Console.WriteLine("go foward");
            }
            if ((yFinal > 30)&&(yFinal < 40))
            {
                moove.foward(brick, 40);
                Console.WriteLine("go foward");
            }
            if ((yFinal > 40)&&(yFinal < 50))
            {
                moove.foward(brick, 50);
                Console.WriteLine("go foward");
            }
            if ((yFinal > 50)&&(yFinal < 55))
            {
                moove.foward(brick, 60);
                Console.WriteLine("go foward");
            }
            if ((yFinal > 55)&&(yFinal < 60))
            {
                moove.foward(brick, 70);
                Console.WriteLine("go foward");
            }
            if ((yFinal > 60)&&(yFinal < 65))
            {
                moove.foward(brick, 80);
                Console.WriteLine("go foward");
            }
            if ((yFinal > 65)&&(yFinal < 75))
            {
                moove.foward(brick, 90);
                Console.WriteLine("go foward");
            }
            if ((yFinal > 85)&&(yFinal < 85))
            {
                moove.foward(brick, 100);
                Console.WriteLine("go foward");
            }
            if  (yFinal > 85)
            {
                moove.foward(brick, 100);
                Console.WriteLine("go foward");
            }
            if (yFinal <= -22)
            {
                brick.MotorA.Idle();
                brick.MotorB.Idle();
                Console.WriteLine("IDL");
            }
            else
            {
                Console.WriteLine("on fait rien");
            }
        }

        public void turn(NxtBrick brick, double x)
        {
            int xFinal = (int)(x * 100);
            if ((xFinal < 6) && (-1 < xFinal))
            {
            }
            if (xFinal < -1)
            {
                moove.right(brick, 100);
            }
            if (xFinal > 6)
            {
                moove.left(brick, 100);
            }
            /*
             * 
             * gauche 0.1
             * milieu 0.26
             * droite 0.1*/
        }
    }
}
