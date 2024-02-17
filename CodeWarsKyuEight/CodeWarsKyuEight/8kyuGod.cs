public class Human { }

public class Man : Human
{
    public string Name { get; }

    public Man(string name)
    {
        Name = name;
    }
}

public class Woman : Human
{
    public string Name { get; }

    public Woman(string name)
    {
        Name = name;
    }
}

public class God
{
    public static Human[] Create()
    {
        // Create a new array of Humans with a length of 2
        Human[] humans = new Human[2];

        // Initialize the first element of the array with a new instance of Man named Adam
        humans[0] = new Man("Adam");

        // Initialize the second element of the array with a new instance of Woman named Eve
        humans[1] = new Woman("Eve");

        // Return the array containing a Man and a Woman
        return humans;
    }
}
