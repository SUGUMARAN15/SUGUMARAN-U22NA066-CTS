using System;
using System.Data;
using System.Data.SqlClient;

public class Exercise30
{
    public static void Main()
    {
        string connectionString = ""Data Source=localhost;Initial Catalog=YourDatabase;Integrated Security=True"";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            // Insert
            SqlCommand insert = new SqlCommand(""INSERT INTO Employees (Name) VALUES ('John')"", conn);
            insert.ExecuteNonQuery();

            // Read
            SqlCommand read = new SqlCommand(""SELECT * FROM Employees"", conn);
            SqlDataReader reader = read.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($""Employee: {reader[""Name""]}"");
            }
            reader.Close();

            // Update
            SqlCommand update = new SqlCommand(""UPDATE Employees SET Name = 'Jane' WHERE Name = 'John'"", conn);
            update.ExecuteNonQuery();

            // Delete
            SqlCommand delete = new SqlCommand(""DELETE FROM Employees WHERE Name = 'Jane'"", conn);
            delete.ExecuteNonQuery();
        }
    }
}
