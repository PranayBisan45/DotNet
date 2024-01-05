using MySql.Data.MySqlClient;
using Model;

namespace DAL;

public  static class DBManager{
    
    static bool flag=false;
    public static bool addStudent(int roll,string nameFirst,string nameLast)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString="server=localhost;port=3306;user=root;password=Pran@1234;database=d4";
        String query="insert into Student1 values(@roll,@nameFirst,@nameLast)";
        conn.Open();
        MySqlCommand command = new MySqlCommand(query,conn);
        
        command.Parameters.AddWithValue("@roll",roll);
        command.Parameters.AddWithValue("@nameFirst",nameFirst);
        command.Parameters.AddWithValue("@nameLast",nameLast);
        int a=command.ExecuteNonQuery();
        if(a>0)
        {
            flag=true;
        }
        return flag;
    }

    public static List<Student> getAll()
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString="server=localhost;port=3306;user=root;password=Pran@1234;database=d4;";
        string query="select * from Student1";
        conn.Open();
        MySqlCommand command = new MySqlCommand(query,conn);
        MySqlDataReader reader= command.ExecuteReader();
        List<Student> slist= new List<Student>();
        while(reader.Read())
        {
            Student s = new Student();
            int roll = int.Parse(reader["roll"].ToString());
            String nameFirst= reader["nameFirst"].ToString();
            String nameLast= reader["nameLast"].ToString();
            s.roll=roll;
            s.nameFirst=nameFirst;
            s.nameLast= nameLast;
            slist.Add(s);
        }
        return slist;
    }
}