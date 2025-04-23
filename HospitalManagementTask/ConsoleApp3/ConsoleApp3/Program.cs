using ConsoleApp3.Models;

namespace ConsoleApp3;

internal class Program
{
    static void Main(string[] args)
    {
        bool status = true;

        do
        {
            Console.WriteLine("1. Yeni xəstə əlavə et\r\n2. Yeni həkim əlavə et\r\n3. Həkimə xəstə təyin et\r\n4. Xəstələrin siyahısı\r\n5. Həkimlərin siyahısı\r\n6. Statistikaya bax\r\n7. Çıxış");


            Console.Write("Zehmet olmasa secim edin :");
            string? exp = Console.ReadLine();

            switch (exp)
            {
                case "1":
                    Services.AddNewPatient();
                    break;
                case "2":
                    Services.AddNewDoctor();
                    break;
                case "3":
                    Services.AddNewAppointment();
                    break;
                case "4":
                    if (DBContext.patients.Length == 0)
                    {
                        Console.WriteLine("Xeste yoxdur ");
                    }
                    else
                    {
                        foreach (Patient item in DBContext.patients)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "5":
                    if (DBContext.doctors.Length == 0)
                    {
                        Console.WriteLine("Hekim yoxdur ");
                    }
                    else
                    {
                        foreach (Doctor item in DBContext.doctors)
                        {

                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "6":
                    Services.showStats();
                    break;
                case "7":
                    status = false;
                    break;

                default:
                    Console.WriteLine("Zehmet olmasa duzgun emeliyyat nomresi daxil edin.");
                    break;
            }


        }
        while (status);
    }
}
