using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PHnewnew
{
    class ABlock
    {
        private Point _Loc;
        private Size _cSize = new Size(30, 30);
        private Rectangle _itsRect;
        private Brush _theBrush;
        private int _Modus;

        private int _xBorderAbsolute;
        private int _yBorderAbsolute;

        private Font _theFont = new Font("Microsoft Sans Serif", 16);

        public ABlock(Point StartLocation, int Mode, int AbsXBorder, int AbsYBorder)
        {
            _Loc = StartLocation;
            _itsRect = FormRectangle(_Loc);
            _theBrush = BrushMode(Mode);
            _Modus = Mode;
            _xBorderAbsolute = AbsXBorder;
            _yBorderAbsolute = AbsYBorder;
        }

        private Brush BrushMode(int Mod)
        {
            switch(Mod)
            {
                case 1: return Brushes.White;
                case 2: return Brushes.Green;
                case 3: return Brushes.Red;
                default: return Brushes.SlateGray;
            }
        }
        private Rectangle FormRectangle(Point CurLocation)
        {
            return new Rectangle(CurLocation, _cSize);
        }

        public void Draw(Graphics g, Pen p)
        {
            g.FillRectangle(_theBrush, _itsRect);
            if(_Modus == 2)
            {
                g.DrawString(" +", _theFont, Brushes.Black, _Loc);
            }
            if (_Modus == 3)
            {
                g.DrawString(" -", _theFont, Brushes.Black, _Loc);
            }
            if (_Modus == 4)
            {
                g.DrawString(" X", _theFont, Brushes.Black, _Loc);
            }
            g.DrawRectangle(p, _itsRect);
        }

        public int MoveLeftOrReturnEdgeRow()
        {
            int tempX = _Loc.X - 30;
            int tempY = _Loc.Y;
            if(tempX < _xBorderAbsolute)
            {
                return ((_Loc.Y - _yBorderAbsolute) / 30) + 1;
            }
            else
            {
                _Loc = new Point(tempX, tempY);
                _itsRect = FormRectangle(_Loc);
                return 0;
            }
        }

        public int Modus
        {
            get { return _Modus; }
        }
    }
}
