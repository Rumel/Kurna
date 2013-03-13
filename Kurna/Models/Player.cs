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
        private static readonly Brush InactiveColor = Brushes.White;
        private static readonly Brush ActiveColor = Brushes.Black;

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

        private List<List<string>> mills = new List<List<string>>();
        public List<List<string>> Mills
        {
            get
            {
                return mills;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref mills, value);
            }
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
        public void AddNewMills(ReactiveCollection<Tile> tiles, TileStatus ts)
        {
            List<string> cm = new List<string>();
            #region MillChecking
            #region Outer
            if (tiles[0].Status == ts && tiles[1].Status == ts && tiles[2].Status == ts)
            {
                cm.Add("OuterTop");
            }

            if (tiles[0].Status == ts && tiles[3].Status == ts && tiles[5].Status == ts)
            {
                cm.Add("OuterLeft");
            }

            if (tiles[2].Status == ts && tiles[4].Status == ts && tiles[7].Status == ts)
            {
                cm.Add("OuterRight");
            }

            if (tiles[5].Status == ts && tiles[6].Status == ts && tiles[7].Status == ts)
            {
                cm.Add("OuterBottom");
            }
            #endregion
            #region Middle
            if (tiles[8].Status == ts && tiles[9].Status == ts && tiles[10].Status == ts)
            {
                cm.Add("MiddleTop");
            }

            if (tiles[8].Status == ts && tiles[11].Status == ts && tiles[13].Status == ts)
            {
                cm.Add("MiddleLeft");
            }

            if (tiles[10].Status == ts && tiles[12].Status == ts && tiles[15].Status == ts)
            {
                cm.Add("MiddleRight");
            }

            if (tiles[13].Status == ts && tiles[14].Status == ts && tiles[15].Status == ts)
            {
                cm.Add("MiddleBottom");
            }
            #endregion
            #region Inner
            if (tiles[16].Status == ts && tiles[17].Status == ts && tiles[18].Status == ts)
            {
                cm.Add("InnerTop");
            }

            if (tiles[16].Status == ts && tiles[19].Status == ts && tiles[21].Status == ts)
            {
                cm.Add("InnerLeft");
            }

            if (tiles[18].Status == ts && tiles[20].Status == ts && tiles[23].Status == ts)
            {
                cm.Add("InnerRight");
            }

            if (tiles[21].Status == ts && tiles[22].Status == ts && tiles[23].Status == ts)
            {
                cm.Add("InnerBottom");
            }
            #endregion
            #endregion
            Mills.Add(cm);
        }
    }
}
