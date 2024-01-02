using BOL;
using DAL;

namespace BLL;

public class Catalog
{
    public List<Employee> getAll()
    {
        List<Employee> emp = new List<Employee>();
        emp = DBManager.getAll();
        return emp;
    }

    public static Employee getData(int id)
    {
        List<Employee> emp = DBManager.getAll();

        Employee Empl = emp.Find((Employee) =>
        Employee.id == id);
        return Empl;


    }
}