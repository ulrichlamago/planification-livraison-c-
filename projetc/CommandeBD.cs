using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace projetc
{
    class CommandeBD
    {

        private String connexionCH = "Data Source = ULRICH; Initial Catalog = agence; Integrated Security = True";
        private SqlConnection cn;
        private SqlCommand maRequete;
        public CommandeBD()
        {
        
            cn = new SqlConnection(connexionCH);
            cn.Open();
            maRequete = cn.CreateCommand();
        }

        public string ConnexionCH { get { return connexionCH; } set { connexionCH = value; } }
        
        public int Ecrire(String rqCH)
        {
           
            maRequete.CommandText = rqCH;

             
            int res = maRequete.ExecuteNonQuery();

            return res;
        }

        
        public SqlDataReader Lire(String rqCH)
        {
              
            maRequete.CommandText = rqCH;

            
            SqlDataReader res = maRequete.ExecuteReader();

            return res;
        }

        public DataSet Lire(String rqCH, String tableName)
        {
             
            maRequete.CommandText = rqCH;

            SqlDataAdapter da = new SqlDataAdapter(maRequete);

            DataSet ds = new DataSet();
            da.Fill(ds, tableName);

            return ds;
        }
        public void Fermer()
        {
           
            cn.Close();
            cn = null;
            maRequete = null;
        }
    }

}
