using System;

namespace Code
{
    class NightAtTheMuseum
    {
        public static void Main(String[] args)
        {
            String exhibitName = Console.ReadLine();
            int rotaionCounter = 0;
            int index = 97;
            for (int i = 0; i < exhibitName.Length; i++)
            {
                int withColockWise = 26 - Math.Abs(index - exhibitName[i]);
                int antiClolockWise = Math.Abs(index - exhibitName[i]);

                if (withColockWise < antiClolockWise)
                    rotaionCounter += withColockWise;
                else
                    rotaionCounter += antiClolockWise;

                index = exhibitName[i];
            }
            Console.WriteLine(rotaionCounter);
        }
    }
}