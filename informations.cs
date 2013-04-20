using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NKH.MindSqualls;

namespace KinectSkeletonApplication2
{
    class informations
    {
        public string getName(NxtBrick brick)
        {
            string name = brick.Name;
            return name;
        }

        public string getBattery(NxtBrick brick)
        {
            string batteryPourcentage = ""+brick.BatteryLevel;
            return null;
        }
    }
}
