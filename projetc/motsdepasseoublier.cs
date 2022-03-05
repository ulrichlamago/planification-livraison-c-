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
    public partial class motsdepasseoublier : Form
    {
        Form1 fo;
        EntiteEmployer empois;
        EnvoyerMail mail;
        public motsdepasseoublier(Form1 fo)
        {
            InitializeComponent();
            this.fo = fo;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void envoyer_Click(object sender, EventArgs e)
        {
            string log = login.Text;
            empois = new EntiteEmployer();
            empois.Login = log;
            SqlDataReader tab = empois.oublie();
            string email="";
            string password="";
            mail = new EnvoyerMail();
            if (tab.Read())
            {
                email = tab.GetSqlString(1).Value.ToString();
                password = tab.GetSqlString(0).Value.ToString();
                mail.SendMail(email, password);
            }else
            {
                MessageBox.Show("veuillez verifier votre login");
            }
           


        }
    }
}
