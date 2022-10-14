
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Hjemmeside.Data
{
    public class SearchClass
    {
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BILER;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public List<Data> SQL()
        {
            List<Data> Carlist = new List<Data>();
           
            conn.Open();
            SqlCommand command = new SqlCommand(
                  "Select * from [BIL]", conn);

            //  command.Parameters.AddWithValue("@searchbutton", maerke);
            using (SqlDataReader reader = command.ExecuteReader())
            {


                while (reader.Read())
                {
                    Data car = new();

                    car.Maerke = reader["Maerke"].ToString();
                    car.Farve = reader["Farve"].ToString();
                    Carlist.Add(car);
                }

            }

            conn.Close();

            return Carlist;

        }
        public bool CreateCar(Data Car)
        {
            using (conn)
            {
                var cmd = new SqlCommand(
                    "INSERT INTO [Bil] " +
                    "VALUES (@maerke, @farve)", conn);
                cmd.Parameters.Add("@maerke", SqlDbType.NVarChar).Value = Car.Maerke;
                cmd.Parameters.Add("@farve", SqlDbType.NVarChar).Value = Car.Farve;


                conn.Open();
                if (cmd.ExecuteNonQuery() == 1) return true; else return false;
            }

        }

    }
}
 



 
 

