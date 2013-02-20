using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurna.Models;

namespace Kurna.ViewModels
{
    public class BoardViewModel
    {
        #region OuterSquare
        public TileStatus OuterTopLeft = TileStatus.Empty;
        public TileStatus OuterTopMiddle = TileStatus.Empty;
        public TileStatus OuterTopRight = TileStatus.Empty;
        public TileStatus OuterMiddleLeft = TileStatus.Empty;
        public TileStatus OuterMiddleRight = TileStatus.Empty;
        public TileStatus OuterBottomLeft = TileStatus.Empty;
        public TileStatus OuterBottomMiddle = TileStatus.Empty;
        public TileStatus OuterBottomRight = TileStatus.Empty;
        #endregion

        #region MiddleSquare
        public TileStatus MiddleTopLeft = TileStatus.Empty;
        public TileStatus MiddleTopMiddle = TileStatus.Empty;
        public TileStatus MiddleTopRight = TileStatus.Empty;
        public TileStatus MiddleMiddleLeft = TileStatus.Empty;
        public TileStatus MiddleMiddleRight = TileStatus.Empty;
        public TileStatus MiddleBottomLeft = TileStatus.Empty;
        public TileStatus MiddleBottomMiddle = TileStatus.Empty;
        public TileStatus MiddleBottomRight = TileStatus.Empty;
        #endregion

        #region InnerSquare
        public TileStatus InnerTopLeft = TileStatus.Empty;
        public TileStatus InnerTopMiddle = TileStatus.Empty;
        public TileStatus InnerTopRight = TileStatus.Empty;
        public TileStatus InnerMiddleLeft = TileStatus.Empty;
        public TileStatus InnerMiddleRight = TileStatus.Empty;
        public TileStatus InnerBottomLeft = TileStatus.Empty;
        public TileStatus InnerBottomMiddle = TileStatus.Empty;
        public TileStatus InnerBottomRight = TileStatus.Empty;
        #endregion
    }
}
