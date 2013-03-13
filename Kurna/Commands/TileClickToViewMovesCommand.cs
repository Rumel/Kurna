using System;
using System.Windows.Input;

namespace Kurna.Commands
{
    public class TileClickToViewMovesCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;
    }
}