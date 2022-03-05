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
    public partial class principale : Form
    {
       
        EntiteEmployer empois;
        EntiteColis cols;
        client cli;
        EntiteTourner toun;
        Form1 fenetre;
        public principale(Form1 fenetre)
        {
            InitializeComponent();
            this.fenetre = fenetre;
            toun = new EntiteTourner();
            SqlDataReader red = toun.chargerchauffeur();

            if (red.Read() == false) { MessageBox.Show("aucun chauffeur disponible"); }
            else
            {
                while (red.Read())
                {

                    chauffeurtourner.Items.Add(red.GetString(0));

                }
                red.Close();


            }

        }


        private void paneaccueil_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panecolis_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void accueil_Click(object sender, EventArgs e)
        {
            paneaccueil.Visible = true;
            FenetreColis.Visible = false;
           

        }

        private void colis_Click(object sender, EventArgs e)
        {
            paneaccueil.Visible = true;
            FenetreColis.Visible = true;
            paneclient.Visible = false;
            recherchercolis.Visible = true;
            cols = new EntiteColis();

            cols.remplirtable(Tablecolis);


        }

        private void principale_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textrecherchercolis.Text == "")
            {
                MessageBox.Show("vous devez saisir le nom du colis rechercher", "erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                int j = 0;
                bool test = false;
                while (i < tablecolis.Rows.Count - 1 && test == false)
                {
                    while (j < tablecolis.Rows[i].Cells.Count && test == false)
                    {
                        if (tablecolis.Rows[i].Cells[j].Value.ToString().Equals(textrecherchercolis.Text))
                        {
                            tablecolis.Rows[i].Selected = true;
                            test = true;
                        }
                        j++;
                    }
                    j = 0;
                    i++;
                }
                if (test == false)
                {
                    MessageBox.Show("aucun colis trouver");
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelcolis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            paneaccueil.Visible = true;
            FenetreColis.Visible = true;
            paneclient.Visible = false;
            recherchercolis.Visible = true;
            cols= new EntiteColis();
            cols.remplirtable(tablecolis);

        }

        private void client_Click(object sender, EventArgs e)
        {
            paneaccueil.Visible = true;
            FenetreColis.Visible = true;
            paneclient.Visible = true;
            panetourner.Visible = false;
            recherchercolis.Visible = false;
             cli = new client();
            cli.remplirtable(tableclient);
          

        }

        private void labelclient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            paneaccueil.Visible = true;
            FenetreColis.Visible = true;
            paneclient.Visible = true;
            panetourner.Visible = false;
            recherchercolis.Visible = false;
            cli = new client();
            cli.remplirtable(tableclient);
          

        }

        private void tourner_Click(object sender, EventArgs e)
        {
            paneaccueil.Visible = true;
            FenetreColis.Visible = true;
            paneclient.Visible = true;
            panetourner.Visible = true;
            paneemployer.Visible = false;
            recherchercolis.Visible = false;
         
                label8.Visible = false;
            


        }

        private void labeltourner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            paneaccueil.Visible = true;
            FenetreColis.Visible = true;
            paneclient.Visible = true;
            panetourner.Visible = true;
            paneemployer.Visible = false;
            recherchercolis.Visible = false;
            label8.Visible = false;
            supprimertourner.Visible = true;
            supprimertourner.Enabled = true;
            tableplanifier.MultiSelect = true;
          
        }

        private void labelemployer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            paneaccueil.Visible = true;
            FenetreColis.Visible = true;
            paneclient.Visible = true;
            panetourner.Visible = true;
            paneemployer.Visible = true;
            empois = new EntiteEmployer();
            empois.remplirtable(tableemployer);
            recherchercolis.Visible = false;
            label8.Visible = false;
            supprimertourner.Visible = false;


        }

        private void employer_Click(object sender, EventArgs e)
        {
            paneaccueil.Visible = true;
            FenetreColis.Visible = true;
            paneclient.Visible = true;
            panetourner.Visible = true;
            paneemployer.Visible = true;
            recherchercolis.Visible = false;
            label8.Visible = false;
            supprimertourner.Visible = false;
            empois = new EntiteEmployer();
            empois.remplirtable(tableemployer);



        }

        private void rechercheremployer_Click(object sender, EventArgs e)
        {

        }

        private void ajouteremployer_Click(object sender, EventArgs e)
        {
            interfaceNouveauEmployer nouvemployer = new interfaceNouveauEmployer();
            nouvemployer.Show();
        }

        private void modifieremployer_Click(object sender, EventArgs e)
        {
            interfaceNouveauEmployer nouv = new interfaceNouveauEmployer();
            

        }

        private void supprimeremployer_Click(object sender, EventArgs e)
        {

        }

        private void actualiseremployer_Click(object sender, EventArgs e)
        {

        }

        private void validertourner_Click(object sender, EventArgs e)
        {

        }

        private void enregistrertourner_Click(object sender, EventArgs e)
        {

        }

        private void listertourner_Click(object sender, EventArgs e)
        {

        }

        private void textrechercherclient_TextChanged(object sender, EventArgs e)
        {

        }

        private void rechercherclient_Click(object sender, EventArgs e)
        {

        }

        private void ajouterclient_Click(object sender, EventArgs e)
        {
           

        }

        private void modifierclient_Click(object sender, EventArgs e)
        {
 

        }

        private void supprimerclient_Click(object sender, EventArgs e)
        {

        }

        private void actualiserclient_Click(object sender, EventArgs e)
        {

        }

        private void ajoutercolis_Click(object sender, EventArgs e)
        {
            interfaceNouveauColis nouv = new interfaceNouveauColis(this);
            nouv.labelid.Visible = false;
            nouv.Idcolis.Visible = false;
            nouv.labelstatut.Visible = false;
            nouv.Etatcolis.Visible = false;
            nouv.Ajouter.Visible = true;
            nouv.Modifier.Visible = false;
            nouv.Show();
        }

        private void modifiercolis_Click(object sender, EventArgs e)
        {
            interfaceNouveauColis nouv = new interfaceNouveauColis(this);
            nouv.Ajouter.Visible = false;
            nouv.Modifier.Visible = true;
            int num = ligneselectionner(tablecolis);
           nouv.Idcolis.Text= tablecolis.Rows[num].Cells[0].Value.ToString();
            nouv.nomcolis.Text = tablecolis.Rows[num].Cells[1].Value.ToString();
            nouv.Quantitecolis.Text = tablecolis.Rows[num].Cells[2].Value.ToString();
            nouv.Prixcolis.Text = tablecolis.Rows[num].Cells[3].Value.ToString();
            nouv.Nomexpediteur.Text = tablecolis.Rows[num].Cells[4].Value.ToString();
            nouv.Nomdestinataire.Text = tablecolis.Rows[num].Cells[5].Value.ToString();
            nouv.Villedestinataire.SelectedItem = tablecolis.Rows[num].Cells[6].Value.ToString();
            nouv.Fraislivraison.Text = tablecolis.Rows[num].Cells[7].Value.ToString();
            nouv.labelid.Visible = true;
            nouv.Idcolis.Visible = true;
            nouv.Idcolis.Enabled = false;
            nouv.labelstatut.Visible = true;
            nouv.Etatcolis.Visible = true;
            nouv.Etatcolis.Text = tablecolis.CurrentRow.Cells[9].Value.ToString();

         
            nouv.Show();
        }

        private void supprimercolis_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tablecolis.CurrentRow.Cells[0].Value.ToString());
            DialogResult dn = MessageBox.Show("etes vous sur de vouloir le supprimer?", "suppression", MessageBoxButtons.YesNoCancel);
            if (dn == DialogResult.Yes)
            {
                cols= new EntiteColis();
              int n=  cols.supprimer();
                cols.remplirtable(Tablecolis);
                if (n != -1)
                {
                    MessageBox.Show("suppression effectuer avec succès");

                }
            }
        }

        private void actualisercolis_Click(object sender, EventArgs e)
        {
            cols = new EntiteColis();
            cols.remplirtable(tablecolis);
        }

        private void panetourner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableplanifier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ajouteremployer_Click_1(object sender, EventArgs e)
        {
            interfaceNouveauEmployer ine = new interfaceNouveauEmployer();
            ine.Ajouteremployer.Visible = true;
            ine.Modifieremployer.Visible = false;
            ine.Ideemployer.Visible = false;
            ine.Labelidemployer.Visible = false;
            ine.Show();
        }

        private void rechercherclient_Click_1(object sender, EventArgs e)
        {
            if (textrechercherclient.Text =="") {
                MessageBox.Show("vous devez saisir le nom du client rechercher","erreur de saisie",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
            {
                int i = 0;
                int j = 0;
                bool test = false;
                while (i < tableclient.Rows.Count - 1 && test==false) {
                    while( j < tableclient.Rows[i].Cells.Count && test==false) {
                        if (tableclient.Rows[i].Cells[j].Value.ToString().Equals(textrechercherclient.Text)) {
                            tableclient.Rows[i].Selected = true;
                            test = true;
                        }
                        j++;
                    }
                    j = 0;
                    i++;
                }
                if (test == false)
                {
                    MessageBox.Show("aucun client trouver");
                }

            }
        }

        private void ajouterclient_Click_1(object sender, EventArgs e)
        {
            interfaceNouveauClient nouvclient = new interfaceNouveauClient(this);
            nouvclient.modifieretat(true);
            nouvclient.Show();
        }

        private void tableclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void modifierclient_Click_1(object sender, EventArgs e)
        {
            interfaceNouveauClient modifclient = new interfaceNouveauClient(this);
            int num = ligneselectionner(tableclient);
            int idclient=int.Parse(tableclient.Rows[num].Cells[0].Value.ToString());
            string nom = tableclient.Rows[num].Cells[1].Value.ToString();
            string ville= tableclient.Rows[num].Cells[2].Value.ToString();
            string adresse= tableclient.Rows[num].Cells[3].Value.ToString();
            string email= tableclient.Rows[num].Cells[4].Value.ToString();
        
            modifclient.Nom.Text = nom;
            modifclient.Ville.SelectedItem = ville;
            modifclient.Tel.Text =""+ idclient;
            modifclient.Adresse.Text = adresse;
            modifclient.Email.Text = email;
            modifclient.modifieretat(false);
            modifclient.Tel.Enabled=false;
            
            modifclient.Show();

        }

        private void supprimerclient_Click_1(object sender, EventArgs e)
        {int num = int.Parse(tableclient.CurrentRow.Cells[0].Value.ToString());
            DialogResult dn = MessageBox.Show("etes vous sur de vouloir le supprimer?", "suppression", MessageBoxButtons.YesNoCancel);
            if(dn==DialogResult.Yes){

                cli = new client();
                cli.Idclient = num;
                cli.supprimer();
                cli.remplirtable(tableclient);
            }

        }

        private void actualiserclient_Click_1(object sender, EventArgs e)
        {
            cli = new client();
            cli.remplirtable(tableclient);
        }
        public DataGridView Tableclient { get { return tableclient; } }
        public DataGridView Tablecolis { get { return tablecolis; } }
        public DataGridView Tableemployer { get { return tableemployer; } }

        private void recherchercolis_Click(object sender, EventArgs e)
        {
            if (textrecherchercolis.Text == "")
            {
                MessageBox.Show("vous devez saisir le nom du colis rechercher", "erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                int j = 0;
                bool test = false;
                while (i < tablecolis.Rows.Count - 1 && test == false)
                {
                    while (j < tablecolis.Rows[i].Cells.Count && test == false)
                    {
                        if (tablecolis.Rows[i].Cells[j].Value.ToString().Equals(textrecherchercolis.Text))
                        {
                           
                            tablecolis.Rows[i].Selected = true;
                            test = true;
                        }
                        j++;
                    }
                    j = 0;
                    i++;
                }
                if (test == false)
                {
                    MessageBox.Show("aucun colis trouver");
                }

            }

        }

        private void modifieremployer_Click_1(object sender, EventArgs e)
        {
            interfaceNouveauEmployer ine = new interfaceNouveauEmployer();
            int n = ligneselectionner(tableemployer);
            ine.Idemployer.Text = tableemployer.Rows[n].Cells[0].Value.ToString();
            ine.Nomemployer.Text = tableemployer.Rows[n].Cells[1].Value.ToString();
            ine.Prenomemployer.Text = tableemployer.Rows[n].Cells[2].Value.ToString();
            ine.Emailemployer.Text = tableemployer.Rows[n].Cells[3].Value.ToString();
            ine.poste.SelectedItem= tableemployer.Rows[n].Cells[4].Value.ToString();
            ine.Salaireemployer.Text= tableemployer.Rows[n].Cells[5].Value.ToString();
            empois = new EntiteEmployer();
            empois.Id_employer = int.Parse(tableemployer.Rows[n].Cells[0].Value.ToString());

            SqlDataReader sdr = empois.infosconnect();
            if (sdr.Read()) {
                ine.Loginemployer.Text = sdr.GetString(1);
                ine.Passwordemployer.Text = sdr.GetString(2);
            }sdr.Close();
            ine.Ajouteremployer.Visible = false;
            ine.Modifieremployer.Visible = true;
            ine.Ideemployer.Visible = true;
            ine.Labelidemployer.Visible = true;

            ine.Show();
        }

        private void rechercheremployer_Click_1(object sender, EventArgs e)
        {
            if (textrechercheremployer.Text == "")
            {
                MessageBox.Show("vous devez saisir le nom de l'employer  rechercher", "erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                int j = 0;
                bool test = false;
                while (i < tableemployer.Rows.Count - 1 && test == false)
                {
                    while (j < tableemployer.Rows[i].Cells.Count && test == false)
                    {
                        if (tableemployer.Rows[i].Cells[j].Value.ToString().Equals(textrechercheremployer.Text))
                        {
                            tableemployer.Rows[i].Selected = true;
                            
                            test = true;
                        }
                        j++;
                    }
                    j = 0;
                    i++;
                }
                if (test == false)
                {
                    MessageBox.Show("aucun employer trouver");
                }

            }
        }

        private void supprimeremployer_Click_1(object sender, EventArgs e)
        { 
            DialogResult dn = MessageBox.Show("etes vous sur de vouloir le supprimer?", "suppression", MessageBoxButtons.YesNoCancel);
            if (dn == DialogResult.Yes)
            {
                if (ligneselectionner(tableemployer) == -1) { MessageBox.Show("aucune valeur selectionner", "rien à supprimer", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    int id = int.Parse(tableemployer.Rows[ligneselectionner(tableemployer)].Cells[0].Value.ToString());
                    empois = new EntiteEmployer();
                    empois.Id_employer = id;
                    empois.supprimer();
                    empois.remplirtable(tableemployer);
                }
            }
        }
        public int ligneselectionner(DataGridView dgv) {
            int i = 0,n= dgv.Rows.Count - 1;
            bool test = false;
            while(i < n  && test==false) {
                if (dgv.Rows[i].Selected == true)
                {
                    test = true;
                    
                    return i;
                }
                i++;
            }
            return -1;
           
        }

        private void actualiseremployer_Click_1(object sender, EventArgs e)
        {
            empois = new EntiteEmployer();
            empois.remplirtable(tableemployer);
        }

        private void listertourner_Click_1(object sender, EventArgs e)
        {
            toun = new EntiteTourner();
            toun.remplirtableau(tableplanifier);
            label8.Visible = false;
        }

        private void validertourner_Click_1(object sender, EventArgs e)
        {
            toun = new EntiteTourner();
            toun.remplirtableau(tableplanifier);
            toun.Ville = (string)villetourner.SelectedItem;

            toun.listercolistourner(tableplanifier);
            label8.Visible = true;
            supprimertourner.Enabled = false;
        }

        private void enregistrertourner_Click_1(object sender, EventArgs e)
        {
            label8.Visible = false;
            int i = 0;
            toun = new EntiteTourner();
            for (i = 0; i < tableplanifier.Rows.Count; i++) {
                if (tableplanifier.Rows[i].Selected == true) {
                    toun.Id_colis=int.Parse(tableplanifier.Rows[i].Cells[0].Value.ToString());
                    toun.modifieretatcolis();
                } }
            toun.Nom_chauffeur =(string)chauffeurtourner.SelectedItem;
            toun.Ville = (string)villetourner.SelectedItem;
            toun.enregistrertourner();

            MessageBox.Show("tourner planifier avec succès");
            
            toun.remplirtableau(tableplanifier);
            supprimertourner.Enabled = true;

        }

        private void supprimertourner_Click(object sender, EventArgs e)
        {
            int n = ligneselectionner(tableplanifier);
            toun = new EntiteTourner();
            int.Parse(tableplanifier.Rows[n].Cells[0].Value.ToString());

            toun.Id_tourner = int.Parse(tableplanifier.Rows[n].Cells[0].Value.ToString());
            toun.supprimer();
            toun.remplirtableau(tableplanifier);
        }
        public Button Employer { get { return employer; } }
        public Label Labelemployer { get { return labelemployer; } }
    }
    
}
