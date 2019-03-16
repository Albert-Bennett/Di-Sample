using DISample.Consoles;
using DISample.GameItems.Weapons;
using DISample.Games;
using System;
using Unity;
using Unity.Lifetime;

namespace DISample
{
    class Program
    {
        //The composition route for a console application
        static void Main(string[] args)
        {
            /*  Issues with using an Ioc Container:-
             *      .1) All dependancies need to be registered with the container
             *      .2) Registered dependancies need to be released from the container 
             *          after use or memory problems could arise 
             *      .3) Threading issues can arise from life style choices
             *      .4) Only use resolve in the composition root
             *      .5) Compiler can't help with finding missing dependancies
             */


            //Using an ioc
            var container = new UnityContainer();

            //Creates a new instance of the game console each time is is resolved
            container.RegisterType<IGameConsole, SuperNes>(new TransientLifetimeManager());
            container.RegisterType<IGame, SuperMarioWorld>();
            container.RegisterType<IWeapon, Hammer>();

            IGameConsole consolefromIoc = container.Resolve<IGameConsole>();

            container.Dispose();

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
