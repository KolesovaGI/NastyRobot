using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastyRobot
{
    class Robot
    {
        string[] direction;
        Random rand;
        public Robot()
        {
            direction = new string[4]
            {
                "вперед",
                "назад",
                "влево",
                "вправо"
            };
            rand = new Random();
        }

        public string motion()
        {
            int index = rand.Next(4);
            return direction[index];
        }
    }
}
