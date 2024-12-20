class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new()
        {
            new Student("Ali Reza", 21, "S12345", "Computer Science"),
            new Student("Sara Ahmadi", 23, "S67890", "Mathematics"),
            new Professor("Dr. Hosseini", 45, "P11223", "Physics"),
            new Professor("Dr. Shariati", 50, "P33445", "Philosophy")
        };

        people
           .Select(person => person.GetDetails())
           .ToList()
           .ForEach(details => Console.WriteLine(details));
    }
}

