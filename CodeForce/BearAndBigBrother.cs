using System;
using System.Collections.Generic;
using System.Text;

namespace CodeForce
{
    public class BearAndBigBrother
    {
        public void Excute()
        {
            var lineOne = Console.ReadLine();
            var lineOneValues = lineOne.Split(' ');
            var brotherA = Convert.ToInt32(lineOneValues[0]);
            var brotherB = Convert.ToInt32(lineOneValues[1]);
            var result = 0;
            while (brotherA <= brotherB)
            {
                brotherA = brotherA * 3;
                brotherB = brotherB * 2;
                result++;
            }
            Console.WriteLine(result);
        }
    }
}
