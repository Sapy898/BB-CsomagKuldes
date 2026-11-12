namespace ParcelDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parcel parcel1 = new Letter("L100", "Budapest, Fő utca 1.", 40);
            Parcel parcel2 = new Pallet("P300", "Győr, Ipari park 7.", 250000);

            Console.WriteLine(parcel1.GetDescription());
            Console.WriteLine(parcel2.GetDescription());

            Console.WriteLine(parcel1.CanGoInLocker());
            Console.WriteLine(parcel2.CanGoInLocker());
            Console.WriteLine("____________________________________");

            Parcel parcel3 = new Box("B200", "Szeged, Kossuth utca 3.", 3500, 45);
            Parcel parcel4 = new Box("B201", "Pécs, Széchenyi tér 2.", 2000, 80);
            Console.WriteLine(parcel3.GetShippingFee());
            Console.WriteLine(parcel4.GetShippingFee());
        }
    }
}
