namespace HR;

public class Person {
    private int pid;
    private string FName;
    private string LName;

    public Person() {
        this.pid=0;
        this.FName=null;
        this.LName=null;
    }

    public Person(int a,string b,string c) {
        this.pid=a;
        this.FName=b;
        this.LName=c;
    }

    public string FName{
        get{
            return this.FName;
        }
        set{
            this.FName = value;
        }
    }
    public string LName{
        get{
            return this.LName;
        }
        set{
            this.LName=value;
        }
    }

   
    public override string ToString() {
        return this.FName+" "+this.LName;
    }
}