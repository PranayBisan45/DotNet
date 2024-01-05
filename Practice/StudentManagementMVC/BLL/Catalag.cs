using BOL;
using DAL;
namespace BLL;
public class Catalog{
   public static List<Student> getAll(){
    List<Student> st=DBManager.getData();
    return st;
   }
   public static bool Update(int id, String nameFirst, String namelast, String email){
    bool flag=DBManager.UpdateData(id,nameFirst,namelast,email);
    return flag;
   }
    public static bool Delete(int id){
    bool flag=DBManager.DeleteData(id);
    return flag;
   }
   public static bool AddData(int id, String nameFirst, String namelast, String email){
      bool flag=DBManager.AddData(id,nameFirst,namelast,email);
    return flag;
   }
}