using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace projetc
{
    class EntiteTest :CommandeBD
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        public string marque;
        public string lib;
       public  float prix;
        public int suppressions()
        {
            string requete = "delete from test1 where id=" + id + " ;";
            int reponse = Ecrire(requete);
            return reponse;
        }
        public int ajout() {
        string requete="insert into test1 values("+nouvid()+",'bonjour','bonjour',500)";
            int reponse = Ecrire(requete);
            return reponse;
        }
        public int nouvid()
        {
            string requete = "select max(id) from test1";
            SqlDataReader reponse = Lire(requete);
            if (reponse.Read())
            {
                return 1+reponse.GetInt32(0);
            }else
            {
                return 1;
            }


        }

    }
}
