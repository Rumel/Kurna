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

        private static GameViewModel _gameViewModel = null;
        public static GameViewModel GameViewModel
        {
            get
            {
                if (_gameViewModel == null)
                {
                    _gameViewModel = new GameViewModel();
                }
                return _gameViewModel;
            }
            set
            {
                _gameViewModel = value;
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

        public static PlayerViewModel _PlayerViewModel = null;
        public static PlayerViewModel PlayerViewModel
        {
            get
            {
                if (_PlayerViewModel == null)
                {
                    _PlayerViewModel = new PlayerViewModel();
                }
                return _PlayerViewModel;
            }
            set
            {
                _PlayerViewModel = value;
            }
        }
    }
}
