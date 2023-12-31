using MySql.Data.MySqlClient;

using Microsoft.AspNetCore.Mvc;



public class DBManager
{

    public static int Validate(string name, string pass)
    {

        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = @"server=localhost;port=3306;user=root;password=Pran@1234;database=d4";

        String query = "select id from Login where name=@name and password=@pass";

        MySqlCommand command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@name", name);
        command.Parameters.AddWithValue("@pass", pass);
        conn.Open();

        MySqlDataReader read = command.ExecuteReader();

        int a = 0;
        while (read.Read())
        {
            // Console.WriteLine(read.Read());
            // Console.WriteLine(read["name"].ToString());
            a = int.Parse(read["id"].ToString());
            Console.WriteLine(a);

        }
        return a;
    }




    public static int Regis(int id, string name, string pass)
    {

        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = @"server=localhost;port=3306;user=root;password=Pran@1234;database=d4";

        String query = "insert into Login values(@id,@name,@pass)";
        conn.Open();
        MySqlCommand command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@name", name);
        command.Parameters.AddWithValue("@pass", pass);


        int a = command.ExecuteNonQuery();
        return a;
    }
}