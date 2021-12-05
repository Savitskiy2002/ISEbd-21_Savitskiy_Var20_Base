using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamarans
{
    class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i) : base("Не найден транспорт по месту " + i)
        { }
    }
}
