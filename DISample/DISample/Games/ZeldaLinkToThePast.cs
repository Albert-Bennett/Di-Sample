using DISample.GameItems.Weapons;
using System;

namespace DISample.Games
{
    public class ZeldaLinkToThePast : IGame
    {
        private readonly IWeapon _weapon;

        public ZeldaLinkToThePast(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void PressStart()
        {
            Console.WriteLine("Loading game..");
        }

        public void PlayGame()
        {
            _weapon.Attack();

            Console.WriteLine("On a quest");
        }
    }
}
