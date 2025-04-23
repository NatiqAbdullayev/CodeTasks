using ConsoleApp7.Models;

namespace ConsoleApp7;

internal class Program
{
    static void Main(string[] args)
    {
        //        1.Sisteme giris
        //0.Cixis

        //Sisteme giris oldugu zaman
        //1.Hotel yarat(Hotel yarat secdikden sonra bir otel yaradirsiz.eyni adda hotel ola bilmez: D)
        //2.Butun Hotelleri gor
        //3.Hotel sec(hotelin adini daxil ederek secilecek)
        //0.Exit
        bool status = true;

        do
        {
            Console.WriteLine("Menu:\r\n1.Hotel yarat\r\n2.Butun Hotelleri gor\r\n3.Hotel sec\r\n0.Exit");
            int exp = 0;
            switch (exp)
            {
                case 0:
                    status = false;
                    break;
                case 1:

                    Console.Write("Enter hotel name : ");
                    string name = Console.ReadLine();

                    Utils.CreateHotel(name);
                    break;
                case 2:
                    Utils.ShowAllHotels();
                    break;

                case 3:
                    Console.Write("Enter hotel name : ");
                    string hname = Console.ReadLine();
                    Utils.PickHotel(hname);
                    break;

                default:
                    Console.WriteLine("Yalnis secim");
                    break;
            }
        } while (status);


    }
}
