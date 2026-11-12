using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery
{
    public class FoodOrder : IDeliverable
    {
        private string _restaurant;
        private string _adress;
        public string Restaurant
        {
            get { return _restaurant; }
            set { _restaurant = value; }
        }
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        public FoodOrder(string restaurant, string adress)
        {
            _restaurant = restaurant;
            _adress = adress;
        }

        public string GetAdress()
        {
            return _adress;
        }

        public string GetDescription()
        {
            return $"Étel: ({_restaurant}): {_adress}";
        }
    }
}
