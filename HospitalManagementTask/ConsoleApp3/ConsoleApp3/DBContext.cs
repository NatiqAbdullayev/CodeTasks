
using ConsoleApp3.Enums;
using ConsoleApp3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3;

class DBContext
{
    public static Doctor[] doctors = [];
    public static Patient[] patients = [];
    public static Appointment[] appointments = [];

    public DBContext()
    {
        //doctors = [];
        //patients = [];
        //appointments = [];
    }

    Patient[] GetAllPatient()
    {

        //if (patient.Length == 0)
        //{
        //    Console.WriteLine("Not found any patient");
        //    return null;
        //}

        return patients;
    }
    public Doctor[] GetAllDoctor() { return doctors; }
    public Appointment[] GetAllAppointment() { return appointments; }



    public static void AddNewPatient(Patient patient)
    {
        if (patient is null)
        {
            Console.WriteLine("Patient cannot be null");
        }
        else
        {
            Array.Resize(ref patients, patients.Length + 1);
            patients[patients.Length - 1] = patient;
        }
    }
    public static void AddNewDoctor(Doctor doctor)
    {
        if (doctor is null)
        {
            Console.WriteLine("Doctor cannot be null");
        }
        else
        {
            Array.Resize(ref doctors, doctors.Length + 1);
            doctors[doctors.Length - 1] = doctor;
        }
    }
    public static void AddNewAppointment(Appointment appointment)
    {
        if (appointment is null)
        {
            Console.WriteLine("appointment cannot be null");
        }
        else
        {
            Array.Resize(ref appointments, appointments.Length + 1);
            appointments[appointments.Length - 1] = appointment;
        }
    }
}
