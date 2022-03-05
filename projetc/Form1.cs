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
    public partial class Form1 : Form
    {
        EntiteEmployer empois;
        interfacetest test;
        public Form1()
        {
            InitializeComponent();
            test = new interfacetest();
            test.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connecter_Click(object sender, EventArgs e)
        {
            string user = login.Text;
            string pass = password.Text;
            empois = new EntiteEmployer();
            empois.Login = user;
            empois.Password = pass;
            int reponse = empois.connecter();
            if (reponse == 0) { MessageBox.Show("erreur de saisie", "veuillez verifier votre login et votre mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (reponse == 1)
            {
                principale ps = new principale(this);
                
                ps.ShowDialog();
                this.Hide();
              
            }
            else
            {
                principale ps = new principale(this);
                ps.Labelemployer.Visible = false;
                ps.Employer.Visible = false;

               
                ps.Show();
                this.Hide();
              
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            motsdepasseoublier oubli = new motsdepasseoublier(this);
            oubli.Show();
           
        }
    }
}
