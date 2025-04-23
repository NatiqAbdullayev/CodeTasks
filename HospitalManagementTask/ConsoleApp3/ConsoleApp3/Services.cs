using ConsoleApp3.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3;

static class Services
{
    public static void AddNewPatient()
    {
        Console.Write("Adini qeyd edin:");
        string? name = Console.ReadLine();
        Console.Write("Soyadini qeyd edin:");
        string? surname = Console.ReadLine();
        Console.WriteLine("Cinsiyetini qeyd edin: Kisi üçün 1 qadin üçün 2 daxil edin");
        string? genderValue = Console.ReadLine();

        if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(surname) && !(genderValue.Equals("1") || genderValue.Equals("2")))
        {
            Console.WriteLine("Zehmet olmasa dogru daxil edin");
            return;
        }

        Patient p = new Patient(name, surname, (GenderEnum)int.Parse(genderValue));
        DBContext.AddNewPatient(p);
        Console.WriteLine("Ugurla elave edildi");
    }
    public static void AddNewDoctor()
    {
        Console.Write("Adini qeyd edin:");
        string? name = Console.ReadLine();
        Console.Write("Soyadini qeyd edin");
        string? surname = Console.ReadLine();
        Console.Write("Cinsiyetini qeyd edin: Kisi üçün 1 qadin üçün 2 daxil edin");
        string? genderValue = Console.ReadLine();


        try
        {

            Console.Write("Yasi daxil edin");
            string? age = Console.ReadLine();
            Console.WriteLine("Tecrube ili :");
            string? expYear = Console.ReadLine();

            Console.WriteLine("Zehmet olmasa Departmenti secin :");

            foreach (DepartmentEnum item in Enum.GetValues(typeof(DepartmentEnum)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }
            int departmentValue = int.Parse(Console.ReadLine());

            Doctor d = new Doctor(name, surname, int.Parse(age), int.Parse(expYear), (GenderEnum)int.Parse(genderValue), (DepartmentEnum)departmentValue);
            DBContext.AddNewDoctor(d);
            Console.WriteLine("Ugurla elave edildi");

        }
        catch (Exception e)
        {
            Console.WriteLine("Deyerleri dugun daxil edin");
        }
    }

    public static void AddNewAppointment()
    {
        try
        {
            Console.Write("Hekim id daxil edin :");
            int doctorId = int.Parse(Console.ReadLine());
            Console.Write("Xeste id daxil edin :");
            int patientId = int.Parse(Console.ReadLine());
            Appointment app = new Appointment(doctorId, patientId);
            DBContext.AddNewAppointment(app);
            Console.WriteLine("Ugurla elave edildi");

        }
        catch (Exception e)
        {
            Console.WriteLine("Id reqem tipinde olmalidir");
        }
    }

    public static void showStats()
    {
        Console.WriteLine("Secmek istediyiniz statistikani daxil edin : \n 1.Xestelerin sayi \n 2.Hekimlerin sayi \n 3.Randevularin sayi");

        string? exp = Console.ReadLine();
        switch (exp)
        {
            case "1": Console.Write("Pasiyentlerin sayi :"); HospitalStats.TotalPatientCount(); break;
            case "2": Console.Write("Pasiyentlerin sayi :"); HospitalStats.TotalDoctorCount(); break;
            case "3": Console.Write("Pasiyentlerin sayi :"); HospitalStats.TotalAppointmentCount(); break;
            default: Console.WriteLine("Zehmet olmasa duzgun daxil edin"); break;
        }

    }

}
