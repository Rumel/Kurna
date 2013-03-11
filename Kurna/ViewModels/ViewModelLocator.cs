using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurna.ViewModels
{
    public static class ViewModelLocator
    {
        private BoardViewModel _boardViewModel = null;
        public BoardViewModel BoardViewModel
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
