using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectnc1
{
    class Motor
    {
        public double position = 0;      //Current position
        public int[] steps;         //Number of steps to move
        public int stepsInstruction = 0;
        public int acceleration = 0;
        public int deceleration = 0;
        public int speed = 0;


        public void SendMotorData(int acceleration, int deceleration, int speed, int step)
        {
            //send data to motor
            //do not send move command
        }
    }
}
