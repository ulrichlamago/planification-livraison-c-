namespace projetc
{
    partial class FenetreColis
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
            this.panecolis = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panecolis
            // 
            this.panecolis.BackColor = System.Drawing.Color.Yellow;
            this.panecolis.Location = new System.Drawing.Point(0, 0);
            this.panecolis.Name = "panecolis";
            this.panecolis.Size = new System.Drawing.Size(918, 527);
            this.panecolis.TabIndex = 0;
            // 
            // FenetreColis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(917, 528);
            this.Controls.Add(this.panecolis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(154, 0);
            this.Name = "FenetreColis";
            this.Text = "FenetreColis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panecolis;
    }
}