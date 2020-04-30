using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4RPPOON
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

            /*
            //zadatak 3
            RentingConsolePrinter Printer = new RentingConsolePrinter();
            List<IRentable> Rented = new List<IRentable>();
            Book RentedBook = new Book("Clean Code");
            Video RentedVideo = new Video("Interstellar");
            Rented.Add(RentedBook);
            Rented.Add(RentedVideo);

            Printer.PrintTotalPrice(Rented);
            Printer.DisplayItems(Rented);

            Console.ReadKey(); */

            /*
            //Zadatak 4
            Book HotRentedBook = new Book("Wonder");
            Video HotRentedVideo = new Video("The Lion King");
            HotItem HotNewBook = new HotItem(HotRentedBook);
            HotItem HotNewVideo = new HotItem(HotRentedVideo);

            Rented.Add(HotNewBook);
            Rented.Add(HotNewVideo);

            Printer.PrintTotalPrice(Rented);
            Printer.DisplayItems(Rented);

            //Cijena najma povecala se za 1.99 za artikl koji pripada u HOT kategoriju, pored imena se ispisuje "Trending: ". Stari objekt
            prekrili smo novim informacijama


            Console.ReadKey(); */

            /*
            //Zadatak 5
            List<IRentable> flashSale = new List<IRentable>();
            DiscountedItem discountBook = new DiscountedItem(RentedBook, 20);
            DiscountedItem discountHotBook = new DiscountedItem(HotNewBook, 35);
            DiscountedItem discountVideo = new DiscountedItem(RentedVideo, 40);
            DiscountedItem discountHotVideo = new DiscountedItem(HotNewVideo, 35);

            flashSale.Add(discountBook);
            flashSale.Add(discountHotBook);
            flashSale.Add(discountVideo);
            flashSale.Add(discountHotVideo);

            Printer.PrintTotalPrice(flashSale);
            Printer.DisplayItems(flashSale);

            Console.ReadKey(); */

            //Zadatak 6
            EmailValidator emailValidator = new EmailValidator(8);
            PasswordValidator passwordValidator = new PasswordValidator(8);
            List<string> emails = new List<string>();
            List<string> passwords = new List<string>();

            string mail1 = "amelavorgic@gmail.com";
            string mail2 = "amelavorgic.com";
            string mail3 = "amela.vorgic@student.ferit.eu";

            string password1 = "12345678";
            string password2 = "jedan2tritri";
            string password3 = "NemaLozinke01";

            emails.Add(mail1);
            emails.Add(mail2);
            emails.Add(mail3);
            passwords.Add(password1);
            passwords.Add(password2);
            passwords.Add(password3);

            foreach (string email in emailList)
            {
                Console.WriteLine(emailValidator.IsValidAddress(email));
            }
            Console.ReadKey();

            foreach (string password in passwords)
            {
                Console.WriteLine(passwordValidator.IsValidPassword(password));
            }
            Console.ReadKey();
        }
    }
}

/* primjer.csv
0.1, 0.2, 0.3, 0.4, 0.5
1.1, 1.2, 1.3, 1.4, 1.5
2.1, 2.2, 2.3, 2.4, 2.5 */
