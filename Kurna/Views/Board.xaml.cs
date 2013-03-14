using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using Kurna.Models;
using Kurna.ViewModels;

namespace Kurna.Views
{
    /// <summary>
    /// Interaction logic for Board.xaml
    /// </summary>
    public partial class Board : UserControl
    {
        public Board()
        {
            InitializeComponent();
        }

        static Game game = ViewModelLocator.GameViewModel.Game;
        static PlayerViewModel players = ViewModelLocator.PlayerViewModel;

        enum SelectState
        {
            Neutral,
            PlaceNew,
            RemoveOpponentPiece,
            MoveExisting
        }

        private static SelectState currentState = SelectState.Neutral;

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var ellipse = sender as Ellipse;
            if (ellipse == null) return;
            var tile = game.Tiles.FirstOrDefault(t => ellipse.Tag as string == t.TileName);
            if (tile == null) return;

            if (currentState == SelectState.RemoveOpponentPiece)
            {
                if (players.PlayerOne.IsPlayersTurn && tile.Status == TileStatus.P1)
                {
                    tile.Status = TileStatus.Unoccupied;
                    players.PlayerTwo.PiecesLeft--;
                    currentState = SelectState.Neutral;
                    players.SwitchTurns();
                }
                else if (players.PlayerTwo.IsPlayersTurn && tile.Status == TileStatus.P2)
                {
                    tile.Status = TileStatus.Unoccupied;
                    players.PlayerOne.PiecesLeft--;
                    currentState = SelectState.Neutral;
                    players.SwitchTurns();
                }
            }
            else if (game.State == GameState.Placing)
            {
                if (tile.Status != TileStatus.Unoccupied)
                {
                    // can't place on top of another piece 
                }
                else if (players.PlayerOne.IsPlayersTurn)
                {
                    tile.Status = TileStatus.P1;
                    players.PlayerOne.PiecesLeft--;
                    if (players.PlayerOne.AddNewMills(game.Tiles, TileStatus.P1))
                    {
                        currentState = SelectState.RemoveOpponentPiece;
                    }
                    else players.SwitchTurns();
                }
                else if (players.PlayerTwo.IsPlayersTurn)
                {
                    tile.Status = TileStatus.P2;
                    if (--players.PlayerTwo.PiecesLeft == 0)
                        game.State = GameState.Moving;
                    if (players.PlayerTwo.AddNewMills(game.Tiles, TileStatus.P2))
                    {
                        currentState = SelectState.RemoveOpponentPiece;
                    }
                    else players.SwitchTurns();
                }
            }
            else if (game.State == GameState.Moving)
            {
                if (game.CurrentlyMovingPiece == null)
                // This means that he hasn't selected a piece to move. Highlight the piece
                {
                    if (players.PlayerOne.IsPlayersTurn && tile.Status == TileStatus.P1 ||
                        players.PlayerTwo.IsPlayersTurn && tile.Status == TileStatus.P2)
                    {
                        game.CurrentlyMovingPiece = tile;
                        tile.Highlight();
                    }
                }
                else
                // This means that he has already selected a piece to move selected
                {
                    if (tile.Status == TileStatus.Unoccupied && game.CurrentlyMovingPiece.AdjacentTiles.Contains(tile))
                    {
                        tile.Status = game.CurrentlyMovingPiece.Status;
                        game.CurrentlyMovingPiece.Status = TileStatus.Unoccupied;
                        players.SwitchTurns();
                    }
                    game.CurrentlyMovingPiece.UnHighlight();
                    game.CurrentlyMovingPiece = null;
                }
            }
        }

        private void MouseUpOnElipse(object sender, MouseButtonEventArgs e)
        {
            var ellipse = sender as Ellipse;
            if (ellipse == null) return;
            var tile = game.Tiles.FirstOrDefault(t => ellipse.Tag as string == t.TileName);
            if (tile == null) return;


            //currentlyMovingPiece = null;
        }

        private void MouseMovesOut(object sender, MouseEventArgs e)
        {

        }

        private void ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            //var ellipse = sender as Ellipse;
            //if (ellipse != null && e.LeftButton == MouseButtonState.Pressed)
            //{
            //    DragDrop.DoDragDrop(ellipse, ellipse.Fill.ToString(), DragDropEffects.Move);
            //}
        }

        private void ellipse_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
        }

        private void ellipse_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void ellipse_DragLeave(object sender, DragEventArgs e)
        {
        }

        private void ellipse_DragOver(object sender, DragEventArgs e)
        {
        }

        private void ellipse_Drop(object sender, DragEventArgs e)
        {
        }
    }
}