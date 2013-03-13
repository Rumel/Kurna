using Kurna.Models;
using ReactiveUI;
using System.Windows.Media;

namespace Kurna.ViewModels
{
    public class GameViewModel : ReactiveObject
    {
        private static readonly Brush DefaultTileFill = Brushes.White;
        private Game game;

        public GameViewModel()
        {
            Game = new PvpGame();
        }

        public Game Game
        {
            get { return game; }
            set { this.RaiseAndSetIfChanged(ref game, value); }
        }
    }
}
