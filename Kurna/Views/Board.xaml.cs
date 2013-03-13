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

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var ellipse = sender as Ellipse;
            if (ellipse == null) return;

            var game = ViewModelLocator.GameViewModel.Game;
            var players = ViewModelLocator.PlayerViewModel;
            var tile = game.Tiles.FirstOrDefault(t => ellipse.Tag as string == t.TileName);
            if (game.State == GameState.Placing)
            {
                if (tile.Status != TileStatus.Unoccupied)
                {
                    // can't place on top of another piece 
                }
                else if (players.PlayerOne.IsPlayersTurn)
                {
                    if (players.PlayerOne.PiecesLeft == 0)
                    {
                        game.State = GameState.Moving;
                    }
                    else
                    {
                        tile.Status = TileStatus.P1;
                        players.PlayerOne.PiecesLeft--;
                        players.SwitchTurns();
                    }
                }
                else if (players.PlayerTwo.IsPlayersTurn)
                {
                    if (players.PlayerTwo.PiecesLeft == 0)
                    {
                        game.State = GameState.Moving;
                    }
                    else
                    {
                        tile.Status = TileStatus.P2;
                        players.PlayerTwo.PiecesLeft--;
                        players.SwitchTurns();
                    }
                }
            }

            //var tiles = ellipse.Tag as IEnumerable<Tile>;
            //if (tiles != null)
            //    foreach (var tile in tiles)
            //    {
            //        tile.ShowIsAvailable();
            //    }
        }

        private void ShowUnavailable(object sender, MouseButtonEventArgs e)
        {
            //var ellipse = sender as Ellipse;

            //var tiles = ellipse.Tag as IEnumerable<Tile>;
            //if (tiles != null)
            //    foreach (var tile in tiles)
            //    {
            //        tile.ShowIsUnavailable();
            //    }
        }

        private void ShowUnavailable2(object sender, MouseEventArgs e)
        {
            //ShowUnavailable(sender, null);
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