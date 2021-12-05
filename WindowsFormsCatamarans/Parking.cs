using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCatamarans
{
    public class Parking<T> where T : class, ITransport
    {
        private readonly List<T> _places;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int _maxCount;
        private const int _placeSizeWidth = 180;
        private const int _placeSizeHeight = 80;

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            _places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        private bool CheckFreePlace(int index)
        {
            return _places[index] == null;
        }

        public static bool operator +(Parking<T> p, T car)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            p._places.Add(car);
            return true;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index < 0 || index > p._places.Count)
            {
                throw new ParkingNotFoundException(index);
            }
            if (!p.CheckFreePlace(index))
            {
                T car = p._places[index];
                p._places.RemoveAt(index);
                return car;
            }
            return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(20 + i % 4 * _placeSizeWidth, i / 4 * _placeSizeHeight + 15, pictureWidth, pictureHeight);
                _places[i]?.DrawCatamaran(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for(int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места 
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
    }
}
