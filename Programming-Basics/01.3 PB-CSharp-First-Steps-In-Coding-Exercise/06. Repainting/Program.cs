using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNylon = int.Parse(Console.ReadLine());
            int quantityPaint = int.Parse(Console.ReadLine());
            int quantityDiluent = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());

            double priceNylon = 1.5;
            double pricePaint = 14.5;
            double priceDiluent = 5.0;

            double sumForMaterials = ((quantityNylon + 2) * priceNylon) + ((quantityPaint + quantityPaint * 10 / 100.0) * pricePaint) 
                + (quantityDiluent * priceDiluent) + 0.4;
            double sumForWork = hoursWork * (sumForMaterials * (30 / 100.0));

            double totalSum = sumForMaterials + sumForWork;

            Console.WriteLine(totalSum);
        }
    }
}
