using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            BouquetDirector director = new BouquetDirector();

            var tulipBouquet = new Tulips();
            director.BuildBouquet(tulipBouquet);
            var tulipReport = tulipBouquet.GetBouquet();

            Console.WriteLine(tulipReport);
            Console.WriteLine("____________________________________\n");

            var roseBouquet = new Roses();
            director.BuildBouquet(roseBouquet);
            var bedReport = roseBouquet.GetBouquet();

            Console.WriteLine(bedReport);
            Console.WriteLine("____________________________________\n");

            var tableBuilder = new Mums();
            director.BuildBouquet(tableBuilder);
            var tableReport = tableBuilder.GetBouquet();

            Console.WriteLine(tableReport);
            Console.WriteLine("____________________________________\n");

        }
    }
}
