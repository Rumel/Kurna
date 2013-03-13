using Kurna.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurna.ViewModels
{
    public class PlayerViewModel : ReactiveObject
    {
        public PlayerViewModel()
        {
            PlayerOne = new Player();
            PlayerTwo = new Player();

            //Player one always goes first
            PlayerOne.IsPlayersTurn = true;
        }

        private Player playerOne;
        public Player PlayerOne
        {
            get
            {
                return playerOne;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref playerOne, value);
            }
        }

        private Player playerTwo;
        public Player PlayerTwo
        {
            get
            {
                return playerTwo;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref playerTwo, value);
            }
        }

        public void SwitchTurns()
        {
            PlayerOne.IsPlayersTurn = !PlayerOne.IsPlayersTurn;
            PlayerTwo.IsPlayersTurn = !PlayerTwo.IsPlayersTurn;
        }
    }
}
