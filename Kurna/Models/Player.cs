using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurna.Models
{
    public class Player : ReactiveObject
    {
        private bool isPlayersTurn;
        public bool IsPlayersTurn
        {
            get { return isPlayersTurn; }
            set { this.RaiseAndSetIfChanged(ref isPlayersTurn, value); }
        }
    }
}
