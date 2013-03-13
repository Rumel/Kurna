using Kurna.Models;
using ReactiveUI;

namespace Kurna.ViewModels
{
    public class GameViewModel : ReactiveObject
    {
        private Game game;
        public Game Game
        {
            get { return game; }
            set { this.RaiseAndSetIfChanged(ref game, value); }
        }
    }
}