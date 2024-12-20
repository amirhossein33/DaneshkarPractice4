public class HeartDiagnosisStrategy : IDiagnosisStrategy
{
    public void Diagnose(Patient patient)
    {
        patient.AddToMedicalHistory("Heart Disease");
        Console.WriteLine("Diagnosing heart disease...");
    }
}

public class BrainDiagnosisStrategy : IDiagnosisStrategy
{
    public void Diagnose(Patient patient)
    {
        patient.AddToMedicalHistory("Brain Disorder");
        Console.WriteLine("Diagnosing brain disorder...");
    }
}

public class GeneralDiagnosisStrategy : IDiagnosisStrategy
{
    public void Diagnose(Patient patient)
    {
        patient.AddToMedicalHistory("General Checkup");
        Console.WriteLine("Performing general checkup...");
    }
}
public interface IDiagnosisStrategy
{
    void Diagnose(Patient patient);
}
