public class Hospital
{
    private static Hospital hospital;
    private static readonly object _lock = new();
    public List<Doctor> Doctors { get; set; } = [];
    public List<Room> Rooms { get; set; } = new List<Room>();

    private Hospital() { }

    public static Hospital GetInstance()
    {
        if (hospital == null)
        {
            lock (_lock)
            {
                hospital ??= new Hospital();
            }
        }
        return hospital;
    }

    public void AdmitPatient(Patient patient)
    {
        var availableRoom = Rooms.FirstOrDefault(r => r.GetPatients().Count < r.Capacity);
        if (availableRoom != null)
        {
            availableRoom.AssignPatient(patient);
        }
        else
        {
            Console.WriteLine("No available rooms for admission.");
        }
    }

    public void DischargePatient(Patient patient)
    {
        foreach (var room in Rooms)
        {
            var patientInRoom = room.GetPatients().FirstOrDefault(p => p.PatientId == patient.PatientId);
            if (patientInRoom != null)
            {
                room.GetPatients().Remove(patientInRoom);
                Console.WriteLine($"Patient {patient.Name} has been discharged.");
                return;
            }
        }
        Console.WriteLine("Patient not found in any room.");
    }
}
