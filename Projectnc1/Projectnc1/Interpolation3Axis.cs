using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectnc1
{
    class Interpolation3Axis
    {
        //delete
        int feed_rate = 20;
        int stepsRev = 800;//number of steps per revolution
        int gear = 5;//gear ratio - 5mm/rev
        int numberOfAxis = 0;
        public Motor[] Axis = new Motor[8];

        public Interpolation3Axis(int numOfAxis)
        {
            numberOfAxis = numOfAxis;
            for (int i = 0; i < numOfAxis; i++)
            {
                Axis[i] = new Motor();
            }
        }

        public void rapidPositioning(double[] endPosition)
        {
            for (int i = 0; i < numberOfAxis; i++)
            {
                Axis[i].stepsInstruction = positionToSteps(Axis[i].position, endPosition[i]);//every axis get number of steps to be made
            }
            SetNewPosition();
        }

        public void linearInterpolation(double[] endPosition)
        {
            double[] length;
            length = new double[numberOfAxis];      //length of one move of one axis
            double totalLength = 0;
            for (int i = 0; i < numberOfAxis; i++)
            {
                length[i] = endPosition[i] - Axis[i].position;
            }
            for (int i = 0; i < numberOfAxis; i++)
            {
                totalLength = totalLength + (length[i] * length[i]);
            }
            totalLength = Math.Sqrt(totalLength);   //pitagora rule L=sqrt(sum(endPosition[i] - Axis[i].position)^2)
            if (totalLength != 0)
            {
                for (int i = 0; i < numberOfAxis; i++)
                {
                    //speedInstruction = (endPosition[i] - Axis[i].position) * feed_rate / totalLength....mm/s
                    //omega = 2 * pi * speedInstruction/gear
                    //omega = omega * 100... MCU is operating with integers and we get more precision that way
                    Axis[i].speedInstruction = Convert.ToInt32((((endPosition[i] - Axis[i].position) * feed_rate / totalLength) / gear * 2 * Math.PI) * 100);
                    if (Axis[i].speedInstruction < 0) Axis[i].speedInstruction = -Axis[i].speedInstruction;
                }
            }
            rapidPositioning(endPosition);              //set number of steps to move
        }

        public void circularInterpolationCW()
        {

        }
        public void circularInterpolationCCW()
        {

        }

        int positionToSteps(double startPosition, double endPosition)
        {
            int steps;
            steps = Convert.ToInt32((endPosition - startPosition) * stepsRev / gear);
            return steps;
        }

        void SetNewPosition()
        {
            for (int i = 0; i < numberOfAxis; i++)
            {
                Axis[i].position = Axis[i].position + (Convert.ToDouble(Axis[i].stepsInstruction) / Convert.ToDouble(stepsRev) * Convert.ToDouble(gear));
            }
        }
    }
}
