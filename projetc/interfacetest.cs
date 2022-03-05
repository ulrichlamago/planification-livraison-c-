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
    public partial class interfacetest : Form
    {
        EntiteTest ent;
        public interfacetest()
        {
            InitializeComponent();
            ent = new EntiteTest();
           
        }

        private void supprimer_Click(object sender, EventArgs e)
        { int vid;
            bool test = int.TryParse(id.Text, out vid);
            if (test == false)
            {
                MessageBox.Show("erreur de saisier");

            }else
            {
               
                ent.Id = vid;
                ent.suppressions();
                MessageBox.Show("suppression effectuer avec succès");
            }
        }
    }
}
