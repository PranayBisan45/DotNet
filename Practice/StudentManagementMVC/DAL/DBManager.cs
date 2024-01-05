using BOL;
using MySql.Data.MySqlClient;
namespace DAL;
public class DBManager{
  public static  string connString=@"server=localhost;port=3306;user=root;password=Pran@1234; database=d4";
    public static List<Student> getData(){
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=connString;
        String query="select * from student";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        conn.Open();
        MySqlDataReader reader=cmd.ExecuteReader();
        List<Student> slist=new List<Student>();
        while(reader.Read()){
            Student s=new Student();
            int id=int.Parse(reader["id"].ToString());
            String namefirst=reader["nameFirst"].ToString();
            String namelast=reader["namelast"].ToString();
            String email=reader["emailid"].ToString();
                s.id=id;
                s.namefirst=namefirst;
                s.namelast=namelast;
                s.email=email;
                slist.Add(s);

        }
        return slist;
        

    }
    public static bool UpdateData(int id, String nameFirst, String namelast, String email){
        MySqlConnection conn= new MySqlConnection();
        conn.ConnectionString=connString;
        String query="update students set nameFirst=@first,namelast=@last,emailid=@email where id=@id1";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        conn.Open();
        cmd.Parameters.AddWithValue("@first",nameFirst);
        cmd.Parameters.AddWithValue("@last",namelast);
        cmd.Parameters.AddWithValue("@email",email);
        cmd.Parameters.AddWithValue("@id1",id);
        int a=cmd.ExecuteNonQuery();
        if(a>0){
            return true;
        }
        return false;
    }
        public static bool AddData(int id, String nameFirst, String namelast, String email){
        MySqlConnection conn= new MySqlConnection();
        conn.ConnectionString=connString;
        String query="insert into student values(@id1,@first,@last,@email)";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        conn.Open();
        cmd.Parameters.AddWithValue("@first",nameFirst);
        cmd.Parameters.AddWithValue("@last",namelast);
        cmd.Parameters.AddWithValue("@email",email);
        cmd.Parameters.AddWithValue("@id1",id);
        int a=cmd.ExecuteNonQuery();
        if(a>0){
            return true;
        }
        return false;
    }

     public static bool DeleteData(int id){
        MySqlConnection conn= new MySqlConnection();
        conn.ConnectionString=connString;
        String query="delete from Student where id=@id1";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        conn.Open();
    
        cmd.Parameters.AddWithValue("@id1",id);
        int a=cmd.ExecuteNonQuery();
        if(a>0){
            return true;
        }
        return false;
    }
}