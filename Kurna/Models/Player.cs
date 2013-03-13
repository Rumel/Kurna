using ReactiveUI;

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
