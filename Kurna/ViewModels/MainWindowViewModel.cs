using ReactiveUI;
using System.Windows.Controls;
using Kurna.Views;

namespace Kurna.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private UserControl _CurrentControl = new HomePage();
        public UserControl CurrentControl
        {
            get { return _CurrentControl; }
            set {this.RaiseAndSetIfChanged(ref _CurrentControl, value); }
        }
    }
}
