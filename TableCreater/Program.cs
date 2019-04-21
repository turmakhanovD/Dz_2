using System.Data.SqlClient;

namespace TableCreater
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection cn = new SqlConnection())
            {
               
                string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=DB1;Integrated Security=True;Pooling=False";

                cn.ConnectionString = connectionString;
                cn.Open();
                // Работа с базой данных
                string command = "create table gruppa(id int identity primary key, name nvarchar(40) not null )";
                var sqlCommand = new SqlCommand(command, cn);
                sqlCommand.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
