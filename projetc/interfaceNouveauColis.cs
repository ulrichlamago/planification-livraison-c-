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
    public partial class interfaceNouveauColis : Form
    {
        
        principale pn;
        EntiteColis cols;
        public interfaceNouveauColis(principale pn)
        {
            InitializeComponent();
            this.pn = pn;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string nom = NomColis.Text;
            int quantite =int.Parse( quantitecolis.Text);
            float prix = float.Parse(prixcolis.Text);
            string nexpediteur = nomexpediteur.Text;
            string villeex = (String)villeexpediteur.SelectedItem;
            string ndestinataire = nomdestinataire.Text;
            string villedes = (String)villedestinataire.SelectedItem;
            float frais = float.Parse(fraislivraison.Text);
            int tel = int.Parse(telclient.Text);
          
            
            cols = new EntiteColis( nom, quantite, prix, nexpediteur, villeex, tel, ndestinataire, villedes, frais, DateTime.Now.Date.ToString());
            cols.ajouter();
            MessageBox.Show("enregistrement effectuer avec succès");
            cols.remplirtable(pn.Tablecolis);
            this.Close();
        }
        public TextBox nomcolis { get { return NomColis; } }
        public TextBox Quantitecolis { get { return quantitecolis; } }
        public TextBox Prixcolis { get { return prixcolis; } }
        public TextBox Nomexpediteur { get { return nomexpediteur; } }
        public ComboBox Villeexpediteur { get { return villeexpediteur; } }
        public TextBox Nomdestinataire { get { return nomdestinataire; } }
        public ComboBox Villedestinataire { get { return villedestinataire; } }
        public TextBox Fraislivraison { get { return fraislivraison; } }
        public TextBox Telclient { get { return telclient; } }
        public Button Ajouter { get { return ajouter; } }
        public Button Modifier { get { return modifier; } }
        public TextBox Etatcolis { get { return etatducolis; } }
        public Label labelstatut { get { return label10; } }
        public Label labelid { get { return label11; } }
        public TextBox Idcolis { get { return idcolis; } }

        private void modifier_Click(object sender, EventArgs e)
        {
            string nom = NomColis.Text;
            int quantite = int.Parse(quantitecolis.Text);
            float prix = float.Parse(prixcolis.Text);
            string nexpediteur = nomexpediteur.Text;
            string villeex = (String)villeexpediteur.SelectedItem;
            string ndestinataire = nomdestinataire.Text;
            string villedes = (String)villedestinataire.SelectedItem;
            float frais = float.Parse(fraislivraison.Text);
            if (telclient.Text == "") { MessageBox.Show("veuillez remplir tous les champs"); } else {
                int tel = int.Parse(telclient.Text);
                int idcol = int.Parse(Idcolis.Text);
                String etat = etatducolis.Text;
                cols = new EntiteColis(idcol, nom, quantite, prix, int.Parse(nexpediteur), tel, ndestinataire, villedes, frais, DateTime.Now.Date.ToString(), etat);
                cols.modifier();
                MessageBox.Show("modification effectuer avec succès");
                cols.remplirtable(pn.Tablecolis);
            }
            this.Close();

        }
    }
}
