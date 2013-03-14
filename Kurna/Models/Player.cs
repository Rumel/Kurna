using System.Linq;
using System.Windows.Media;
using ReactiveUI;
using System.Collections.Generic;

namespace Kurna.Models
{
    public class Player : ReactiveObject
    {
        private bool isComputer;
        private bool isPlayersTurn;
        private string name;
        private int piecesLeft;
        private Brush background;
        private ReactiveCollection<Mill> lastTurnMills;
        private int piecesCanRemove;
        private int invisiblePieces;
        public static readonly Brush InactiveColor = Brushes.White;
        public static readonly Brush ActiveColor = Brushes.Red;

        public Player()
        {
            InvisiblePieces = 9;
            PiecesLeft = 0;
            lastTurnMills = new ReactiveCollection<Mill>();
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

        public int PiecesCanRemove
        {
            get { return piecesCanRemove; }
            set { this.RaiseAndSetIfChanged(ref piecesCanRemove, value); }
        }

        public int InvisiblePieces
        {
            get { return invisiblePieces; }
            set { this.RaiseAndSetIfChanged(ref invisiblePieces, value); }
        }

        public int PiecesLeft
        {
            get { return piecesLeft; }
            set { this.RaiseAndSetIfChanged(ref piecesLeft, value); }
        }

        public ReactiveCollection<Mill> LastTurnMills
        {
            get { return lastTurnMills; }
            set { this.RaiseAndSetIfChanged(ref lastTurnMills, value); }
        }

        /////////// Board Pattern //////////
        //
        //  [0]           [1]            [2]
        //      [8]       [9]       [10]
        //           [16] [17] [18]
        //  [3] [11] [19]      [20] [12] [4]
        //           [21] [22] [23]
        //      [13]      [14]      [15]
        //  [5]           [6]            [7]
        //
        public bool AddNewMills(ReactiveCollection<Tile> tiles, TileStatus ts, Tile movedTile)
        {
            var millsThisTurn = new List<Mill>();

            // Outer
            if (tiles[0].Status == ts && tiles[1].Status == ts && tiles[2].Status == ts)
                millsThisTurn.Add(new Mill(tiles[0], tiles[1], tiles[2]));

            if (tiles[0].Status == ts && tiles[3].Status == ts && tiles[5].Status == ts)
                millsThisTurn.Add(new Mill(tiles[0], tiles[3], tiles[5]));

            if (tiles[2].Status == ts && tiles[4].Status == ts && tiles[7].Status == ts)
                millsThisTurn.Add(new Mill(tiles[2], tiles[4], tiles[7]));

            if (tiles[5].Status == ts && tiles[6].Status == ts && tiles[7].Status == ts)
                millsThisTurn.Add(new Mill(tiles[5], tiles[6], tiles[7]));

            // Middle
            if (tiles[8].Status == ts && tiles[9].Status == ts && tiles[10].Status == ts)
                millsThisTurn.Add(new Mill(tiles[8], tiles[9], tiles[10]));

            if (tiles[8].Status == ts && tiles[11].Status == ts && tiles[13].Status == ts)
                millsThisTurn.Add(new Mill(tiles[8], tiles[11], tiles[13]));

            if (tiles[10].Status == ts && tiles[12].Status == ts && tiles[15].Status == ts)
                millsThisTurn.Add(new Mill(tiles[10], tiles[21], tiles[15]));

            if (tiles[13].Status == ts && tiles[14].Status == ts && tiles[15].Status == ts)
                millsThisTurn.Add(new Mill(tiles[13], tiles[14], tiles[15]));

            // Inner
            if (tiles[16].Status == ts && tiles[17].Status == ts && tiles[18].Status == ts)
                millsThisTurn.Add(new Mill(tiles[16], tiles[17], tiles[18]));

            if (tiles[16].Status == ts && tiles[19].Status == ts && tiles[21].Status == ts)
                millsThisTurn.Add(new Mill(tiles[16], tiles[19], tiles[21]));

            if (tiles[18].Status == ts && tiles[20].Status == ts && tiles[23].Status == ts)
                millsThisTurn.Add(new Mill(tiles[18], tiles[20], tiles[23]));

            if (tiles[21].Status == ts && tiles[22].Status == ts && tiles[23].Status == ts)
                millsThisTurn.Add(new Mill(tiles[21], tiles[22], tiles[23]));

            // Plus Sign
            if (tiles[1].Status == ts && tiles[9].Status == ts && tiles[17].Status == ts)
                millsThisTurn.Add(new Mill(tiles[1], tiles[9], tiles[17]));

            if (tiles[3].Status == ts && tiles[11].Status == ts && tiles[19].Status == ts)
                millsThisTurn.Add(new Mill(tiles[3], tiles[11], tiles[19]));

            if (tiles[6].Status == ts && tiles[14].Status == ts && tiles[22].Status == ts)
                millsThisTurn.Add(new Mill(tiles[6], tiles[14], tiles[22]));

            if (tiles[4].Status == ts && tiles[12].Status == ts && tiles[20].Status == ts)
                millsThisTurn.Add(new Mill(tiles[4], tiles[12], tiles[20]));

            // Check validity
            millsThisTurn = new List<Mill>(millsThisTurn.Where(x => x.First == movedTile ||
                                                                    x.Second == movedTile ||
                                                                    x.Third == movedTile));

            if (millsThisTurn.Count == 0) return false;
            if (millsThisTurn.Count == 1)
            {
                return true;
                if (LastTurnMills.Count > 0)
                {

                }
                if (millsThisTurn[0].Equals(LastTurnMills[0]))
                    ;
            }
            else return true;
        }
    }
}
