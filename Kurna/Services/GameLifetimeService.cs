using Kurna.Models;
using ReactiveUI;

namespace Kurna.Services
{
    public class GameLifetimeService : ReactiveObject
    {
        private Game currentGame;
        public Game CurrentGame
        {
            get { return currentGame; }
            set { this.RaiseAndSetIfChanged(ref currentGame, value); }
        }
    }
}