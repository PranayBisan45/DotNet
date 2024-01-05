using Model;
using DAL;
namespace BLL;

public class catalogMaanager{
    public static List<Student> getAll()
    {
        List<Student> list =DBManager.getAll();
        return list;
    }
}