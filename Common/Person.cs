namespace Common;

public class Person
{


    public string Name { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }

    public Person(string name, int age, int height)
    {
        Name = name;
        Age = age;
        Height = height;
    }

    public static Person GetMe()
    {
        return new Person("Kopcsak Patrik", 22, 183);
    }

    public override string? ToString()
    {
        return $"{Name}, {Age} éves, {Height} cm magas";
    }
}
