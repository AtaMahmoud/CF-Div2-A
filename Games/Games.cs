using System;

namespace Code
{
    class Games
    {
        public static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            int[] hostUniformColor = new int[numberOfTeams];
            int[] guestUniformColor = new int[numberOfTeams];
            int numberOfHostTeamWearingGustUniform = 0;
            for (int i = 0; i < numberOfTeams; i++)
            {
                int[] teamColors = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                hostUniformColor[i] = teamColors[0];
                guestUniformColor[i] = teamColors[1];
            }
            for (int i = 0; i < numberOfTeams; i++)
            {
                for (int j = 0; j < numberOfTeams; j++)
                {
                    if (i == j)
                        continue;
                    if (guestUniformColor[j] == hostUniformColor[i])
                        numberOfHostTeamWearingGustUniform++;
                }
            }
            Console.WriteLine(numberOfHostTeamWearingGustUniform);

        }
    }
}