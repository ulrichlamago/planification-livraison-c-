namespace projetc
{
    partial class interfaceNouveauClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfaceNouveauClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomclient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailclient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.villeclient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adresseclient = new System.Windows.Forms.TextBox();
            this.annuler = new System.Windows.Forms.Button();
            this.modifierclient = new System.Windows.Forms.Button();
            this.ajouterclient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.telclient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "nouveau client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "nom:";
            // 
            // nomclient
            // 
            this.nomclient.Location = new System.Drawing.Point(236, 123);
            this.nomclient.Name = "nomclient";
            this.nomclient.Size = new System.Drawing.Size(130, 20);
            this.nomclient.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(155, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "email:";
            // 
            // emailclient
            // 
            this.emailclient.Location = new System.Drawing.Point(236, 228);
            this.emailclient.Name = "emailclient";
            this.emailclient.Size = new System.Drawing.Size(130, 20);
            this.emailclient.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "ville du client:";
            // 
            // villeclient
            // 
            this.villeclient.FormattingEnabled = true;
            this.villeclient.Items.AddRange(new object[] {
            "nabeul",
            "sousse",
            "tunis",
            "bizerte",
            "sfax",
            "monastir"});
            this.villeclient.Location = new System.Drawing.Point(236, 177);
            this.villeclient.Name = "villeclient";
            this.villeclient.Size = new System.Drawing.Size(130, 21);
            this.villeclient.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(90, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "adresse client:";
            // 
            // adresseclient
            // 
            this.adresseclient.Location = new System.Drawing.Point(236, 276);
            this.adresseclient.Name = "adresseclient";
            this.adresseclient.Size = new System.Drawing.Size(130, 20);
            this.adresseclient.TabIndex = 8;
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.ForeColor = System.Drawing.Color.ForestGreen;
            this.annuler.Location = new System.Drawing.Point(324, 376);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(118, 39);
            this.annuler.TabIndex = 10;
            this.annuler.Text = "annuler";
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // modifierclient
            // 
            this.modifierclient.BackColor = System.Drawing.Color.White;
            this.modifierclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierclient.ForeColor = System.Drawing.Color.ForestGreen;
            this.modifierclient.Location = new System.Drawing.Point(94, 376);
            this.modifierclient.Name = "modifierclient";
            this.modifierclient.Size = new System.Drawing.Size(118, 39);
            this.modifierclient.TabIndex = 11;
            this.modifierclient.Text = "modifier";
            this.modifierclient.UseVisualStyleBackColor = false;
            this.modifierclient.Visible = false;
            this.modifierclient.Click += new System.EventHandler(this.modifierclient_Click);
            // 
            // ajouterclient
            // 
            this.ajouterclient.BackColor = System.Drawing.Color.White;
            this.ajouterclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterclient.ForeColor = System.Drawing.Color.ForestGreen;
            this.ajouterclient.Location = new System.Drawing.Point(94, 376);
            this.ajouterclient.Name = "ajouterclient";
            this.ajouterclient.Size = new System.Drawing.Size(118, 39);
            this.ajouterclient.TabIndex = 12;
            this.ajouterclient.Text = "ajouter";
            this.ajouterclient.UseVisualStyleBackColor = false;
            this.ajouterclient.Click += new System.EventHandler(this.ajouterclient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(168, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "tel:";
            // 
            // telclient
            // 
            this.telclient.Location = new System.Drawing.Point(236, 325);
            this.telclient.Name = "telclient";
            this.telclient.Size = new System.Drawing.Size(130, 20);
            this.telclient.TabIndex = 14;
            // 
            // interfaceNouveauClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(535, 446);
            this.Controls.Add(this.telclient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ajouterclient);
            this.Controls.Add(this.modifierclient);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.adresseclient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.villeclient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailclient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomclient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "interfaceNouveauClient";
            this.Text = "nouveau client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomclient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailclient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox villeclient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adresseclient;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button modifierclient;
        private System.Windows.Forms.Button ajouterclient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telclient;
    }
}