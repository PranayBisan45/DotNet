using BOL;
using DAL;
using Org.BouncyCastle.Bcpg.OpenPgp;
namespace BLL;

public class catalog{
    public static List<Employee> getAll()
    {
        List<Employee> list = new List<Employee>();
        list=DBManager.getAll();
        return list;
    }

    public static bool Add(string date,string desc,int duration,string status)
    {
       bool flag=DBManager.AddEmp(date,desc,duration,status);;
        if(flag)
        {
            return true;
        }
        return false;
    }
}