using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DLLl2CSI2024
{
    public class Class1
    {
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public void connexion()
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.ConnectionString = @"Data Source=SQL8001.site4now.net;Initial Catalog=db_aa3f51_gestioninscription;User Id=db_aa3f51_gestioninscription_admin;Password=ISCL2@2024
				";
                cnx.Open();
            }
        }

        public void deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

        public void executeRqt(string rqt)
        {
            connexion();
            cmd.CommandText = rqt;
            cmd.Connection = cnx;
            cmd.ExecuteNonQuery();
            deconnecter();
        }

    }
}
