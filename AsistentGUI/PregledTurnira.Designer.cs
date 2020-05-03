namespace AsistentGUI
{
    partial class PregledTurnira
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
            this.lblTurnir = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKolo = new System.Windows.Forms.Label();
            this.lblPrvaEkipa = new System.Windows.Forms.Label();
            this.lblDrugaEkipa = new System.Windows.Forms.Label();
            this.cmbKolo = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblRezultatPrveEkipe = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblRezultatDrugeEkipe = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtRezultatPrveEkipe = new System.Windows.Forms.TextBox();
            this.txtRezultatDrugeEkipe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTurnir
            // 
            this.lblTurnir.AutoSize = true;
            this.lblTurnir.Location = new System.Drawing.Point(70, 41);
            this.lblTurnir.Name = "lblTurnir";
            this.lblTurnir.Size = new System.Drawing.Size(37, 13);
            this.lblTurnir.TabIndex = 0;
            this.lblTurnir.Text = "Turnir:";
            this.lblTurnir.Click += new System.EventHandler(this.lblTurnir_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(113, 41);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "<naziv>";
            this.lblNaziv.Click += new System.EventHandler(this.lblNaziv_Click);
            // 
            // lblKolo
            // 
            this.lblKolo.AutoSize = true;
            this.lblKolo.Location = new System.Drawing.Point(72, 70);
            this.lblKolo.Name = "lblKolo";
            this.lblKolo.Size = new System.Drawing.Size(31, 13);
            this.lblKolo.TabIndex = 2;
            this.lblKolo.Text = "Kolo:";
            this.lblKolo.Click += new System.EventHandler(this.lblKolo_Click);
            // 
            // lblPrvaEkipa
            // 
            this.lblPrvaEkipa.AutoSize = true;
            this.lblPrvaEkipa.Location = new System.Drawing.Point(286, 145);
            this.lblPrvaEkipa.Name = "lblPrvaEkipa";
            this.lblPrvaEkipa.Size = new System.Drawing.Size(67, 13);
            this.lblPrvaEkipa.TabIndex = 3;
            this.lblPrvaEkipa.Text = "<prvaEkipa>";
            this.lblPrvaEkipa.Click += new System.EventHandler(this.lblPrvaEkipa_Click);
            // 
            // lblDrugaEkipa
            // 
            this.lblDrugaEkipa.AutoSize = true;
            this.lblDrugaEkipa.Location = new System.Drawing.Point(575, 145);
            this.lblDrugaEkipa.Name = "lblDrugaEkipa";
            this.lblDrugaEkipa.Size = new System.Drawing.Size(73, 13);
            this.lblDrugaEkipa.TabIndex = 4;
            this.lblDrugaEkipa.Text = "<drugaEkipa>";
            // 
            // cmbKolo
            // 
            this.cmbKolo.FormattingEnabled = true;
            this.cmbKolo.Location = new System.Drawing.Point(109, 67);
            this.cmbKolo.Name = "cmbKolo";
            this.cmbKolo.Size = new System.Drawing.Size(121, 21);
            this.cmbKolo.TabIndex = 5;
            this.cmbKolo.SelectedIndexChanged += new System.EventHandler(this.cmbKolo_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(90, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Prikaži neodigrane utakmice";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(109, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblRezultatPrveEkipe
            // 
            this.lblRezultatPrveEkipe.AutoSize = true;
            this.lblRezultatPrveEkipe.Location = new System.Drawing.Point(286, 175);
            this.lblRezultatPrveEkipe.Name = "lblRezultatPrveEkipe";
            this.lblRezultatPrveEkipe.Size = new System.Drawing.Size(49, 13);
            this.lblRezultatPrveEkipe.TabIndex = 8;
            this.lblRezultatPrveEkipe.Text = "Rezultat:";
            this.lblRezultatPrveEkipe.Click += new System.EventHandler(this.lblRezultatPrveEkipe_Click);
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(461, 165);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(27, 13);
            this.lblVS.TabIndex = 9;
            this.lblVS.Text = "-VS-";
            this.lblVS.Click += new System.EventHandler(this.lblVS_Click);
            // 
            // lblRezultatDrugeEkipe
            // 
            this.lblRezultatDrugeEkipe.AutoSize = true;
            this.lblRezultatDrugeEkipe.Location = new System.Drawing.Point(575, 175);
            this.lblRezultatDrugeEkipe.Name = "lblRezultatDrugeEkipe";
            this.lblRezultatDrugeEkipe.Size = new System.Drawing.Size(49, 13);
            this.lblRezultatDrugeEkipe.TabIndex = 10;
            this.lblRezultatDrugeEkipe.Text = "Rezultat:";
            this.lblRezultatDrugeEkipe.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(445, 231);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 11;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(336, 312);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(104, 23);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtRezultatPrveEkipe
            // 
            this.txtRezultatPrveEkipe.Location = new System.Drawing.Point(355, 175);
            this.txtRezultatPrveEkipe.Name = "txtRezultatPrveEkipe";
            this.txtRezultatPrveEkipe.Size = new System.Drawing.Size(100, 20);
            this.txtRezultatPrveEkipe.TabIndex = 13;
            this.txtRezultatPrveEkipe.TextChanged += new System.EventHandler(this.txtRezultatPrveEkipe_TextChanged);
            // 
            // txtRezultatDrugeEkipe
            // 
            this.txtRezultatDrugeEkipe.Location = new System.Drawing.Point(630, 175);
            this.txtRezultatDrugeEkipe.Name = "txtRezultatDrugeEkipe";
            this.txtRezultatDrugeEkipe.Size = new System.Drawing.Size(100, 20);
            this.txtRezultatDrugeEkipe.TabIndex = 14;
            // 
            // PregledTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRezultatDrugeEkipe);
            this.Controls.Add(this.txtRezultatPrveEkipe);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblRezultatDrugeEkipe);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblRezultatPrveEkipe);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbKolo);
            this.Controls.Add(this.lblDrugaEkipa);
            this.Controls.Add(this.lblPrvaEkipa);
            this.Controls.Add(this.lblKolo);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblTurnir);
            this.Name = "PregledTurnira";
            this.Text = "PregledTurnira";
            this.Load += new System.EventHandler(this.PregledTurnira_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnir;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKolo;
        private System.Windows.Forms.Label lblPrvaEkipa;
        private System.Windows.Forms.Label lblDrugaEkipa;
        private System.Windows.Forms.ComboBox cmbKolo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblRezultatPrveEkipe;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblRezultatDrugeEkipe;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtRezultatPrveEkipe;
        private System.Windows.Forms.TextBox txtRezultatDrugeEkipe;
    }
}