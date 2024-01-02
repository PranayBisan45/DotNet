using BOL;

namespace DAL;

public class DBManager
{
    public static List<Employee> getAll()
    {
        List<Employee> Emp = new List<Employee>();
        Emp.Add(new Employee(1, "Pranay", 9552007193));
        Emp.Add(new Employee(2, "Dnyanendra", 9845221965));
        Emp.Add(new Employee(3, "Abhay", 9887354677));
        Emp.Add(new Employee(4, "Sujit", 9568670193));
        Emp.Add(new Employee(5, "Bhupesh", 9896546467));
        return Emp;
    }
}