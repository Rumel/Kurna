using Kurna.Models;
using ReactiveUI;
using System.Windows.Media;

namespace Kurna.ViewModels
{
    public class BoardViewModel : ReactiveObject
    {
        private static readonly Brush DefaultTileFill = Brushes.White;
        private Game game;

        public BoardViewModel()
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
