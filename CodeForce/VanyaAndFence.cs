using System;


namespace CodeForce
{
    public class VanyaAndFence
    {
        public void ExcuteMinimumWidthOfTheRoad()
        {
            var lineOne = Console.ReadLine();
            var lineOneValues = lineOne.Split(' ');
            var lineTwo = Console.ReadLine();
            var lineTwoValues = lineTwo.Split(' ');
            var result = MinimumWidthOfTheRoad(Convert.ToInt32(lineOneValues[0]),
                Convert.ToInt32(lineOneValues[1]), lineTwoValues);
            Console.WriteLine(result);
        }

        public int MinimumWidthOfTheRoad(int frindsCount, int fenceHeight, string[] frinds)
        {
            var shortPath = 0;
            for (int i = 0; i < frindsCount; i++)
            {
                var frind = Convert.ToInt32(frinds[i]);
                if (frind <= fenceHeight)
                    shortPath++;
                else
                    shortPath += 2;
            }
            return shortPath;
        }
    }
}
