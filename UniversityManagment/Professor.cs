public class Professor : Person
{
    public string ProfessorId { get; set; }
    public string Subject { get; set; }

    public Professor(string name, int age, string professorId, string subject) : base(name, age)
    {
        ProfessorId = professorId;
        Subject = subject;
    }

    public override string GetDetails()
    {
        return base.GetDetails() + $", ProfessorID: {ProfessorId}, Subject: {Subject}";
    }
}
