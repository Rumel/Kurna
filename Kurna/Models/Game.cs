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
            var tiles = new[]
            {
                // Outer
                new Tile { Name = "OuterTopLeft", Row = 0, Column = 0 },
                new Tile { Name = "OuterTopMiddle" },
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
            };

            // Add the initial tiles
            Tiles = new ReactiveCollection<Tile>(tiles);
            //foreach (var tile in tiles)
            //{
            //    Tiles.Add(tile.Name, tile);
            //}

            // Make the connections

            //// Outer Top
            //Tiles["OuterTopLeft"].AdjacentTiles = new[] { Tiles["OuterTopMiddle"], Tiles["OuterLeftMiddle"] };
            //Tiles["OuterTopMiddle"].AdjacentTiles = new[]
            //{ Tiles["OuterTopLeft"], Tiles["OuterLeftRight"], Tiles["MiddleTopMiddle"] };
            //Tiles["OuterTopRight"].AdjacentTiles = new[] { Tiles["OuterTopMiddle"], Tiles["OuterRightMiddle"] };
            //// Outer Middle
            //Tiles["OuterMiddleLeft"].AdjacentTiles = new[]
            //{ Tiles["OuterTopLeft"], Tiles["OuterBottomLeft"], Tiles["MiddleMiddleLeft"] };
            //Tiles["OuterMiddleRight"].AdjacentTiles = new[]
            //{ Tiles["OuterTopLeft"], Tiles["OuterLeftRight"], Tiles["InnerTopMiddle"] };
            //// Outer Bottom
            //Tiles["OuterBottomLeft"].AdjacentTiles = new[] { Tiles["OuterMiddleLeft"], Tiles["OuterBottomMiddle"] };
            //Tiles["OuterBottomMiddle"].AdjacentTiles = new[]
            //{ Tiles["OuterBottomLeft"], Tiles["OuterBottomRight"], Tiles["MiddleBottomMiddle"] };
            //Tiles["OuterBottomRight"].AdjacentTiles = new[] { Tiles["OuterBottomMiddle"], Tiles["OuterRightMiddle"] };
            //// ...
            //// TODO

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