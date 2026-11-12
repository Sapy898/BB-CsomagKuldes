using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery
{
    public abstract class Parcel
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
        public Parcel(string code, string adress, int weightGrams)
        {
            _code = code;
            _adress = adress;
            _weightGrams = weightGrams;
        }
        public abstract int GetShippingFee();

        public virtual string GetDescription()
        {
            return $"{_code}: {_adress}, {_weightGrams}g, {this.GetShippingFee()} Ft";
        }
        public virtual bool CanGoInLocker()
        {
            if(_weightGrams <= 2000)
                return true;
            else
                return false;
        }

    }
}
