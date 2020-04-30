using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4-RPPOON
{
    class Program
{
    static void Main(string[] args)
    {
        /*
        //Zadatak 2
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        Dataset testdataset = new Dataset("primjer.csv");

        Analyzer3rdParty service = new Analyzer3rdParty();
        Adapter adapter = new Adapter(service);

        adapter.CalculateAveragePerRow(testdataset);
        adapter.CalculateAveragePerColumn(testdataset);

        Console.ReadKey();*/

        //zadatak 3
        RentingConsolePrinter Printer = new RentingConsolePrinter();
        List<IRentable> Rented = new List<IRentable>();
        Book RentedBook = new Book("Clean Code");
        Video RentedVideo = new Video("Interstellar");
        Rented.Add(RentedBook);
        Rented.Add(RentedVideo);

        Printer.PrintTotalPrice(Rented);
        Printer.DisplayItems(Rented);

        Console.ReadKey();
    }
}
}

/* primjer.csv
0.1, 0.2, 0.3, 0.4, 0.5
1.1, 1.2, 1.3, 1.4, 1.5
2.1, 2.2, 2.3, 2.4, 2.5 */
