namespace BOL;

public class Employee
{
    public int id { get; set; }
    public String name { get; set; }
    public long number { get; set; }

    public Employee()
    {
        id = 1;
        name = "Pranay123";
        number = 9666366636;
    }

    public Employee(int id, String name, long number)
    {
        this.id = id;
        this.name = name;
        this.number = number;
    }
}