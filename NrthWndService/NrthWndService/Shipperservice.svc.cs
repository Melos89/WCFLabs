using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NrthWndService
{
    public class Shipperservice : IShipperservice
    {
        string connectionString = "Data Source=Badger;Initial Catalog=NORTHWND;Integrated Security=True";
        DataTable table = new DataTable();

        public Shipper GetShipper(int id)
        {
            var shipper = new Shipper();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT [ShipperID],[CompanyName],[Phone] FROM [dbo].[Shippers] WHERE [ShipperID] = @ID", connection);
                SqlParameter idParam = new SqlParameter();

                idParam.ParameterName = "@ID";
                idParam.Value = id;
                cmd.Parameters.Add(idParam);


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        shipper.ID = (int)reader["ShipperID"];
                        shipper.CompanyName = (string)reader["CompanyName"];
                        shipper.Phone = (string)reader["Phone"];
                    }
                }
            }
            return shipper;
        }

        public void SaveShipper(Shipper shipper)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Shippers]
                                                SET [CompanyName] = @CompanyName
      ,[Phone] = @Phone WHERE [ShipperID] = @ID", connection);

                SqlParameter idParam = new SqlParameter();
                SqlParameter idParam2 = new SqlParameter();
                SqlParameter idParam3 = new SqlParameter();

                idParam.ParameterName = "@CompanyName";
                idParam.Value = shipper.CompanyName;
                cmd.Parameters.Add(idParam);

                idParam2.ParameterName = "@Phone";
                idParam2.Value = shipper.Phone;
                cmd.Parameters.Add(idParam2);

                idParam3.ParameterName = "@ID";
                idParam3.Value = shipper.ID;
                cmd.Parameters.Add(idParam3);

                var rows = cmd.ExecuteNonQuery();

            }
        }
    }
}
