using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Class1
    {
    }
    public class DataLayer
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-KOIN233;Initial Catalog=KPMS;Integrated Security=True");
        public int login(string user,string pass)
        {
            string query = "select * from Admin where Username='" + user + "' and Password='" + pass + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
                return 1;
            else
                return 0;
        }
        public int InsertCarData(string fname,string lname,string plate,string contact, string brand,string color,bool cplc,bool wash,bool shade)
        {
            int a = 0;
            DataTable dt = new DataTable();
            sqlcon.Open();
            SqlCommand com = new SqlCommand("select Plate_No from carinfo where Plate_No='" + plate + "'", sqlcon);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            if (dt.Rows.Count>0)
            {
                return a;
            } 
            SqlDataAdapter sqladp = new SqlDataAdapter("Insert into Carinfo values('" + DateTime.Now + "','" + fname+"','" + lname+ "','" + plate + "','" + contact+"','" + brand + "','" + color + "','" + cplc + "','" + wash + "','" + shade + "')",sqlcon);
            sqladp.Fill(dt);
            sqladp = new SqlDataAdapter("Insert into Duplicate values('" + DateTime.Now + "','" + fname + "','" + lname + "','" + plate + "','" + contact + "','" + brand + "','" + color + "','" + cplc + "','" + wash + "','" + shade + "')", sqlcon);
            sqladp.Fill(dt);
            if (wash == true && shade == true)
            {
                sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 230 + "','"+"CAR"+"')", sqlcon);
                sqladp.Fill(dt);
            }
            else if(wash == true && shade == false)
            {
                 sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 180 + "','" + "CAR" + "')", sqlcon);
                sqladp.Fill(dt);
            }
            else if(wash == false && shade == true)
            {
                 sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 130 + "','" + "CAR" + "')", sqlcon);
                sqladp.Fill(dt);
            }
            else
            {
                 sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 80 + "','" + "CAR" + "')", sqlcon);
                sqladp.Fill(dt);
            }
            sqlcon.Close();
            return 1;
        }
        public int InsertBusData(string fname,string lname,string contact,string plate,string brand,string color,bool cplc,bool wash,bool shade)
        {
            int a = 0;
            DataTable dt = new DataTable();
            sqlcon.Open();
            SqlCommand com = new SqlCommand("select Plate_No from Businfo where Plate_No='" + plate + "'", sqlcon);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return a;
            }
            SqlDataAdapter sqladp = new SqlDataAdapter("Insert into Businfo values('" + DateTime.Now + "','" + fname + "','" + lname + "','" + plate + "','" + contact + "','" + brand + "','" + color + "','" + cplc + "','" + wash + "','" + shade + "')", sqlcon);
            sqladp.Fill(dt);
            sqladp = new SqlDataAdapter("Insert into Duplicate values('" + DateTime.Now + "','" + fname + "','" + lname + "','" + plate + "','" + contact + "','" + brand + "','" + color + "','" + cplc + "','" + wash + "','" + shade + "')", sqlcon);
            sqladp.Fill(dt);
            if (wash == true && shade == true && cplc == true)
            {
                 sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 300 + "','" + "BUS" + "')", sqlcon);
                sqladp.Fill(dt);
            }
            else if (wash == true && shade == false && cplc == true)
            {
                sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 250 + "','" + "BUS" + "')", sqlcon);
                sqladp.Fill(dt);
            }
            else if (wash == false && shade == true && cplc == true)
            {
                sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 150 + "','" + "BUS" + "')", sqlcon);
                sqladp.Fill(dt);
            }
            else
            {
                sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 100 + "','" + "BUS" + "')", sqlcon);
                sqladp.Fill(dt);
            }
            sqlcon.Close();
            return 1;
        }
        public int InsertScooterData(string fname, string lname, string contact, string plate, string brand, string color, bool cplc, bool wash, bool shade)
        {
            int a = 0;
            DataTable dt = new DataTable();
            sqlcon.Open();
            SqlCommand com = new SqlCommand("select Plate_No from Scooterinfo where Plate_No='" + plate + "'", sqlcon);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return a;
            }
            SqlDataAdapter sqladp = new SqlDataAdapter("Insert into Scooterinfo values('" + DateTime.Now + "','" + fname + "','" + lname + "','" + plate + "','" + contact + "','" + brand + "','" + color + "','" + cplc + "','" + wash + "','" + shade + "')", sqlcon);
            sqladp.Fill(dt);
            sqladp = new SqlDataAdapter("Insert into Duplicate values('" + DateTime.Now + "','" + fname + "','" + lname + "','" + plate + "','" + contact + "','" + brand + "','" + color + "','" + cplc + "','" + wash + "','" + shade + "')", sqlcon);
            sqladp.Fill(dt);
            if (wash == true && shade == true && cplc == true)
            {
                sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 180 + "','" + "SCOOTER" + "')", sqlcon);
                sqladp.Fill(dt);
            }
            else if (wash == true && shade == false && cplc == true)
            {
                sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 130 + "','" + "SCOOTER" + "')", sqlcon);
                sqladp.Fill(dt);
            }
            else if (wash == false && shade == true && cplc == true)
            {
                sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 100 + "','" + "SCOOTER" + "')", sqlcon);
                sqladp.Fill(dt);
            }
            else
            {
                sqladp = new SqlDataAdapter("Insert into Payment values('" + DateTime.Now + "','" + plate + "','" + 50 + "','" + "SCOOTER" + "')", sqlcon);
                sqladp.Fill(dt);
            }
            sqlcon.Close();
            return 1;
        }
        public int CarDeparture(string fname,string lname,string plate)
        {
            int a = 0;
            DataTable dt = new DataTable();
            sqlcon.Open();
            SqlCommand com = new SqlCommand("select Plate_No from Carinfo where (First_Name='" + fname + "') and (Plate_No='" + plate + "') or (Last_Name='" + lname + "') and (Plate_No='" + plate + "') ", sqlcon);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                SqlDataAdapter sqladp = new SqlDataAdapter();
                string sql = "delete from Carinfo where (First_Name='" + fname + "') and (Plate_No='" + plate + "') or (Last_Name='" + lname + "') and (Plate_No='" + plate + "')";
                sqladp.DeleteCommand = sqlcon.CreateCommand();
                sqladp.DeleteCommand.CommandText = sql;
                sqladp.DeleteCommand.ExecuteNonQuery();
                
                return a;
            }
            sqlcon.Close();
            return 1;
        }
        public int BusDeparture(string fname, string lname, string plate)
        {
            int a = 0;
            DataTable dt = new DataTable();
            sqlcon.Open();
            SqlCommand com = new SqlCommand("select Plate_No from businfo where (First_Name='" + fname + "') and (Plate_No='" + plate + "') or (Last_Name='" + lname + "') and (Plate_No='" + plate + "') ", sqlcon);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                SqlDataAdapter sqladp = new SqlDataAdapter();
                string sql = "delete from businfo where (First_Name='" + fname + "') and (Plate_No='" + plate + "') or (Last_Name='" + lname + "') and (Plate_No='" + plate + "') ";
                
                sqladp.DeleteCommand = sqlcon.CreateCommand();
                sqladp.DeleteCommand.CommandText = sql;
                sqladp.DeleteCommand.ExecuteNonQuery();
                sqlcon.Close();
                return a;
            }
            sqlcon.Close();
            return 1;
        }
        public int ScooterDeparture(string fname, string lname, string plate)
        {
            int a = 0;
            DataTable dt = new DataTable();
            sqlcon.Open();
            SqlCommand com = new SqlCommand("select Plate_No from scooterinfo where (First_Name='" + fname + "') and (Plate_No='" + plate + "') or (Last_Name='" + lname + "') and (Plate_No='" + plate + "') ", sqlcon);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                SqlDataAdapter sqladp = new SqlDataAdapter();
                string sql = "delete from scooterinfo where (First_Name='" + fname + "') and (Plate_No='" + plate + "') or (Last_Name='" + lname + "') and (Plate_No='" + plate + "') ";
               
                sqladp.DeleteCommand = sqlcon.CreateCommand();
                sqladp.DeleteCommand.CommandText = sql;
                sqladp.DeleteCommand.ExecuteNonQuery();
                sqlcon.Close();
                return a;
            }
            sqlcon.Close();
            return 1;
        }

        public string Total()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Totalvehicles";
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlout = new SqlParameter
            {
                ParameterName = "@N",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(sqlout);
            cmd.ExecuteNonQuery();
            string a=sqlout.Value.ToString();
            sqlcon.Close();
            return a;
        }
        public string CarsCash()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "caramount";
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlout = new SqlParameter
            {
                ParameterName = "@amount",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(sqlout);
            cmd.ExecuteNonQuery();
            string a = sqlout.Value.ToString();
            sqlcon.Close();
            return a;
        }
        public string BusesCash()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "busamount";
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlout = new SqlParameter
            {
                ParameterName = "@amount",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(sqlout);
            cmd.ExecuteNonQuery();
            string a = sqlout.Value.ToString();
            sqlcon.Close();
            return a;
        }
        public string ScootersCash()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "scooteramount";
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlout = new SqlParameter
            {
                ParameterName = "@amount",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(sqlout);
            cmd.ExecuteNonQuery();
            string a = sqlout.Value.ToString();
            sqlcon.Close();
            return a;
        }
        public string NoOfCars()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "noofcars";
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlout = new SqlParameter
            {
                ParameterName = "@vehi",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(sqlout);
            cmd.ExecuteNonQuery();
            string a = sqlout.Value.ToString();
            sqlcon.Close();
            return a;
        }
        public string NoOfBuses()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "noofbuses";
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlout = new SqlParameter
            {
                ParameterName = "@vehi",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(sqlout);
            cmd.ExecuteNonQuery();
            string a = sqlout.Value.ToString();
            sqlcon.Close();
            return a;
        }
        public string NoOfScooters()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "noofscooters";
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlout = new SqlParameter
            {
                ParameterName = "@vehi",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(sqlout);
            cmd.ExecuteNonQuery();
            string a = sqlout.Value.ToString();
            sqlcon.Close();
            return a;
        }
        public string Washed()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "washed";
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlout = new SqlParameter
            {
                ParameterName = "@wash",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(sqlout);
            cmd.ExecuteNonQuery();
            string a = sqlout.Value.ToString();
            sqlcon.Close();
            return a;
        }
        public string Shaded()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "shade";
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlout = new SqlParameter
            {
                ParameterName = "@shade",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(sqlout);
            cmd.ExecuteNonQuery();
            string a = sqlout.Value.ToString();
            sqlcon.Close();
            return a;
        }
        public string Totalam()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "totalcash";
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlout = new SqlParameter
            {
                ParameterName = "@cash",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(sqlout);
            cmd.ExecuteNonQuery();
            string a = sqlout.Value.ToString();
            sqlcon.Close();
            return a;
        }
    }
}