using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery
{
    public class CourierRoute
    {
        private List<IDeliverable> _stops;
        public List<IDeliverable> Stops
        {
            get { return _stops; }
        }
        public CourierRoute()
        {
            _stops = new List<IDeliverable>();
        }
        public void AddStop(IDeliverable item)
        {
            _stops.Add(item);
        }
    }
}
