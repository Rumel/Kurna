using System.Windows.Media;
using ReactiveUI;

namespace Kurna.Models
{
    public class Player : ReactiveObject
    {
        private bool isComputer;
        private bool isPlayersTurn;
        private string name;
        private int piecesLeft;
        private Brush background;
        private static readonly Brush InactiveColor = Brushes.White;
        private static readonly Brush ActiveColor = Brushes.Red;

        public Player()
        {
            PiecesLeft = 9;
        }

        public string Name
        {
            get { return name; }
            set { this.RaiseAndSetIfChanged(ref name, value); }
        }

        public bool IsPlayersTurn
        {
            get { return isPlayersTurn; }
            set
            {
                this.RaiseAndSetIfChanged(ref isPlayersTurn, value);
                Background = IsPlayersTurn ? ActiveColor : InactiveColor;
            }
        }

        public Brush Background
        {
            get { return background; }
            set { this.RaiseAndSetIfChanged(ref background, value); }
        }
        //{
        //    get
        //    { return IsPlayersTurn ? ActiveColor : InactiveColor; }
        //}

        public bool IsComputer
        {
            get { return isComputer; }
            set { this.RaiseAndSetIfChanged(ref isComputer, value); }
        }

        public int PiecesLeft
        {
            get { return piecesLeft; }
            set { this.RaiseAndSetIfChanged(ref piecesLeft, value); }
        }
    }
}