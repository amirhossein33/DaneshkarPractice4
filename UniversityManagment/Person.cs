public abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual string GetDetails()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}