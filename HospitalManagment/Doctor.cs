public class Doctor : Person
{
    public int DoctorId { get; set; }
    public string Specialization { get; set; }
    private IDiagnosisStrategy diagnosisStrategy;

    public Doctor(string specialization)
    {
        Specialization = specialization;
        SetDiagnosisStrategy();
    }

    private void SetDiagnosisStrategy()
    {
        diagnosisStrategy = Specialization switch
        {
            "Cardiologist" => new HeartDiagnosisStrategy(),
            "Neurologist" => new BrainDiagnosisStrategy(),
            _ => throw new ArgumentException($"Specialization '{Specialization}' is not supported."),
        };
    }

    public void Diagnose(Patient patient)
    {
        diagnosisStrategy.Diagnose(patient);
    }

    public override string GetDetails()
    {
        return base.GetDetails() + $", Doctor ID: {DoctorId}, Specialization: {Specialization}";
    }
}
