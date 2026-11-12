using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery
{
    public class TrackingEvent
    {
        private ParcelStatus _status;
        private Parcel _parcel;
        public ParcelStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public Parcel Parcel
        {
            get { return _parcel; }
        }
        public TrackingEvent(ParcelStatus status, Parcel parcel)
        {
            Status = status;
            _parcel = parcel;
        }

        public string GetDescription()
        {
            string statusText = _status switch
            {
                ParcelStatus.Posted => "feladva",
                ParcelStatus.InTransit => "kiszállítás alatt",
                ParcelStatus.Delivered => "kézbesítve",
                _ => "ismeretlen állapot"
            };

            return $"{_parcel.Code}: {statusText}";
        }       
    }
}
