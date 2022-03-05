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
    class EntiteEmployer : CommandeBD
    {
    private    int id_employer;
     private   string nom_employer;
     private   string prenom_employer;
     private   string email_employer;
     private   string poste_employer;
    private    float salaire;
      private  string date;
        private string password;
        private string login;
       public EntiteEmployer() { }
        public EntiteEmployer(int id_employer,string nom_employer,string prenom_employer,string email_employer,string poste_employer,float salaire, string date, string login, string password)
        { this.id_employer = id_employer;
            this.nom_employer = nom_employer;
            this.prenom_employer = prenom_employer;
            this.email_employer = email_employer;
            this.poste_employer = poste_employer;
            this.salaire = salaire;
            this.date = date;
            this.login = login;
            this.password = password;
        }
        public EntiteEmployer( string nom_employer, string prenom_employer, string email_employer, string poste_employer, float salaire, string date,string login,string password)
        {
            this.login = login;
            this.password = password;
            this.nom_employer = nom_employer;
            this.prenom_employer = prenom_employer;
            this.email_employer = email_employer;
            this.poste_employer = poste_employer;
            this.salaire = salaire;
            this.date = date;
        }
        public int Id_employer { get { return id_employer; } set { id_employer = value; } }
        public string Nom_employer { get { return nom_employer; } set { nom_employer = value; } }
        public string Prenom_employer { get { return prenom_employer; } set { prenom_employer = value; } }
        public string Email_employer { get { return email_employer; } set { email_employer = value; } }
        public string Poste_employer { get { return poste_employer; } set { poste_employer = value; } }
        public float Salaire_employer { get { return salaire; } set { salaire = value; } }
        public string Date { get { return date; } set { date = value; } }
        public string Login { get { return login; } set { login = value; } }
        public string Password{ get { return password; } set { password = value; } }
        public int ajouter()
        {
            int reponse = -1;
            MessageBox.Show("nouv id=" + (nouvidemployer() + 1));
            if (rechercher() == -1)
            {
                String req = "insert into employer(id_employer,nom_employer,prenom_employer,email_employer,poste_employer,salaire,date) values( " + (nouvidemployer() + 1) + ",'" + nom_employer + "','" +
                           prenom_employer + "','" + email_employer + "','" + poste_employer + "'," + salaire + ",'" + date + "');";

                reponse = Ecrire(req);
                return reponse;
            }
            else
            {

                return -2;
            }
            
        }
        public int ajouterlogin() {
            
            String requete = "insert into connecter(id_employer,login,password,role) values(" + (nouvidemployer() + 1) + ",'" + login + "','" + password + "','" + poste_employer + "');";

           int  reponse = Ecrire(requete);
            return reponse;
        }
        public int modifier()
        {
            string req = "update employer set nom_employer='" + nom_employer + "',prenom_employer='" + prenom_employer + "',email_employer='" + email_employer + "',poste_employer='" + poste_employer + "', salaire='" + salaire + "',date='" + date + "' where id_employer=" + id_employer + ";";

            int reponse = Ecrire(req);
            return reponse;
        }
        public int supprimer()
        {

            string req = "delete from employer where id_employer=" + id_employer + " ;";
            string req2 = "delete from connecter where id_employer=" + id_employer + ";";
            
            int reponse = Ecrire(req);
                        Ecrire(req2);
            return reponse;

        }
        public int rechercher()
        {
            string req = "select id_employer from employer where nom_employer='" + nom_employer + "' ;";
           
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
        public int nouvidemployer()
        {
            string req = "select max(id_employer) from employer  ;";
          
            SqlDataReader sdr = Lire(req);

                if (sdr.Read())
                {
                    int n = sdr.GetInt32(0);
                    sdr.Close();
                    return n;
                }
                else
                {
                    sdr.Close();
                    return -1;
                }
            
        }

      
        public SqlDataReader infosconnect()
        {
            string requet = "select * from connecter where id_employer=" + id_employer + ";";
          
            SqlDataReader sortie = Lire(requet);
            if (sortie == null) { return null; }
            else
            {

                return sortie;
            }
        }
        public void remplirtable (DataGridView dgw)
        {
           string  requete = "select * from employer";
            DataSet table = Lire(requete,"employer");
            dgw.DataSource = table.Tables["employer"];
        }
        public int connecter()
        {
            string requete = "select role from connecter where login='" + login + "' and password='" + password + "';";
            SqlDataReader reponse = Lire(requete);
            string resultat;
            if (reponse.Read())
            {
                resultat = reponse.GetSqlString(0).Value.ToString();
                if (resultat.Equals("administrateur"))
                {
                    return 1;
                }
                if (resultat.Equals("secretaire") || resultat.Equals("comptable"))
                {
                    return 2;
                }
                return 0;
            }
            return 0;
        }
        public SqlDataReader oublie()
        {
            string requete = "select password,email_employer from employer,connecter where connecter.login='"+login+"' and employer.id_employer=connecter.id_employer";
            SqlDataReader reponse = Lire(requete);
            return reponse;

        }

    }
}
