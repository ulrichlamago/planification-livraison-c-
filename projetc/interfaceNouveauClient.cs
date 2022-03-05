using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projetc
{
    public partial class interfaceNouveauClient : Form
    {
        
        principale pan;
       
        client cli;

        public interfaceNouveauClient(principale pn)
        {

            InitializeComponent();
         
            
            this.pan = pn;



        }

        private void ajouter_Click(object sender, EventArgs e)
        {


        }

        private void modifierclient_Click(object sender, EventArgs e)
        {



            if (nomclient.Text == "" || adresseclient.Text == "" || emailclient.Text == "")
            {
                MessageBox.Show("tous les champs doivent ètre remplie", "champs vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int tel;
                bool test = int.TryParse(telclient.Text, out tel);
                if (test == false)
                {
                    MessageBox.Show("le tel doit ètre un entier positif", "erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    cli = new client(tel, nomclient.Text, (String)villeclient.SelectedItem, adresseclient.Text, emailclient.Text,tel);
                    int verif = cli.modifier();


                    if (verif == 1)
                    {
                        MessageBox.Show("modification effectuer avec succès");
                        cli.remplirtable(pan.Tableclient);
                        this.Close();
                        
                    }
                }

            }

        }

        private void annuler_Click(object sender, EventArgs e)
        {
        
            this.Close();

        }

        private void ajouterclient_Click(object sender, EventArgs e)
        {

            if (nomclient.Text == "" || adresseclient.Text == "" || emailclient.Text == "")
            {
                MessageBox.Show("tous les champs doivent ètre remplie", "champs vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int tel;
                bool test = int.TryParse(telclient.Text, out tel);
                if (test == false)
                {
                    MessageBox.Show("le tel doit ètre un entier positif", "erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    cli = new client(nomclient.Text, (String)villeclient.SelectedItem, adresseclient.Text, emailclient.Text, tel);
                    int verif = cli.ajouter();


                    if (verif == 1)
                    {
                        MessageBox.Show("enregistrement effectuer avec succès");
                        cli = new client();
                        cli.remplirtable(pan.Tableclient);

                        this.Close();
                    }
                }
                

            }

        }
        public void modifieretat(bool test)
        {
            if (test == false)
            {
                modifierclient.Visible = true;
                ajouterclient.Visible = false;
            }
            else
            {
                modifierclient.Visible = false;
                ajouterclient.Visible = true;

            }
        }

        public Button Modifierclient { get { return this.modifierclient; } set { this.modifierclient = value; } }
        public Button Ajouterclient { get { return this.ajouterclient; } set { this.ajouterclient = value; } }
        public TextBox Nom { get { return this.nomclient; } }
        public ComboBox Ville { get { return this.villeclient; } }
        public TextBox Email { get { return this.emailclient; } }
        public TextBox Tel { get { return this.telclient; } }
        public TextBox Adresse { get { return this.adresseclient; } }
        


    }
}
