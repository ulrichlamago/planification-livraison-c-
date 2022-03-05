using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetc
{
    public partial class interfaceNouveauEmployer : Form
    {
        EntiteEmployer infemployer;
        public interfaceNouveauEmployer()
        {
            InitializeComponent();
           
        }

        private void ajouteremployer_Click(object sender, EventArgs e)
        {
            string nom = nomemployer.Text;
            string prenom = prenomemployer.Text;
            string email = emailemployer.Text;
            string poste = (string)posteemployer.SelectedItem;
            float salaire = float.Parse(salaireemployer.Text);
            string login = loginemployer.Text;
            string password = passwordemployer.Text;
            infemployer = new EntiteEmployer(nom, prenom, email, poste, salaire, DateTime.Now.ToString(), login, password);
            int x = infemployer.ajouter();
            int y = infemployer.ajouterlogin();
            if (x == -2) { MessageBox.Show("employer déjà existant peut ètre.veuillez verifier votre nom.", "erreur lors de l'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                MessageBox.Show("enregistrement effectuer avec succès");
                this.Close();
            }
        }


        private void modifieremployer_Click(object sender, EventArgs e)
        {
            string nom = nomemployer.Text;
            string prenom = prenomemployer.Text;
            string email = emailemployer.Text;
            string poste = (string)posteemployer.SelectedItem;
            float salaire = float.Parse(salaireemployer.Text);
            string login = loginemployer.Text;
            string password = passwordemployer.Text;
            int id = int.Parse(idemployer.Text);
            infemployer = new EntiteEmployer(id,nom, prenom, email, poste, salaire, DateTime.Now.ToString(), login, password);
            int x = infemployer.modifier();
            if (x == -1) { MessageBox.Show("modification echouer,veuillez reverifier vos parametre", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }else
            {
                MessageBox.Show("modification effectuer avec succès");
                this.Close();
            }

        }
        public TextBox Nomemployer{ get { return nomemployer; } }
        public TextBox Emailemployer { get { return emailemployer; } }
        public TextBox Prenomemployer { get { return prenomemployer; } }
        public ComboBox poste { get { return posteemployer; } }
        public TextBox Salaireemployer { get { return salaireemployer; } }
        public TextBox Loginemployer { get { return loginemployer; } }
        public TextBox Passwordemployer { get { return passwordemployer; } }
        public TextBox Idemployer { get { return idemployer; } } 
        public Button Modifieremployer { get {return  modifieremployer; } } 
        public Button Ajouteremployer { get { return ajouteremployer; } }
        public Label Labelidemployer { get { return label8; } }
        public TextBox Ideemployer { get { return idemployer; } }
        private void annuleremployer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
