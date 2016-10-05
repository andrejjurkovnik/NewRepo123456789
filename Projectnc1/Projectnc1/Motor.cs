using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectnc1
{
    class Motor
    {
        public float position;      //Current position
        public int[] steps;         //Number of steps to move
        public int stepsInstruction;
        public int acceleration;
        public int deceleration;
        public int speed;


        public void SendMotorData(int acceleration, int deceleration, int speed, int step)
        {
            //send data to motor
            //do not send move command
        }
    }
}
