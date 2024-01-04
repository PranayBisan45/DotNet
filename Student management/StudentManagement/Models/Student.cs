namespace Model;

public class Student{
    public int roll{get;set;}
    public string firstName{get;set;}
    public string lasstName{get;set;}

    public Student()
    {
        roll=0;
        firstName=null;
        lasstName=null;
    }

    public Student(int roll,String firstName,String lasstName) 
    {
        this.roll=roll;
        this.firstName=firstName;
        this.lasstName=lasstName;
    }
}