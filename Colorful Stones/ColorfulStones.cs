using System;

namespace Code {
    class ColorfulStones {
        public static void Main (string[] args) {
            String stonesColors = Console.ReadLine ();
            String instruction = Console.ReadLine ();

            int stoneColorIndex = 0;

            for (int i = 0; i < instruction.Length; i++) {
                if (instruction[i] == stonesColors[stoneColorIndex])
                    stoneColorIndex++;
            }
            Console.WriteLine (stoneColorIndex + 1);
        }
    }
}