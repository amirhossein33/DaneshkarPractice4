public abstract class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? NationalId { get; set; }

    public virtual string GetDetails()
    {
        return $"Name: {Name}, Age: {Age}, National ID: {NationalId}";
    }
}
