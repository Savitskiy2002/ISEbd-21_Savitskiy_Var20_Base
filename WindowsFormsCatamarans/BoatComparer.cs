using System.Collections.Generic;

namespace WindowsFormsCatamarans
{
    public class BoatComparer : IComparer<ITransport>
    {
        public int Compare(ITransport x, ITransport y)
        {
            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().FullName.CompareTo(y.GetType().FullName);
            }
            if (x.GetType() == y.GetType() && x is CatamaranGrade)
            {
                return ComparerCatamaran((CatamaranGrade)x, (CatamaranGrade)y);
            }
            if (x.GetType() == y.GetType() && x is CarCat)
            {
                return ComparerBoat((CarCat)x, (CarCat)y);
            }
            return 0;
        }

        private int ComparerBoat(CarCat x, CarCat y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerCatamaran(CatamaranGrade x, CatamaranGrade y)
        {
            var res = ComparerBoat(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Sail != y.Sail)
            {
                return x.Sail.CompareTo(y.Sail);
            }
            if (x.Motor != y.Motor)
            {
                return x.Motor.CompareTo(y.Motor);
            }
            return 0;
        }
    }
}
