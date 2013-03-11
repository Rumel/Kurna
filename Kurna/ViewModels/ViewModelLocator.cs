using System;
using System.Collections.Generic;
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
    }
}
