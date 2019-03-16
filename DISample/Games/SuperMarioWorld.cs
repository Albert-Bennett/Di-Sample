using DISample.GameItems.Weapons;
using System;

namespace DISample.Games
{
    public class SuperMarioWorld : IGame
    {
        private readonly IWeapon _weapon;

        public SuperMarioWorld(IWeapon weapon)
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
            Console.WriteLine("Jumping around!");
        }
    }
}
