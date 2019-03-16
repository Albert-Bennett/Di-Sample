using DISample.Games;

namespace DISample.Consoles
{
    public class HandheldSingleGameConsole : IGameConsole
    {
        public void LoadGame()
        {
            CatipillarGame game = new CatipillarGame();

            game.PressStart();
        }
    }
}
