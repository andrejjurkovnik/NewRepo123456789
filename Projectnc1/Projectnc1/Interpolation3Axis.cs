using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectnc1
{
    class Interpolation3Axis
    {
        static int feed_rate = 20;
        static int stepsRev = 800;//number of steps per revolution
        static int gear = 5;//gear ratio - 5mm/rev
        static int numberOfAxis = 0;
        static Motor[] Axis = new Motor[8];

        public Interpolation3Axis(int numOfAxis)
        {
            numberOfAxis = numOfAxis;
            for (int i = 0; i < numOfAxis; i++)
            {
                Axis[i] = new Motor();
            }
        }

        public static void rapidPositioning(double[] endPosition)
        {
            for (int i = 0; i < numberOfAxis; i++)
            {
                Axis[i].stepsInstruction = positionToSteps(Axis[i].position, endPosition[i]);//every axis get number of steps to be made
            }
        }

        public static void rapidPosition(double[] endPosition)
        {
            rapidPosition(endPosition);              //set number of steps to move

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
        }

        //public static void linearInterpolation(double endPosition1, double endPosition2, double endPosition3)
        //{
        //    XAxis.steps = positionToSteps(XAxis.position, endPosition1);
        //    YAxis.steps = positionToSteps(YAxis.position, endPosition2);
        //    ZAxis.steps = positionToSteps(ZAxis.position, endPosition3);
        //    //total length to move
        //    double L = Math.Sqrt(((endPosition1 - XAxis.position) * (endPosition1 - XAxis.position)) + 
        //        ((endPosition2 - YAxis.position) * (endPosition2 - YAxis.position)) + ((endPosition3 - ZAxis.position)));
        //    if (L != 0)
        //    {
        //        XAxis.speed = (endPosition1 - XAxis.position) * feed_rate / L;//speed in mm/s
        //        if (XAxis.speed < 0) XAxis.speed = -XAxis.speed;
        //        YAxis.speed = (endPosition2 - YAxis.position) * feed_rate / L;//speed in mm/s
        //        if (YAxis.speed < 0) YAxis.speed = -YAxis.speed;
        //        ZAxis.speed = (endPosition3 - ZAxis.position) * feed_rate / L;//speed in mm/s
        //        if (ZAxis.speed < 0) ZAxis.speed = -ZAxis.speed;
        //    }
        //    else
        //    {
        //        XAxis.speed = 0;
        //        YAxis.speed = 0;
        //        ZAxis.speed = 0;
        //    }
        //    XAxis.speed = 2 * Math.PI * XAxis.speed / gear;//speed in rad/s
        //    YAxis.speed = 2 * Math.PI * YAxis.speed / gear;//speed in rad/s
        //    ZAxis.speed = 2 * Math.PI * ZAxis.speed / gear;//speed in rad/s
        //}
        public static void circularInterpolationCW()
        {

        }
        public static void circularInterpolationCCW()
        {

        }
        
        static int positionToSteps(float startPosition, double endPosition)
        {
            int steps;
            steps = Convert.ToInt32((endPosition - startPosition) * stepsRev / gear);
            return steps;
        }
    }
}
