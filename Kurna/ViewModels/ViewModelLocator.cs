using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurna.ViewModels
{
    public class ViewModelLocator
    {
        private static HomePageViewModel _homePageViewModel = null;
        public static HomePageViewModel HomePageViewModel
        {
            get
            {
                if (_homePageViewModel == null)
                {
                    _homePageViewModel = new HomePageViewModel();
                }
                return _homePageViewModel;
            }
            set
            {
                _homePageViewModel = value;
            }
        }

        private static BoardViewModel _boardViewModel = null;
        public static BoardViewModel BoardViewModel
        {
            get
            {
                if (_boardViewModel == null)
                {
                    _boardViewModel = new BoardViewModel();
                }
                return _boardViewModel;
            }
            set
            {
                _boardViewModel = value;
            }
        }

        private static MainWindowViewModel _mainWindowViewModel = null;
        public static MainWindowViewModel MainWindowViewModel
        {
            get
            {
                if (_mainWindowViewModel == null)
                {
                    _mainWindowViewModel = new MainWindowViewModel();
                }
                return _mainWindowViewModel;
            }
            set
            {
                _mainWindowViewModel = value;
            }
        }
    }
}
