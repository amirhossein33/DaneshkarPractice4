public class Room
{
    public string RoomNumber { get; set; }
    public int Capacity { get; set; }
    private List<Patient> patients = new List<Patient>();

    public void AssignPatient(Patient patient)
    {
        if (patients.Count >= Capacity)
        {
            throw new RoomFullException("Room is full");
        }
        patients.Add(patient);
    }

    public List<Patient> GetPatients()
    {
        return patients;
    }
}
public class RoomFullException : Exception
{
    public RoomFullException(string message) : base(message) { }
}
