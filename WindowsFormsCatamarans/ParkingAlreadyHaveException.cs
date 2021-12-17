using System;

namespace WindowsFormsCatamarans
{
    public class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base("На парковке уже есть такое судно") 
        { }
    }

}
