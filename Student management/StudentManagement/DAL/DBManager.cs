using MySql.Data.MySqlClient;
namespace DAL;

public class DBManager{
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectingString= @"server=localhost;port=3306;user=root;passsword=Pran@1234;database=d4";
    boolean flag=false;
    public static boolean addStudent()
    {
        String query="insert into Student values(@id,@nameFirst,@nameLast)";
        conn.Open();
        MySqlCommand command = new MySqlCommand(query,conn);
        command.Parameters.AddWithvalue("@id",id);
        command.Parameters.AddWithvalue("@nameFirst",nameFirst);
        command.Parameters.AddWithvalue("@nameLast",nameLast);
        flag=command.ExecuteNonQuery();
        return flag;
    }
}