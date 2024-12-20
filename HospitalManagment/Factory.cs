public abstract class PersonFactory
{
    public abstract Person CreatePerson();
}

public class PatientFactory : PersonFactory
{
    public override Person CreatePerson()
    {
        return new Patient();
    }
}

public class DoctorFactory : PersonFactory
{
    public override Person CreatePerson()
    {
        return new Doctor("General");
    }
}