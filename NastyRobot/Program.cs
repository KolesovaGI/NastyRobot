using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NastyRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(MyThread));
            thread.Start();
        }

        public static void MyThread()
        {
            Robot robot = new Robot();

            while (true)
            {
                Console.WriteLine(robot.motion());
                HandlerMotion handlerMotion = new HandlerMotion();
                handlerMotion.Move += ShowMessage;
                handlerMotion.Motion(robot.motion());
                handlerMotion.Move -= ShowMessage;
                Thread.Sleep(1000);
            }
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        }
    }
