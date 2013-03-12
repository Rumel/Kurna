using ReactiveUI;

namespace Kurna.ViewModels
{
    public class Tile : ReactiveObject
    {
        private TileStatus _status;
        public TileStatus Status
        {
            get { return _status; }
            set { this.RaiseAndSetIfChanged(ref _status, value); }
        }
    }

    public enum TileStatus
    {
        Empty = 0
    }

    public class Board : ReactiveObject
    {
        private ReactiveCollection<Tile> _tiles;
        public ReactiveCollection<Tile> Tiles
        {
            get { return _tiles; }
            set { this.RaiseAndSetIfChanged(ref _tiles, value); }
        }


    }

    public class CalebExperiment : ReactiveObject
    {
    }
}