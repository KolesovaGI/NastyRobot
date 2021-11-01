using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace NastyRobot
{
    class HandlerMotion
    {
        public delegate void HandlerMotionState(string message);

        public event HandlerMotionState Move;

        public void Motion(string str)
        {
            if (str == "назад")
            {
                Move("запись в файл");

                var text = "input.txt";
                StreamReader sr = new StreamReader(text);
                {
                    string line = sr.ReadLine();
                }
            }
        }
    }
}
