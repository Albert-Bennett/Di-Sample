using DISample.Consoles;
using DISample.GameItems.Weapons;
using DISample.Games;
using System;

namespace DISample
{
    class Program
    {
        //The composition route for a console application
        static void Main(string[] args)
        {
            //Poor man's dependancy injection
            SuperNes superNes = new SuperNes(
                new ZeldaLinkToThePast(new Sword()));

            superNes.LoadGame();

            //Trapped dependancy
            HandheldSingleGameConsole gameConsole = new HandheldSingleGameConsole();
            gameConsole.LoadGame();

            Console.ReadKey();
        }
    }
}
