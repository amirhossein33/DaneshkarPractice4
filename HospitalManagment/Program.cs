class Program
{
    static void Main(string[] args)
    {
      
        var hospital = Hospital.GetInstance();

       
        hospital.Rooms.Add(new Room { RoomNumber = "101", Capacity = 2 });
        hospital.Rooms.Add(new Room { RoomNumber = "102", Capacity = 2 });

      
        var patientFactory = new PatientFactory();
        var doctorFactory = new DoctorFactory();

       
        var patient = (Patient)patientFactory.CreatePerson();
        patient.Name = "Farid ";
        patient.PatientId = 23;

        var doctor = (Doctor)doctorFactory.CreatePerson();
        doctor.Name = "Dr. Ali";
        doctor.DoctorId = 123;

       
        hospital.AdmitPatient(patient);

      
        doctor.Diagnose(patient);

        Console.WriteLine(patient.GetDetails());
    }
}
