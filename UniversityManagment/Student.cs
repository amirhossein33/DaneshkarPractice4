public class Student : Person
{
    public string StudentID { get; set; }
    public string Major { get; set; }

    public Student(string name, int age, string studentID, string major) : base(name, age)
    {
        StudentID = studentID;
        Major = major;
    }

    public override string GetDetails()
    {
        return base.GetDetails() + $", StudentID: {StudentID}, Major: {Major}";
    }
}