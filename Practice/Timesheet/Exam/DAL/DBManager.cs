using BOL;
using MySql.Data.MySqlClient;
namespace DAL;

public class DBManager{
    public static string str="server=192.168.10.150;port=3306;user=dac17;password=welcome;database=dac17";
    public static List<Employee> getAll()
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString=str;
        string query="select * from Timesheet";
        MySqlCommand command=new MySqlCommand(query,conn);
        conn.Open();
        MySqlDataReader reader = command.ExecuteReader();
        List<Employee> list = new List<Employee>();
        while(reader.Read())
        {
            Employee e = new Employee();
            string date=reader["date"].ToString();
            string workDescription=reader["workDescription"].ToString();
            int duration= int.Parse(reader["duration"].ToString());
            string status=reader["status"].ToString();
            e.date=date;
            e.workDescription=workDescription;
            e.Duration=duration;
            e.status=status;
            list.Add(e);
        }
        return list;
    }

    public static bool AddEmp(string date,string desc,int duration,string status)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString=str;
        string query="insert into Timesheet values(@date,@desc,@duration,@status);";
        MySqlCommand command=new MySqlCommand(query,conn);
        conn.Open();
        command.Parameters.AddWithValue("@date",date);
        command.Parameters.AddWithValue("@desc",desc);
        command.Parameters.AddWithValue("@duration",duration);
        command.Parameters.AddWithValue("@status",status);

        int a = command.ExecuteNonQuery();
        if(a>0)
        {
            return true;
        }
        return false;
        }
        
    }
