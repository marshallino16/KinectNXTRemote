using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NKH.MindSqualls;

namespace KinectSkeletonApplication2
{
    class connection
    {
        public void connectRobot(NxtBrick brick)
        {
            try
                {
                    brick.MotorB = new NxtMotor();
                    brick.MotorA = new NxtMotor();

                    brick.Connect();

                    if (brick.BatteryLevel < 7000)
                    {
                        Console.WriteLine("Warning : Your Nxt has low battery level!");
                    }

                    Console.WriteLine("Connecté au " + brick.Name);
                }
                catch
                {
                    Console.WriteLine("Cannot reach robot nxt bluetooth port");
                    disconnectRobot(brick);
                }
            }

         public void disconnectRobot(NxtBrick brick)
         {
             if (brick != null && brick.IsConnected)
                brick.Disconnect();

            brick = null;
         }
        
    }
}
