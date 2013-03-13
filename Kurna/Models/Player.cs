using ReactiveUI;

namespace Kurna.Models
{
    public class Player : ReactiveObject
    {
        private string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref name, value);
            }
        }

        private bool isPlayersTurn;
        public bool IsPlayersTurn
        {
            get
            {
                return isPlayersTurn;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref isPlayersTurn, value);
            }
        }

        private bool isComputer;
        public bool IsComputer
        {
            get
            {
                return isComputer;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref isComputer, value);
            }
        }
    }
}
