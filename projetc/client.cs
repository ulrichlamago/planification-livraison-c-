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

    class client : CommandeBD
    {
        private int idclient;
        private string nomclient;
        private string emailclient;
        private string villeclient;
        private string adresseclient;
        private int tel_client;
        public client() { }
        public client(int id_client, string nom, string ville, string adresse, string email,int tel_client)
        {
            this.idclient = id_client;
            this.nomclient = nom;
            this.villeclient = ville;
            this.adresseclient = adresse;
            this.emailclient = email;
            this.tel_client = tel_client;
            


        }
        public client(string nom, string ville, string adresse, string email, int tel_client)
        {
            
            this.nomclient = nom;
            this.villeclient = ville;
            this.adresseclient = adresse;
            this.emailclient = email;
            this.tel_client = tel_client;



        }
        public int Idclient { get { return this.idclient; } set { this.idclient = value; } }
        public string Nomclient { get { return this.nomclient; } set { this.nomclient = value; } }
        public string Emailclient { get { return this.emailclient; } set { this.emailclient = value; } }
        public string Villeclient { get { return this.villeclient; } set { this.villeclient = value; } }
        public string Adresseclient { get { return this.adresseclient; } set { this.adresseclient = value; } }
        public int Tel_client { get { return this.tel_client; } set { this.tel_client = value; } }
        public int ajouter()
        {
            String req = "insert into client(id_client,nom_client,ville_client,adresse_client,email_client,tel_client) values(" + (nouvidclient() + 1) + ",'" + Nomclient + "','" +
                          villeclient + "','"+adresseclient+"','"+emailclient+"','" + tel_client + "');";

          int  reponse = Ecrire(req);
            return reponse;
        }
        public int modifier() {
            string req = "update client set nom_client='" + Nomclient + "',ville_client='" + Villeclient + "',adresse_client='" + Adresseclient + "',email_client='" + emailclient + "',tel_client="+tel_client+" where id_client=" + idclient + " ;";
            int reponse = Ecrire(req);
            return reponse;
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
        public void remplirtable(DataGridView dgw)
        {
            string requete = "select * from client";
            DataSet table = Lire(requete, "client");
            dgw.DataSource = table.Tables["client"];
        }
        public int supprimer()
        {
            string requete = "delete from client where id_client=" + idclient + ";";
            int reponse = Ecrire(requete);
            return reponse;
        }
    }
}
