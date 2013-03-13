using System.Collections.Generic;
using System.Windows.Media;
using ReactiveUI;

namespace Kurna.Models
{
    public class Tile : ReactiveObject
    {
        public static readonly Brush UnoccupiedColor = Brushes.White;
        public static readonly Brush P1Color = Brushes.Aqua;
        public static readonly Brush P2Color = Brushes.BlueViolet;
        private Brush fillColor;
        private TileStatus tileStatus;

        public TileStatus Status
        {
            get { return tileStatus; }
            set { OnTileStatusChanged(value); }
        }
        public Brush FillColor
        {
            get { return fillColor; }
            set { this.RaiseAndSetIfChanged(ref fillColor, value); }
        }
        public string Name { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public IEnumerable<Tile> AdjacentTiles { get; set; }

        private void OnTileStatusChanged(TileStatus value)
        {
            if (value == TileStatus.Unoccupied)
                FillColor = UnoccupiedColor;
            if (value == TileStatus.P1)
                FillColor = P1Color;
            if (value == TileStatus.P2)
                FillColor = P2Color;
            this.RaiseAndSetIfChanged(ref tileStatus, value);
        }

        public Tile()
        {
            Status = TileStatus.Unoccupied;
        }
    }
}