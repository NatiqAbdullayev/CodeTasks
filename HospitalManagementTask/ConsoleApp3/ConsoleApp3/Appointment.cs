using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3;

class Appointment
{
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public DateTime DateTime { get; set; }
    public Appointment(int doctorId, int patientId)
    {
        DoctorId = patientId;
        PatientId = patientId;
        DateTime = DateTime.Now;
    }
}
