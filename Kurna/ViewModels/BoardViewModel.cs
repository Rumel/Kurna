using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurna.Models;
using ReactiveUI;
using System.Windows.Media;

namespace Kurna.ViewModels
{
    public class BoardViewModel : ReactiveObject
    {
        public BoardViewModel()
        {
            this.OuterBottomLeft = TileStatus.Empty;
            this.InnerBottomLeftFill = Brushes.Red;
        }

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

        private Brush _OuterTopLeftFill = Brushes.Black;
        public Brush OuterTopLeftFill
        {
            get {
                return _OuterTopLeftFill;
            }
            set{
                this.RaiseAndSetIfChanged(x => x.OuterTopLeftFill, value);
            }
        }

        private TileStatus _OuterTopMiddle = TileStatus.Empty;
        public TileStatus OuterTopMiddle
        {
            get { return _OuterTopMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.OuterTopMiddle, value); }
        }

        private Brush _OuterTopMiddleFill = Brushes.Black;
        public Brush OuterTopMiddleFill
        {
            get
            {
                return _OuterTopMiddleFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.OuterTopMiddleFill, value);
            }
        }

        private TileStatus _OuterTopRight = TileStatus.Empty;
        public TileStatus OuterTopRight
        {
            get { return _OuterTopRight; }
            set { this.RaiseAndSetIfChanged(x => x.OuterTopRight, value); }
        }

        private Brush _OuterTopRightFill = Brushes.Black;
        public Brush OuterTopRightFill
        {
            get
            {
                return _OuterTopLeftFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.OuterTopRightFill, value);
            }
        }

        private TileStatus _OuterMiddleLeft = TileStatus.Empty;
        public TileStatus OuterMiddleLeft
        {
            get { return _OuterMiddleLeft; }
            set { this.RaiseAndSetIfChanged(x => x.OuterMiddleLeft, value); }
        }

        private Brush _OuterMiddleLeftFill = Brushes.Black;
        public Brush OuterMiddleLeftFill
        {
            get
            {
                return _OuterMiddleLeftFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.OuterMiddleLeftFill, value);
            }
        }

        private TileStatus _OuterMiddleRight = TileStatus.Empty;
        public TileStatus OuterMiddleRight
        {
            get { return _OuterMiddleRight; }
            set { this.RaiseAndSetIfChanged(x => x.OuterMiddleRight, value); }
        }

        private Brush _OuterMiddleRightFill = Brushes.Black;
        public Brush OuterMiddleRightFill
        {
            get
            {
                return _OuterMiddleRightFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.OuterMiddleRightFill, value);
            }
        }

        private TileStatus _OuterBottomLeft = TileStatus.Empty;
        public TileStatus OuterBottomLeft
        {
            get { return _OuterBottomLeft; }
            set { this.RaiseAndSetIfChanged(x => x.OuterBottomLeft, value); }
        }

        private Brush _OuterBottomLeftFill = Brushes.Black;
        public Brush OuterBottomLeftFill
        {
            get
            {
                return _OuterBottomLeftFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.OuterBottomLeftFill, value);
            }
        }

        private TileStatus _OuterBottomMiddle = TileStatus.Empty;
        public TileStatus OuterBottomMiddle
        {
            get { return _OuterBottomMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.OuterBottomMiddle, value); }
        }

        private Brush _OuterBottomMiddleFill = Brushes.Black;
        public Brush OuterBottomMiddleFill
        {
            get
            {
                return _OuterBottomMiddleFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.OuterBottomMiddleFill, value);
            }
        }

        private TileStatus _OuterBottomRight = TileStatus.Empty;
        public TileStatus OuterBottomRight
        {
            get { return _OuterBottomRight; }
            set { this.RaiseAndSetIfChanged(x => x.OuterBottomRight, value); }
        }

        private Brush _OuterBottomRightFill = Brushes.Black;
        public Brush OuterBottomRightFill
        {
            get
            {
                return _OuterBottomRightFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.OuterBottomRightFill, value);
            }
        }
        #endregion

        #region MiddleSquare
        private TileStatus _MiddleTopLeft = TileStatus.Empty;
        public TileStatus MiddleTopLeft
        {
            get { return _MiddleTopLeft; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleTopLeft, value); }
        }

        private Brush _MiddleTopLeftFill = Brushes.Black;
        public Brush MiddleTopLeftFill
        {
            get
            {
                return _MiddleTopLeftFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.MiddleTopLeftFill, value);
            }
        }

        private TileStatus _MiddleTopMiddle = TileStatus.Empty;
        public TileStatus MiddleTopMiddle
        {
            get { return _MiddleTopMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleTopMiddle, value); }
        }

        private Brush _MiddleTopMiddleFill = Brushes.Black;
        public Brush MiddleTopMiddleFill
        {
            get
            {
                return _MiddleTopMiddleFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.MiddleTopMiddleFill, value);
            }
        }

        private TileStatus _MiddleTopRight = TileStatus.Empty;
        public TileStatus MiddleTopRight
        {
            get { return _MiddleTopRight; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleTopRight, value); }
        }

        private Brush _MiddleTopRightFill = Brushes.Black;
        public Brush MiddleTopRightFill
        {
            get
            {
                return _MiddleTopRightFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.MiddleTopRightFill, value);
            }
        }

        private TileStatus _MiddleMiddleLeft = TileStatus.Empty;
        public TileStatus MiddleMiddleLeft
        {
            get { return _MiddleMiddleLeft; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleMiddleLeft, value); }
        }

        private Brush _MiddleMiddleLeftFill = Brushes.Black;
        public Brush MiddleMiddleLeftFill
        {
            get
            {
                return _MiddleMiddleLeftFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.MiddleMiddleLeftFill, value);
            }
        }

        private TileStatus _MiddleMiddleRight = TileStatus.Empty;
        public TileStatus MiddleMiddleRight
        {
            get { return _MiddleMiddleRight; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleMiddleRight, value); }
        }

        private Brush _MiddleMiddleRightFill = Brushes.Black;
        public Brush MiddleMiddleRightFill
        {
            get
            {
                return _MiddleMiddleRightFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.MiddleMiddleRightFill, value);
            }
        }

        private TileStatus _MiddleBottomLeft = TileStatus.Empty;
        public TileStatus MiddleBottomLeft
        {
            get { return _MiddleBottomLeft; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleBottomLeft, value); }
        }

        private Brush _MiddleBottomLeftFill = Brushes.Black;
        public Brush MiddleBottomLeftFill
        {
            get
            {
                return _MiddleBottomLeftFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.MiddleBottomLeftFill, value);
            }
        }

        private TileStatus _MiddleBottomMiddle = TileStatus.Empty;
        public TileStatus MiddleBottomMiddle
        {
            get { return _MiddleBottomMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleBottomMiddle, value); }
        }

        private Brush _MiddleBottomMiddleFill = Brushes.Black;
        public Brush MiddleBottomMiddleFill
        {
            get
            {
                return _MiddleBottomMiddleFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.MiddleBottomMiddleFill, value);
            }
        }

        private TileStatus _MiddleBottomRight = TileStatus.Empty;
        public TileStatus MiddleBottomRight
        {
            get { return _MiddleBottomRight; }
            set { this.RaiseAndSetIfChanged(x => x.MiddleBottomRight, value); }
        }

        private Brush _MiddleBottomRightFill = Brushes.Black;
        public Brush MiddleBottomRightFill
        {
            get
            {
                return _MiddleBottomRightFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.MiddleBottomRightFill, value);
            }
        }
        #endregion

        #region InnerSquare
        private TileStatus _InnerTopLeft = TileStatus.Empty;
        public TileStatus InnerTopLeft
        {
            get { return _InnerTopLeft; }
            set { this.RaiseAndSetIfChanged(x => x.InnerTopLeft, value); }
        }

        private Brush _InnerTopLeftFill = Brushes.Black;
        public Brush InnerTopLeftFill
        {
            get
            {
                return _InnerTopLeftFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.InnerTopLeftFill, value);
            }
        }

        private TileStatus _InnerTopMiddle = TileStatus.Empty;
        public TileStatus InnerTopMiddle
        {
            get { return _InnerTopMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.InnerTopMiddle, value); }
        }

        private Brush _InnerTopMiddleFill = Brushes.Black;
        public Brush InnerTopMiddleFill
        {
            get
            {
                return _InnerTopMiddleFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.InnerTopMiddleFill, value);
            }
        }

        private TileStatus _InnerTopRight = TileStatus.Empty;
        public TileStatus InnerTopRight
        {
            get { return _InnerTopRight; }
            set { this.RaiseAndSetIfChanged(x => x.InnerTopRight, value); }
        }

        private Brush _InnerTopRightFill = Brushes.Black;
        public Brush InnerTopRightFill
        {
            get
            {
                return _InnerTopRightFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.InnerTopRightFill, value);
            }
        }

        private TileStatus _InnerMiddleLeft = TileStatus.Empty;
        public TileStatus InnerMiddleLeft
        {
            get { return _InnerMiddleLeft; }
            set { this.RaiseAndSetIfChanged(x => x.InnerMiddleLeft, value); }
        }

        private Brush _InnerMiddleLeftFill = Brushes.Black;
        public Brush InnerMiddleLeftFill
        {
            get
            {
                return _InnerMiddleLeftFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.InnerMiddleLeftFill, value);
            }
        }

        private TileStatus _InnerMiddleRight = TileStatus.Empty;
        public TileStatus InnerMiddleRight
        {
            get { return _InnerMiddleRight; }
            set { this.RaiseAndSetIfChanged(x => x.InnerMiddleRight, value); }
        }

        private Brush _InnerMiddleRightFill = Brushes.Black;
        public Brush InnerMiddleRightFill
        {
            get
            {
                return _InnerMiddleRightFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.InnerMiddleRightFill, value);
            }
        }

        private TileStatus _InnerBottomLeft = TileStatus.Empty;
        public TileStatus InnerBottomLeft
        {
            get { return _InnerBottomLeft; }
            set { this.RaiseAndSetIfChanged(x => x.InnerBottomLeft, value); }
        }

        private Brush _InnerBottomLeftFill = Brushes.Black;
        public Brush InnerBottomLeftFill
        {
            get
            {
                return _InnerBottomLeftFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.InnerBottomLeftFill, value);
            }
        }

        private TileStatus _InnerBottomMiddle = TileStatus.Empty;
        public TileStatus InnerBottomMiddle
        {
            get { return _InnerBottomMiddle; }
            set { this.RaiseAndSetIfChanged(x => x.InnerBottomMiddle, value); }
        }

        private Brush _InnerBottomMiddleFill = Brushes.Black;
        public Brush InnerBottomMiddleFill
        {
            get
            {
                return _InnerBottomMiddleFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.InnerBottomMiddleFill, value);
            }
        }

        private TileStatus _InnerBottomRight = TileStatus.Empty;
        public TileStatus InnerBottomRight
        {
            get { return _InnerBottomRight; }
            set { this.RaiseAndSetIfChanged(x => x.InnerBottomRight, value); }
        }

        private Brush _InnerBottomRightFill = Brushes.Black;

        public Brush InnerBottomRightFill
        {
            get
            {
                return _InnerBottomRightFill;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.InnerBottomRightFill, value);
            }
        }
        #endregion
    }
}
