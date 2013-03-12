using System.Collections.Generic;
using ReactiveUI;

namespace Kurna.Models
{
    public abstract class Game : ReactiveObject
    {
        private GameState state;
        private Player playerOne;
        private Player playerTwo;
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
                    new Tile { Name = "OuterTopLeft", Row = 0, Column = 0 },
                    new Tile { Name = "OuterTopMiddle", Row = 0, Column = 3 },
                    new Tile { Name = "OuterTopRight", Row = 0, Column = 6 },
                    new Tile { Name = "OuterMiddleLeft" },
                    new Tile { Name = "OuterMiddleRight" },
                    new Tile { Name = "OuterBottomLeft" },
                    new Tile { Name = "OuterBottomMiddle" },
                    new Tile { Name = "OuterBottomRight" },
                    // Middle
                    new Tile { Name = "MiddleTopLeft" },
                    new Tile { Name = "MiddleTopMiddle" },
                    new Tile { Name = "MiddleTopRight" },
                    new Tile { Name = "MiddleMiddleLeft" },
                    new Tile { Name = "MiddleMiddleRight" },
                    new Tile { Name = "MiddleBottomLeft" },
                    new Tile { Name = "MiddleBottomMiddle" },
                    new Tile { Name = "MiddleBottomRight" },
                    // Inner
                    new Tile { Name = "InnerTopLeft" },
                    new Tile { Name = "InnerTopMiddle" },
                    new Tile { Name = "InnerTopRight" },
                    new Tile { Name = "InnerMiddleLeft" },
                    new Tile { Name = "InnerMiddleRight" },
                    new Tile { Name = "InnerBottomLeft" },
                    new Tile { Name = "InnerBottomMiddle" },
                    new Tile { Name = "InnerBottomRight" }
                });

            // Make the connections

            // Outer Top
            Tiles[0].AdjacentTiles = new Tile[] { Tiles[1], Tiles[2] };
            Tiles[1].AdjacentTiles = new Tile[] { Tiles[0], Tiles[3], Tiles[8] };
            Tiles[2].AdjacentTiles = new Tile[] { Tiles[1], Tiles[4] };

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