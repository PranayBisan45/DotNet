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




    public static int Regis(int id, string name, string pass,string fav)
    {

        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = @"server=localhost;port=3306;user=root;password=Pran@1234;database=d4";

        String query = "insert into Login values(@id,@name,@pass,@fav)";
        conn.Open();
        MySqlCommand command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@name", name);
        command.Parameters.AddWithValue("@pass", pass);
        command.Parameters.AddWithValue("@fav", fav);


        int a = command.ExecuteNonQuery();
        return a;
    }


    public static int Forgot(string reset,String fav)
    {

        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = @"server=localhost;port=3306;user=root;password=Pran@1234;database=d4";

        String query = "UPDATE Login SET password = @reset WHERE Favourite =@fav;";
        conn.Open();
        MySqlCommand command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@reset", reset);
        command.Parameters.AddWithValue("@fav", fav);

        int a = command.ExecuteNonQuery();
        return a;
    }

    public static int Delete(string pass,String fav)
    {

        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = @"server=localhost;port=3306;user=root;password=Pran@1234;database=d4";

        String query = "DELETE FROM Login WHERE password=@pass and Favourite=@fav;";
        conn.Open();
        MySqlCommand command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@pass", pass);
        command.Parameters.AddWithValue("@fav", fav);

        int a = command.ExecuteNonQuery();
        return a;
    }
}