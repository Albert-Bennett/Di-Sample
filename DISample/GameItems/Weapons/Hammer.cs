using System;

namespace DISample.GameItems.Weapons
{
    public class Hammer : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Smashing things with a hammer!!");
        }
    }
}
