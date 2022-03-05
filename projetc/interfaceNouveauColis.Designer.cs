namespace projetc
{
    partial class interfaceNouveauColis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfaceNouveauColis));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomColis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantitecolis = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.nomexpediteur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.villeexpediteur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prixcolis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nomdestinataire = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fraislivraison = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.villedestinataire = new System.Windows.Forms.ComboBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.telclient = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.etatducolis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.idcolis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "nouveau colis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "nom:";
            // 
            // NomColis
            // 
            this.NomColis.Location = new System.Drawing.Point(169, 110);
            this.NomColis.Name = "NomColis";
            this.NomColis.Size = new System.Drawing.Size(121, 20);
            this.NomColis.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "quantite:";
            // 
            // quantitecolis
            // 
            this.quantitecolis.Location = new System.Drawing.Point(169, 168);
            this.quantitecolis.Name = "quantitecolis";
            this.quantitecolis.Size = new System.Drawing.Size(121, 20);
            this.quantitecolis.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(17, 258);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(132, 20);
            this.label.TabIndex = 5;
            this.label.Text = "nom expediteur";
            // 
            // nomexpediteur
            // 
            this.nomexpediteur.Location = new System.Drawing.Point(169, 258);
            this.nomexpediteur.Name = "nomexpediteur";
            this.nomexpediteur.Size = new System.Drawing.Size(121, 20);
            this.nomexpediteur.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ville expediteur:";
            // 
            // villeexpediteur
            // 
            this.villeexpediteur.FormattingEnabled = true;
            this.villeexpediteur.Items.AddRange(new object[] {
            "nabeul",
            "sousse",
            "tunis",
            "bizerte",
            "sfax",
            "monastir"});
            this.villeexpediteur.Location = new System.Drawing.Point(169, 305);
            this.villeexpediteur.Name = "villeexpediteur";
            this.villeexpediteur.Size = new System.Drawing.Size(121, 21);
            this.villeexpediteur.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(106, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "prix:";
            // 
            // prixcolis
            // 
            this.prixcolis.Location = new System.Drawing.Point(169, 207);
            this.prixcolis.Name = "prixcolis";
            this.prixcolis.Size = new System.Drawing.Size(121, 20);
            this.prixcolis.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(351, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "nom du destinataire:";
            // 
            // nomdestinataire
            // 
            this.nomdestinataire.Location = new System.Drawing.Point(557, 108);
            this.nomdestinataire.Name = "nomdestinataire";
            this.nomdestinataire.Size = new System.Drawing.Size(134, 20);
            this.nomdestinataire.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(380, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "frais de livraison:";
            // 
            // fraislivraison
            // 
            this.fraislivraison.Location = new System.Drawing.Point(557, 227);
            this.fraislivraison.Name = "fraislivraison";
            this.fraislivraison.Size = new System.Drawing.Size(134, 20);
            this.fraislivraison.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(380, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "ville destinataire:";
            // 
            // villedestinataire
            // 
            this.villedestinataire.FormattingEnabled = true;
            this.villedestinataire.Items.AddRange(new object[] {
            "nabeul",
            "sousse",
            "tunis",
            "bizerte",
            "sfax",
            "monastir"});
            this.villedestinataire.Location = new System.Drawing.Point(557, 165);
            this.villedestinataire.Name = "villedestinataire";
            this.villedestinataire.Size = new System.Drawing.Size(134, 21);
            this.villedestinataire.TabIndex = 16;
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.White;
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.Color.ForestGreen;
            this.ajouter.Location = new System.Drawing.Point(140, 416);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(121, 40);
            this.ajouter.TabIndex = 17;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.ForeColor = System.Drawing.Color.ForestGreen;
            this.annuler.Location = new System.Drawing.Point(512, 416);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(121, 40);
            this.annuler.TabIndex = 18;
            this.annuler.Text = "annuler";
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.White;
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.ForestGreen;
            this.modifier.Location = new System.Drawing.Point(140, 416);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(121, 40);
            this.modifier.TabIndex = 19;
            this.modifier.Text = "modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Visible = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(381, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "tel du client:";
            // 
            // telclient
            // 
            this.telclient.Location = new System.Drawing.Point(557, 283);
            this.telclient.Name = "telclient";
            this.telclient.Size = new System.Drawing.Size(134, 20);
            this.telclient.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(360, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "etat du colis:";
            // 
            // etatducolis
            // 
            this.etatducolis.Location = new System.Drawing.Point(557, 360);
            this.etatducolis.Name = "etatducolis";
            this.etatducolis.Size = new System.Drawing.Size(134, 20);
            this.etatducolis.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(36, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "id du colis:";
            // 
            // idcolis
            // 
            this.idcolis.Location = new System.Drawing.Point(169, 358);
            this.idcolis.Name = "idcolis";
            this.idcolis.Size = new System.Drawing.Size(121, 20);
            this.idcolis.TabIndex = 25;
            // 
            // interfaceNouveauColis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(771, 483);
            this.Controls.Add(this.idcolis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.etatducolis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.telclient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.villedestinataire);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fraislivraison);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nomdestinataire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prixcolis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.villeexpediteur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomexpediteur);
            this.Controls.Add(this.label);
            this.Controls.Add(this.quantitecolis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomColis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "interfaceNouveauColis";
            this.Text = "nouveau colis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomColis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantitecolis;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox nomexpediteur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox villeexpediteur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prixcolis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomdestinataire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fraislivraison;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox villedestinataire;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox telclient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox etatducolis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox idcolis;
    }
}