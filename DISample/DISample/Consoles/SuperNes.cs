using DISample.Games;
namespace DISample.Consoles
{
    public class SuperNes:IGameConsole
    {
        private readonly IGame _game;

        public SuperNes(IGame game)
        {
            _game = game;
        }

        public void LoadGame()
        {
            _game.PlayGame();
        }
    }
}
