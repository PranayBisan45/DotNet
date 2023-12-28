using Portal.Models;
namespace DAL;

public class DBManager {
    public static List<Student> getAllStudent() {
        List<Student> student = new List<Student>();
        student.Add(new Student{id=1,name="Pranay"});
        student.Add(new Student{id=2,name="Yash"});
        student.Add(new Student{id=3,name="Bhupendra"});
        student.Add(new Student{id=4,name="Sanket"});
        return student;
    }
}