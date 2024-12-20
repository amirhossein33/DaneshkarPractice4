public class Patient : Person
{
    public int PatientId { get; set; }
    public List<string> MedicalHistory { get; set; } = [];

    public void AddToMedicalHistory(string illness)
    {
        MedicalHistory.Add(illness);
    }

    public override string GetDetails()
    {
        return base.GetDetails() + $", Patient ID: {PatientId}, Medical History: {string.Join(", ", MedicalHistory)}";
    }
}
