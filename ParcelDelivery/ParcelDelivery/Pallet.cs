using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery
{
    public class Pallet : Parcel
    {
        public Pallet(string code, string adress, int weightGrams) : base(code, adress, weightGrams)
        {
        }

        public override int GetShippingFee()
        {
            int kg= WeightGrams / 1000;

            return 8000+ (kg * 30);
        }
    }
}
