using System.Windows.Media;
using ReactiveUI;

namespace Kurna.Models
{
    public abstract class Game : ReactiveObject
    {
        private Player playerOne;
        private Player playerTwo;
        private GameState state;
        private ReactiveCollection<Tile> tiles;

        public Game()
        {
            CreateTiles();
        }

        public GameState State
        {
            get { return state; }
            set { this.RaiseAndSetIfChanged(ref state, value); }
        }

        public Player PlayerOne
        {
            get { return playerOne; }
            set { this.RaiseAndSetIfChanged(ref playerOne, value); }
        }

        public Player PlayerTwo
        {
            get { return playerTwo; }
            set { this.RaiseAndSetIfChanged(ref playerTwo, value); }
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
                    new Tile { Name = "OuterTopLeft", Row = 0, Column = 0, Status = TileStatus.P1 },
                    new Tile { Name = "OuterTopMiddle", Row = 0, Column = 3, Status = TileStatus.P2 },
                    new Tile { Name = "OuterTopRight", Row = 0, Column = 6 },
                    new Tile { Name = "OuterMiddleLeft", Row = 3, Column = 0, Status = TileStatus.P1 },
                    new Tile { Name = "OuterMiddleRight", Row = 3, Column = 6 },
                    new Tile { Name = "OuterBottomLeft", Row = 6, Column = 0 },
                    new Tile { Name = "OuterBottomMiddle", Row = 6, Column = 3 },
                    new Tile { Name = "OuterBottomRight", Row = 6, Column = 6 },
                    // Middle
                    new Tile { Name = "MiddleTopLeft", Row = 1, Column = 1 },
                    new Tile { Name = "MiddleTopMiddle", Row = 1, Column = 3 },
                    new Tile { Name = "MiddleTopRight", Row = 1, Column = 5 },
                    new Tile { Name = "MiddleMiddleLeft", Row = 3, Column = 1 },
                    new Tile { Name = "MiddleMiddleRight", Row = 3, Column = 5 },
                    new Tile { Name = "MiddleBottomLeft", Row = 5, Column = 1 },
                    new Tile { Name = "MiddleBottomMiddle", Row = 5, Column = 3 },
                    new Tile { Name = "MiddleBottomRight", Row = 5, Column = 5 },
                    // Inner
                    new Tile { Name = "InnerTopLeft", Row = 2, Column = 2 },
                    new Tile { Name = "InnerTopMiddle", Row = 2, Column = 3 },
                    new Tile { Name = "InnerTopRight", Row = 2, Column = 4 },
                    new Tile { Name = "InnerMiddleLeft", Row = 3, Column = 2 },
                    new Tile { Name = "InnerMiddleRight", Row = 3, Column = 4 },
                    new Tile { Name = "InnerBottomLeft", Row = 4, Column = 2 },
                    new Tile { Name = "InnerBottomMiddle", Row = 4, Column = 3 },
                    new Tile { Name = "InnerBottomRight", Row = 4, Column = 4 }
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

    public class PvpGame : Game
    {
        public PvpGame()
        {
            PlayerOne = new Player { IsPlayersTurn = true };
            PlayerTwo = new Player { IsPlayersTurn = false };
        }
    }
}