using MySql.Data.MySqlClient;
MySqlConnection connection=new MySqlConnection();
connection.ConnectionString="Server=localhost;port=3306;user=root;password=welcome;database=t1";

connection.Open();
MySqlCommand command;
    int choice;


try{
    do{
         
        Console.WriteLine("1.Insert\n2.Update\n3.Delete\n4.Display\n5.Exit");
        Console.WriteLine("Enter Your Choice!!");
        choice=int.Parse(Console.ReadLine());
        switch(choice){
            case 1:
                Console.WriteLine("Enter ID: ");
                int id=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                string name=Console.ReadLine();
                Console.WriteLine("Enter Qty: ");
                int qty=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Price: ");
                int price=int.Parse(Console.ReadLine());
                string query1="insert into books values(@id,@name,@qty,@price)";
                command=new MySqlCommand(query1,connection);
                command.Parameters.AddWithValue("@id",id);
                command.Parameters.AddWithValue("@name",name);
                command.Parameters.AddWithValue("@qty",qty);
                command.Parameters.AddWithValue("@price",price);
                command.ExecuteNonQuery();
                break;   
            case 2:
                string query2="update books set name=@name,qty=@qty,price=@price where id=@id";
                command=new MySqlCommand(query2,connection);
                Console.WriteLine("Enter ID TO Update : ");
                id=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name TO Update : ");
                name=Console.ReadLine();
                Console.WriteLine("Enter Qty TO Update : ");
                qty=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Price TO Update : ");
                price=int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@id",id);
                command.Parameters.AddWithValue("@name",name);
                command.Parameters.AddWithValue("@qty",qty);
                command.Parameters.AddWithValue("@price",price); 
                command.ExecuteNonQuery();
                break;
            case 3:
                Console.WriteLine("Enter Id To Delete: ");
                id=int.Parse(Console.ReadLine());
                string query3="delete from books where id=@id";
                command=new MySqlCommand(query3,connection);
                command.Parameters.AddWithValue("@id",id);
                command.ExecuteNonQuery();
                break;
            case 4:
                 String dquery="Select * from books";
                 command = new MySqlCommand(dquery, connection);
                MySqlDataReader reader1=command.ExecuteReader();
                 while(reader1.Read()){
                id=int.Parse(reader1["id"].ToString());
                 name=reader1["name"].ToString();
                 qty=int.Parse(reader1["qty"].ToString());
                 price=int.Parse(reader1["price"].ToString());
                Console.WriteLine(id+" "+name+" "+qty+" Qty  "+price+" Rs");
                }
                reader1.Close();
                 break;
        
            default:  
                Console.WriteLine("Thank You For Visit!!");
                break;
           }
    }while(choice!=5);
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    connection.Close();
}