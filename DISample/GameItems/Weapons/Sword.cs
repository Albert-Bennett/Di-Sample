using System;

namespace DISample.GameItems.Weapons
{
    public class Sword : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Swinging our giant sword!!");
        }
    }
}
