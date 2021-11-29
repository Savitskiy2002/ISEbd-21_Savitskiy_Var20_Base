using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamarans
{
    class Catamaran
    {
        private float _startPosX;

        private float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;

        private const int catamaranWidth = 90;

        private const int catamaranHeight = 50;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool Sail { private set; get; }

        public bool Motor { private set; get; }

        public Catamaran(int maxSpeed, float weight, Color mainColor, Color dopColor, bool sail, bool motor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Sail = sail;
            Motor = motor;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureHeight = height;
            _pictureWidth = width;
        }

        public void MoveBoat(Direction direction)
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

        public void DrawCatamaran(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            if (Sail)
            {
                Brush brGray = new SolidBrush(Color.Gray);
                g.FillRectangle(brGray, _startPosX + 20, _startPosY + 17, 65, 5);
                g.FillRectangle(brGray, _startPosX + 20, _startPosY + 22, 65, 5);

                Brush brBlack = new SolidBrush(Color.Black);
                g.FillRectangle(brBlack, _startPosX + 50, _startPosY + 10, 3, 7);
                g.FillRectangle(brBlack, _startPosX + 60, _startPosY + 10, 3, 7);
                g.FillRectangle(brBlack, _startPosX + 60, _startPosY + 27, 3, 8);
                g.FillRectangle(brBlack, _startPosX + 50, _startPosY + 27, 3, 8);
            }

            if (Motor)
            {
                Brush brBlack = new SolidBrush(Color.Black);
                g.FillRectangle(brBlack, _startPosX, _startPosY - 5, 30, 7);
                g.FillRectangle(brBlack, _startPosX, _startPosY + 43, 30, 7);
                g.FillRectangle(brBlack, _startPosX + 15, _startPosY - 5, 3, 45);
                g.FillRectangle(brBlack, _startPosX - 5, _startPosY + 15, 20, 15);

            }
            Brush brBlue = new SolidBrush(Color.Blue);
            g.FillRectangle(brBlue, _startPosX, _startPosY, 90, 10);
            g.FillRectangle(brBlue, _startPosX, _startPosY + 35, 90, 10);
            g.FillRectangle(brBlue, _startPosX + 35, _startPosY, 10, 35);
        }
    }
}