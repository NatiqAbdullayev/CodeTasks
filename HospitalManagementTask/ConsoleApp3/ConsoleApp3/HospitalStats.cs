using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3;

public static class HospitalStats
{
    public static void TotalPatientCount()
    {
        Console.WriteLine(DBContext.patients.Length);
    }
    public static void TotalDoctorCount() { Console.WriteLine(DBContext.doctors.Length); }
    public static void TotalAppointmentCount() { Console.WriteLine(DBContext.appointments.Length); }
}
