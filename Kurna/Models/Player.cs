using System.Windows.Media;
using ReactiveUI;
using System.Collections.Generic;
using System.Windows;

namespace Kurna.Models
{
    public class Player : ReactiveObject
    {
        private bool isComputer;
        private bool isPlayersTurn;
        private string name;
        private int piecesLeft;
        private Visibility piecesLeftVisibility = Visibility.Visible;
        private string statusMessage;
        private Brush background;
        private ReactiveCollection<List<Tile>> mills;
        public static readonly Brush InactiveColor = Brushes.White;
        public static readonly Brush ActiveColor = Brushes.Black;

        public Player()
        {
            PiecesLeft = 9;
            mills = new ReactiveCollection<List<Tile>>();
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

        public bool IsComputer
        {
            get { return isComputer; }
            set { this.RaiseAndSetIfChanged(ref isComputer, value); }
        }

        public int PiecesLeft
        {
            get { return piecesLeft; }
            set
            { 
                this.RaiseAndSetIfChanged(ref piecesLeft, value);
                if (piecesLeft == 0)
                {
                    this.PiecesLeftVisibility = Visibility.Hidden;
                }
            }
        }

        public Visibility PiecesLeftVisibility
        {
            get { return piecesLeftVisibility; }
            set { this.RaiseAndSetIfChanged(ref piecesLeftVisibility, value); }
        }

        public string StatusMessage
        {
            get { return statusMessage; }
            set { this.RaiseAndSetIfChanged(ref statusMessage, value); }
        }

        public ReactiveCollection<List<Tile>> Mills
        {
            get { return mills; }
            set { this.RaiseAndSetIfChanged(ref mills, value); }
        }

        //Board Pattern
        //
        //  [0]           [1]            [2]
        //      [8]       [9]       [10]
        //           [16] [17] [18]
        //  [3] [11] [19]      [20] [12] [4]
        //           [21] [22] [23]
        //      [13]      [14]      [15]
        //  [5]           [6]            [7]
        //
        public bool AddNewMills(ReactiveCollection<Tile> tiles, TileStatus ts)
        {
            var thisTurn = new List<Tile>();

            // Outer
            if (tiles[0].Status == ts && tiles[1].Status == ts && tiles[2].Status == ts)
                thisTurn.AddRange(new[] { tiles[0], tiles[1], tiles[2] });

            if (tiles[0].Status == ts && tiles[3].Status == ts && tiles[5].Status == ts)
                thisTurn.AddRange(new[] { tiles[0], tiles[3], tiles[5] });

            if (tiles[2].Status == ts && tiles[4].Status == ts && tiles[7].Status == ts)
                thisTurn.AddRange(new[] { tiles[2], tiles[4], tiles[7] });

            if (tiles[5].Status == ts && tiles[6].Status == ts && tiles[7].Status == ts)
                thisTurn.AddRange(new[] { tiles[5], tiles[6], tiles[7] });

            // Middle
            if (tiles[8].Status == ts && tiles[9].Status == ts && tiles[10].Status == ts)
                thisTurn.AddRange(new[] { tiles[8], tiles[9], tiles[10] });

            if (tiles[8].Status == ts && tiles[11].Status == ts && tiles[13].Status == ts)
                thisTurn.AddRange(new[] { tiles[8], tiles[11], tiles[13] });

            if (tiles[10].Status == ts && tiles[12].Status == ts && tiles[15].Status == ts)
                thisTurn.AddRange(new[] { tiles[10], tiles[21], tiles[15] });

            if (tiles[13].Status == ts && tiles[14].Status == ts && tiles[15].Status == ts)
                thisTurn.AddRange(new[] { tiles[13], tiles[14], tiles[15] });

            // Inner
            if (tiles[16].Status == ts && tiles[17].Status == ts && tiles[18].Status == ts)
                thisTurn.AddRange(new[] { tiles[16], tiles[17], tiles[18] });

            if (tiles[16].Status == ts && tiles[19].Status == ts && tiles[21].Status == ts)
                thisTurn.AddRange(new[] { tiles[16], tiles[19], tiles[21] });

            if (tiles[18].Status == ts && tiles[20].Status == ts && tiles[23].Status == ts)
                thisTurn.AddRange(new[] { tiles[18], tiles[20], tiles[23] });

            if (tiles[21].Status == ts && tiles[22].Status == ts && tiles[23].Status == ts)
                thisTurn.AddRange(new[] { tiles[21], tiles[22], tiles[23] });

            // Add all mills
            Mills.Add(thisTurn);

            return thisTurn.Count > 0;
        }
    }
}
