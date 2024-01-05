namespace Model;

public class Student{
    public int roll{get;set;}
    public string nameFirst{get;set;}
    public string nameLast{get;set;}

    public Student()
    {
        roll=0;
        nameFirst=null;
        nameLast=null;
    }

    public Student(int roll,String nameFirst,String nameLast) 
    {
        this.roll=roll;
        this.nameFirst=nameFirst;
        this.nameLast=nameLast;
    }
}