using System;

namespace DISample.Games
{
    public class CatipillarGame : IGame
    {
        public void PressStart()
        {
            Console.WriteLine("Start Pressed");
        }

        public void PlayGame()
        {
            Console.WriteLine("Playing Game...");
        }
    }
}
