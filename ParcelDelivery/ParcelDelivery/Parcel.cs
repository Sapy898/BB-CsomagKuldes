using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery
{
    public abstract class Parcel : IDeliverable
    {
        private string _code;
        private string _adress;
        private int _weightGrams;
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        public int WeightGrams
        {
            get { return _weightGrams; }
            set
            {
                if (value < 1)
                {
                    value = 1;
                    _weightGrams = value;
                }
                _weightGrams = value;
            }
        }
        private List<TrackingEvent> _events;
        public List<TrackingEvent> Events
        {
            get { return _events; }
        }
        public bool IsDelivered()
        {
            bool isDelivered = false;
            foreach (TrackingEvent item in Events)
            {
                if (item.Status == ParcelStatus.Delivered)
                {
                    isDelivered = true;
                }
            }
            return isDelivered;
        }
        public Parcel(string code, string adress, int weightGrams)
        {
            _code = code;
            _adress = adress;
            _weightGrams = weightGrams;
            _events = new List<TrackingEvent>();
        }
        public abstract int GetShippingFee();

        public virtual string GetDescription()
        {
            if (Events.Count > 0)
            {
                return $"{_code}({Events.Count} állapot): {_adress}, {_weightGrams}g, {this.GetShippingFee()} Ft";
            }
            else
                return $"{_code}: {_adress}, {_weightGrams}g, {this.GetShippingFee()} Ft";
        }
        public virtual bool CanGoInLocker()
        {
            if (_weightGrams <= 2000)
                return true;
            else
                return false;
        }

        public string GetAdress()
        {
            return _adress;
        }

        public TrackingEvent AddEvent(ParcelStatus status)
        {
            if (status == ParcelStatus.Delivered)
            {
                Console.WriteLine($"Nem lehet {this.GetDescription()} csomagnak új állapotot adni");
                return null;
            }
            else
            {
                TrackingEvent tE = new TrackingEvent(status, this);
                _events.Add(tE);
                return tE;
            }
        }
    }
}
