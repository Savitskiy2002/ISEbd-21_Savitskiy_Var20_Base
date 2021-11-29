using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamarans
{
    public class CatamaranGrade : CarCat
    {
        public Color DopColor { private set; get; }

        public bool Sail { private set; get; }

        public bool Motor { private set; get; }

        public bool Poplavok { private set; get; }

        public CatamaranGrade(int maxSpeed, float weight, Color mainColor, Color dopColor, bool sail, bool motor, bool poplavok) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Sail = sail;
            Motor = motor;
            Poplavok = poplavok;
        }

        public override void DrawCatamaran(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(Color.Black);
            base.DrawCatamaran(g);

            //if (Sail)
            //{
                Brush brGray = new SolidBrush(Color.Black);
                g.FillRectangle(brGray, _startPosX + 20, _startPosY + 17, 65, 5);
                g.FillRectangle(brGray, _startPosX + 20, _startPosY + 22, 65, 5);

                Brush brBlack = new SolidBrush(Color.Black);
                g.FillRectangle(brBlack, _startPosX + 50, _startPosY + 10, 3, 7);
                g.FillRectangle(brBlack, _startPosX + 60, _startPosY + 10, 3, 7);
                g.FillRectangle(brBlack, _startPosX + 60, _startPosY + 27, 3, 8);
                g.FillRectangle(brBlack, _startPosX + 50, _startPosY + 27, 3, 8);
            //}

            if (Motor)
            {
                //Brush brBlack = new SolidBrush(Color.Black);
                g.FillRectangle(brBlack, _startPosX, _startPosY - 5, 90, 5);
                g.FillRectangle(brBlack, _startPosX, _startPosY + 43, 90, 7);
                g.FillRectangle(brBlack, _startPosX + 15, _startPosY - 5, 3, 45);
                g.FillRectangle(brBlack, _startPosX - 5, _startPosY + 15, 20, 15);
            }
            if (Poplavok)
            {
                Brush brBlue = new SolidBrush(Color.Blue);
                g.FillRectangle(brBlue, _startPosX, _startPosY, 90, 10);
                g.FillRectangle(brBlue, _startPosX, _startPosY + 35, 90, 10);
                g.FillRectangle(brBlue, _startPosX + 35, _startPosY, 10, 35);
            }
        }
    }
}
