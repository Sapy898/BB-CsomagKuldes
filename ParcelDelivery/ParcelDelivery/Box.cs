using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery
{
    public class Box : Parcel
    {
        private int _longestSideCm;
        public int LongestSideCm
        {
            get { return _longestSideCm; }
            set 
            {
                if(value <= 0)
                    _longestSideCm = 0;
                else
                    _longestSideCm = value;
            }
        }
        public Box(string code, string adress, int weightGrams, int longestSideCm) : base(code, adress, weightGrams)
        {
            _longestSideCm = longestSideCm;
        }
        public override int GetShippingFee()
        {
            if (WeightGrams > 5000 ||LongestSideCm > 60)
                return 2400;
            else
                return 1200;
        }

        
    }
}
