using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery
{
    public class Letter : Parcel
    {
        public Letter(string code, string adress, int weightGrams) : base(code, adress, weightGrams)
        {
        }

        public override int GetShippingFee()
        {
            return 300;
        }
    }
}
