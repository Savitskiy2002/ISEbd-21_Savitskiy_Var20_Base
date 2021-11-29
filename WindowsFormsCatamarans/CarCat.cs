using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamarans
{
    public class CarCat : Vecatamaran
    {
        protected const int catamaranWidth = 90;
        protected const int catamaranHeight = 50;

        public CarCat(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public override void MoveBoat(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - catamaranWidth)
                    {
                        _startPosX += step;
                    }
                    break;

                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;

                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - catamaranHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawCatamaran(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brBlue = new SolidBrush(MainColor);
            Brush brGray = new SolidBrush(Color.Gray);

            g.FillRectangle(brBlue, _startPosX, _startPosY, 90, 10);
            g.FillRectangle(brBlue, _startPosX, _startPosY + 35, 90, 10);
            g.FillRectangle(brGray, _startPosX, _startPosY + 5, 90, 35);
            g.FillRectangle(brBlue, _startPosX + 35, _startPosY, 10, 45);
        }
    }
}