using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace projetc
{
    class EntiteTourner : CommandeBD
    {
        
        private string ville;
        private int id_tourner;
        private int id_colis;
        private string nom_chauffeur;
        public string Nom_chauffeur { get { return nom_chauffeur; } set{ nom_chauffeur = value; } }
        public string Ville { get { return ville; } set { ville = value; } }
        public int Id_tourner { get { return id_tourner; } set{ id_tourner =value; } }
        public int Id_colis { get { return id_colis; } set { id_colis = value; } }
        public void listercolistourner(DataGridView dgw) { string requete = "select * from colis where ville_destinataire='" + ville + "' and statut!='planifier' ;";
            DataSet table = Lire(requete, "colis");
            dgw.DataSource = table.Tables["colis"];
        }
        public SqlDataReader chargerchauffeur()
        {


            String req = "SELECT nom_employer from employer where poste_employer='chauffeur' and id_employer not in (select id_chauffeur from tourner);";
            SqlDataReader reponse = Lire(req);
            return reponse;
        }
        public int enregistrertourner()
        {
            string requete = "insert into tourner(id_tourner,ville_tourner,id_chauffeur,nom_chauffeur,date) values(" + (nouvidtourner() + 1) + ",'" + ville + "','" + rechercher() + "','" + nom_chauffeur + "','" + DateTime.Now.Date + "' );";
            
            int n = Ecrire(requete);
            return n;
        }
        public int supprimer()
        {

            string req = "delete from tourner where id_tourner=" + id_tourner + " ;";

            int reponse = Ecrire(req);
            return reponse;

        }
        public int modifieretatcolis()
        {
            string requete = "update colis set statut='planifier' where id_colis=" + id_colis + ";";

            int x = Ecrire(requete);
            return x;
        }
        public int rechercher()
        {
            string req = "select id_employer from employer where nom_employer='" + nom_chauffeur + "' and poste_employer='chauffeur' ;";
            
            SqlDataReader sread = Lire(req);

            if (DBNull.Value.Equals(sread))
            {
                sread.Close();
                return -1;
            }
            else
            {
                if (sread.Read())
                {
                    int n = sread.GetInt32(0);
                    sread.Close();
                    return n;
                }
                else
                {
                    sread.Close();
                    return -1;
                }
            }




        }
        public int nouvidtourner()
        {
            string req = "select max(id_tourner) id_tourner from tourner  ;";
            
            SqlDataReader sdr = Lire(req);
            if (DBNull.Value.Equals(sdr) == false)
            {
                if (sdr.Read() == true)
                {
                    int n = sdr.GetInt32(0);
                    sdr.Close();
                    return n;
                }
                else { sdr.Close(); return 0; }
            }
            else
                sdr.Close();
            return 0;
        }
        public int nouvidclient()
        {
            string req = "select max(id_client) from client  ;";
      
            SqlDataReader sdr = Lire(req);

            if (sdr.Read() == true)
            {
                int n = sdr.GetInt32(0);
                sdr.Close();
                return n;
            }
            else { sdr.Close(); return 0; }
        }
        
        public void remplirtableau(DataGridView dgw)
        {
           string requete = "select * from tourner";

            DataSet moy = Lire(requete, "tourner");
            dgw.DataSource = moy.Tables["tourner"];
        }
    }
}
