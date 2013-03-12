using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Kurna.Views;

namespace Kurna.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private UserControl _CurrentControl = null;
        public UserControl CurrentControl
        {
            get
            {
                if (_CurrentControl == null)
                {
                    _CurrentControl = new HomePage();
                }
                return _CurrentControl;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.CurrentControl, value);
            }
        }
    }
}
