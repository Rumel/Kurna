using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurna.Models;
using ReactiveUI;

namespace Kurna.ViewModels
{
    public class BoardViewModel : ReactiveObject
    {
        #region Players
        private Player _PlayerOne = null;
        public Player PlayerOne
        {
            get { return _PlayerOne; }
            set { this.RaiseAndSetIfChanged(x => x.PlayerOne, value); }
        }

        private Player _PlayerTwo = null;
        public Player PlayerTwo
        {
            get { return _PlayerTwo; }
            set { this.RaiseAndSetIfChanged(x => x.PlayerTwo, value); }
        }
        #endregion

        #region OuterSquare
        private TileStatus _OuterTopLeft = TileStatus.Empty;
        public TileStatus OuterTopLeft
        {
            get{ return _OuterTopLeft; }
            set { this.RaiseAndSetIfChanged(x => x.OuterTopLeft, value); }
        }

        private TileStatus _OuterTopMiddle = TileStatus.Empty;
        public TileStatus OuterTopMiddle
        {
            get { return _OuterTopMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.OuterTopMiddle, value); }
        }

        private TileStatus _OuterTopRight = TileStatus.Empty;
        public TileStatus OuterTopRight
        {
            get { return _OuterTopRight; }
            set { this.RaiseAndSetIfChanged(x => x.OuterTopRight, value); }
        }

        private TileStatus _OuterMiddleLeft = TileStatus.Empty;
        public TileStatus OuterMiddleLeft
        {
            get { return _OuterMiddleLeft; }
            set { this.RaiseAndSetIfChanged(x => x.OuterMiddleLeft, value); }
        }

        private TileStatus _OuterMiddleRight = TileStatus.Empty;
        public TileStatus OuterMiddleRight
        {
            get { return _OuterMiddleRight; }
            set { this.RaiseAndSetIfChanged(x => x.OuterMiddleRight, value); }
        }

        private TileStatus _OuterBottomLeft = TileStatus.Empty;
        public TileStatus OuterBottomLeft
        {
            get { return _OuterBottomLeft; }
            set { this.RaiseAndSetIfChanged(x => x.OuterBottomLeft, value); }
        }

        private TileStatus _OuterBottomMiddle = TileStatus.Empty;
        public TileStatus OuterBottomMiddle
        {
            get { return _OuterBottomMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.OuterBottomMiddle, value); }
        }

        private TileStatus _OuterBottomRight = TileStatus.Empty;
        public TileStatus OuterBottomRight
        {
            get { return _OuterBottomRight; }
            set { this.RaiseAndSetIfChanged(x => x.OuterBottomRight, value); }
        }
        #endregion

        #region MiddleSquare
        private TileStatus _MiddleTopLeft = TileStatus.Empty;
        public TileStatus MiddleTopLeft
        {
            get { return _MiddleTopLeft; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleTopLeft, value); }
        }

        private TileStatus _MiddleTopMiddle = TileStatus.Empty;
        public TileStatus MiddleTopMiddle
        {
            get { return _MiddleTopMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleTopMiddle, value); }
        }

        private TileStatus _MiddleTopRight = TileStatus.Empty;
        public TileStatus MiddleTopRight
        {
            get { return _MiddleTopRight; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleTopRight, value); }
        }

        private TileStatus _MiddleMiddleLeft = TileStatus.Empty;
        public TileStatus MiddleMiddleLeft
        {
            get { return _MiddleMiddleLeft; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleMiddleLeft, value); }
        }

        private TileStatus _MiddleMiddleRight = TileStatus.Empty;
        public TileStatus MiddleMiddleRight
        {
            get { return _MiddleMiddleRight; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleMiddleRight, value); }
        }

        private TileStatus _MiddleBottomLeft = TileStatus.Empty;
        public TileStatus MiddleBottomLeft
        {
            get { return _MiddleBottomLeft; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleBottomLeft, value); }
        }

        private TileStatus _MiddleBottomMiddle = TileStatus.Empty;
        public TileStatus MiddleBottomMiddle
        {
            get { return _MiddleBottomMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleBottomMiddle, value); }
        }

        private TileStatus _MiddleBottomRight = TileStatus.Empty;
        public TileStatus MiddleBottomRight
        {
            get { return _MiddleBottomRight; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleBottomRight, value); }
        }
        #endregion

        #region InnerSquare
        private TileStatus _InnerTopLeft = TileStatus.Empty;
        public TileStatus InnerTopLeft
        {
            get { return _InnerTopLeft; }
            set { this.RaiseAndSetIfChanged(x => x.InnerTopLeft, value); }
        }

        private TileStatus _InnerTopMiddle = TileStatus.Empty;
        public TileStatus InnerTopMiddle
        {
            get { return _InnerTopMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.InnerTopMiddle, value); }
        }

        private TileStatus _InnerTopRight = TileStatus.Empty;
        public TileStatus InnerTopRight
        {
            get { return _InnerTopRight; }
            set { this.RaiseAndSetIfChanged(x => x.InnerTopRight, value); }
        }

        private TileStatus _InnerMiddleLeft = TileStatus.Empty;
        public TileStatus InnerMiddleLeft
        {
            get { return _InnerMiddleLeft; }
            set { this.RaiseAndSetIfChanged(x => x.InnerMiddleLeft, value); }
        }

        private TileStatus _InnerMiddleRight = TileStatus.Empty;
        public TileStatus InnerMiddleRight
        {
            get { return _InnerMiddleRight; }
            set { this.RaiseAndSetIfChanged(x => x.InnerMiddleRight, value); }
        }

        private TileStatus _InnerBottomLeft = TileStatus.Empty;
        public TileStatus InnerBottomLeft
        {
            get { return _InnerBottomLeft; }
            set { this.RaiseAndSetIfChanged(x => x.InnerBottomLeft, value); }
        }

        private TileStatus _InnerBottomMiddle = TileStatus.Empty;
        public TileStatus InnerBottomMiddle
        {
            get { return _InnerBottomMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.InnerBottomMiddle, value); }
        }

        private TileStatus _InnerBottomRight = TileStatus.Empty;
        public TileStatus InnerBottomRight
        {
            get { return _InnerBottomRight; }
            set { this.RaiseAndSetIfChanged(x => x.InnerBottomRight, value); }
        }
        #endregion
    }
}
