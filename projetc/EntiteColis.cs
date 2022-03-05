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
    class EntiteColis : CommandeBD
    {
       private  int id_colis;
        private string nom_colis;
        private int quantite;
        private float prix;
        private string nom_expediteur;
        private string ville_expediteur;
        private int tel;
        private string nom_destinataire;
        private string ville_destinataire;
        private float frais;
        private string date;
        private int id_expediteur;
        private string statut;
        public EntiteColis() { }
        public EntiteColis(int id_colis, string nom_colis, int quantite, float prix, int id_expediteur, int tel, string nom_destinataire, string ville_destinataire, float frais, string date, string statut)
        {
            this.id_colis = id_colis;
            this.nom_colis = nom_colis;
            this.quantite = quantite;
            this.prix = prix;
            this.id_expediteur = id_expediteur;
            this.tel = tel;
            this.nom_destinataire = nom_destinataire;
            this.ville_destinataire = ville_destinataire;
            this.frais = frais;
            this.date = date;
            this.statut = statut;
        }
        public EntiteColis(string nom_colis, int quantite, float prix, string nom_expediteur, string ville_expediteur, int tel, string nom_destinataire, string ville_destinataire, float frais, string date) {
           
            this.nom_colis = nom_colis;
            this.quantite = quantite;
            this.prix = prix;
            this.nom_expediteur = nom_expediteur;
            this.ville_expediteur = ville_expediteur;
            this.tel = tel;
            this.nom_destinataire = nom_destinataire;
            this.ville_destinataire = ville_destinataire;
            this.frais = frais;
            this.date = date;
        }
        public int ajouter()
        {
            int reponse = 0;
            if (rechercher(nom_expediteur) == -1)
            {
                String req = "insert into client(id_client,nom_client,ville_client,tel_client) values(" + (nouvidclient() + 1) + ",'" + nom_expediteur + "','" +
                           ville_expediteur + "','" + tel + "');";
            
                reponse = Ecrire(req);
            }
            String requete = "insert into colis(id_colis,nom_colis,quantite,prix,id_expediteur,nom_destinataire,ville_destinataire,frais_de_transport,date,statut) values(" + (nouvidcolis() + 1) + ",'" + nom_colis + "'," + quantite + "," + prix + "," + rechercher(nom_expediteur) + ",'" + nom_destinataire + "','" + ville_destinataire + "'," + frais + ",'25/06/2020','en attente');";

            
            reponse = Ecrire(requete);
            return reponse;
        }
        public int modifier()
        {
            string req = "update colis set nom_colis='" + nom_colis + "',quantite=" + quantite + ",prix=" + prix + ",id_expediteur=" + id_expediteur + ", nom_destinataire='" + nom_destinataire + "',ville_destinataire='" + ville_destinataire + "',frais_de_transport=" + frais + " ,statut='" + statut + "' where id_colis=" + id_colis + ";";
      
            int reponse = Ecrire(req);
            return reponse;
        }
        public int supprimer()
        {

            string req = "delete from colis where id_colis=" + id_colis + " ;";
            
            int reponse = Ecrire(req);
            return reponse;

        }
        public int rechercher(string nom)
        {
            string req = "select id_client from client where nom_client='" + nom + "' ;";
            
            SqlDataReader sread = Lire(req);

            if (sread == null)
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
        public int nouvidcolis()
        {
            string req = "select max(id_colis) from colis  ;";
           
            SqlDataReader sdr = Lire(req);

            if (sdr.Read() == true)
            {
                int n = sdr.GetInt32(0);
                sdr.Close();
                return n;
            }
            else { sdr.Close(); return 0; }
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
        public void remplirtable(DataGridView dgw) {
           string requete = "select * from colis";
            DataSet table = Lire(requete, "colis");
            dgw.DataSource = table.Tables["colis"];
        }

    }
}
