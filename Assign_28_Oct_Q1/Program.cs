using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assign_28_Oct_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connection = "Data Source=INLPF3KSCQZ;Initial Catalog=passport;trusted_connection=true";
                SqlConnection sqlcon = new SqlConnection(connection);
                sqlcon.Open();
                Console.WriteLine("1. Enter passport number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Enter candidate name: ");
                string name = Console.ReadLine();
                Console.WriteLine("3. Enter passport expiry date");
                string date_ = Console.ReadLine();
                Console.WriteLine("4. Enter years of validity");
                int validity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("5. Enetr applied through channel");
                string applied = Console.ReadLine();
                SqlCommand cmd = new SqlCommand("sp_passport", sqlcon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;//@pass_no,@candidate_name,@pass_expiry,@pass_validity,@applied_channel
                cmd.Parameters.AddWithValue("@pass_no", num);
                cmd.Parameters.AddWithValue("@candidate_name", name);
                cmd.Parameters.AddWithValue("@pass_expiry", date_);
                cmd.Parameters.AddWithValue("@pass_validity", validity);
                cmd.Parameters.AddWithValue("@applied_channel", applied);
                cmd.ExecuteNonQuery();
                Console.WriteLine("data pushing successfully");
                sqlcon.Close();
            }
            catch(SqlException e)
            {
                Console.WriteLine("this is sql exception" + e.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("This is exception in c#" + ex.Message);
            }
        }
    }
}