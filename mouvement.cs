using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NKH.MindSqualls;

namespace KinectSkeletonApplication2
{
    class mouvement
    {
        public void foward(NxtBrick brick, int ratio)
        {
            brick.MotorA.Run((sbyte)ratio, (uint)0);
            brick.MotorB.Run((sbyte)ratio, (uint)0);
        }

        public void back(NxtBrick brick)
        {
            brick.MotorA.Run((sbyte)-100, (uint)0);
            brick.MotorB.Run((sbyte)-100, (uint)0);
        }

        public void left(NxtBrick brick, int ratio)
        {
            brick.MotorB.Run((sbyte)-ratio, (uint)0);
            brick.MotorA.Run((sbyte)ratio, (uint)0);
        }

        public void right(NxtBrick brick, int ratio)
        {
            brick.MotorB.Run((sbyte)ratio, (uint)0);
            brick.MotorA.Run((sbyte)-ratio, (uint)0);
        }

        public void fowardQuick(NxtBrick brick)
        {
            brick.MotorA.Run((sbyte)100, (uint)50);
            brick.MotorB.Run((sbyte)100, (uint)50);
        }

        public void backQuick(NxtBrick brick)
        {
            brick.MotorA.Run((sbyte)-100, (uint)50);
            brick.MotorB.Run((sbyte)-100, (uint)50);
        }
    }
}
