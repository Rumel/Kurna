using System.Windows.Media;
using ReactiveUI;

namespace Kurna.Models
{
    public class Game : ReactiveObject
    {
        private GameState state;
        private ReactiveCollection<Tile> tiles;

        public Game()
        {
            state = GameState.Placing;
            CreateTiles();
        }

        public GameState State
        {
            get { return state; }
            set { this.RaiseAndSetIfChanged(ref state, value); }
        }

        public ReactiveCollection<Tile> Tiles
        {
            get { return tiles; }
            set { this.RaiseAndSetIfChanged(ref tiles, value); }
        }

        protected virtual void CreateTiles()
        {
            // Create the initial tiles
            Tiles = new ReactiveCollection<Tile>(
                new[]
                {
                    // Outer
                    new Tile { TileName = "OuterTopLeft", Row = 0, Column = 0 },
                    new Tile { TileName = "OuterTopMiddle", Row = 0, Column = 3 },
                    new Tile { TileName = "OuterTopRight", Row = 0, Column = 6 },
                    new Tile { TileName = "OuterMiddleLeft", Row = 3, Column = 0 },
                    new Tile { TileName = "OuterMiddleRight", Row = 3, Column = 6 },
                    new Tile { TileName = "OuterBottomLeft", Row = 6, Column = 0 },
                    new Tile { TileName = "OuterBottomMiddle", Row = 6, Column = 3 },
                    new Tile { TileName = "OuterBottomRight", Row = 6, Column = 6 },
                    // Middle
                    new Tile { TileName = "MiddleTopLeft", Row = 1, Column = 1 },
                    new Tile { TileName = "MiddleTopMiddle", Row = 1, Column = 3 },
                    new Tile { TileName = "MiddleTopRight", Row = 1, Column = 5 },
                    new Tile { TileName = "MiddleMiddleLeft", Row = 3, Column = 1 },
                    new Tile { TileName = "MiddleMiddleRight", Row = 3, Column = 5 },
                    new Tile { TileName = "MiddleBottomLeft", Row = 5, Column = 1 },
                    new Tile { TileName = "MiddleBottomMiddle", Row = 5, Column = 3 },
                    new Tile { TileName = "MiddleBottomRight", Row = 5, Column = 5 },
                    // Inner
                    new Tile { TileName = "InnerTopLeft", Row = 2, Column = 2 },
                    new Tile { TileName = "InnerTopMiddle", Row = 2, Column = 3 },
                    new Tile { TileName = "InnerTopRight", Row = 2, Column = 4 },
                    new Tile { TileName = "InnerMiddleLeft", Row = 3, Column = 2 },
                    new Tile { TileName = "InnerMiddleRight", Row = 3, Column = 4 },
                    new Tile { TileName = "InnerBottomLeft", Row = 4, Column = 2 },
                    new Tile { TileName = "InnerBottomMiddle", Row = 4, Column = 3 },
                    new Tile { TileName = "InnerBottomRight", Row = 4, Column = 4 }
                });

            // Make the connections

            // Outer Top
            Tiles[0].AdjacentTiles = new[] { Tiles[1], Tiles[3] };
            Tiles[1].AdjacentTiles = new[] { Tiles[0], Tiles[3], Tiles[8] };
            Tiles[2].AdjacentTiles = new[] { Tiles[1], Tiles[4] };

            // ...
            // TODO

            this.RaisePropertyChanged(x => x.Tiles);
        }
    }
}