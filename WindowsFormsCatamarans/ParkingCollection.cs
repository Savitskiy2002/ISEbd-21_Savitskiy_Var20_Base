using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamarans
{
    public class ParkingCollection
    {
        readonly Dictionary<string, Parking<ITransport>> parkingStages;
        private readonly int pictureWidth;
        private readonly int pictureHeight;

        public List<string> Keys => parkingStages.Keys.ToList();

        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        } 

        public void AddParking(string name)
        {
            if (!parkingStages.ContainsKey(name)) parkingStages.Add(name, new Parking<ITransport>(pictureWidth, pictureHeight));
        }
        
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name)) parkingStages.Remove(name);
        }
        
        public Parking<ITransport> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
    }
}
