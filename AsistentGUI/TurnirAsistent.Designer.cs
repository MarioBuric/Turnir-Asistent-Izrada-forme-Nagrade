namespace AsistentGUI
{
    partial class TurnirAsistent
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNazivTurnira = new System.Windows.Forms.ComboBox();
            this.btnUcitajTurnir = new System.Windows.Forms.Button();
            this.btnKreirajNoviTurnir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbNazivTurnira
            // 
            this.cmbNazivTurnira.FormattingEnabled = true;
            this.cmbNazivTurnira.Location = new System.Drawing.Point(240, 61);
            this.cmbNazivTurnira.Name = "cmbNazivTurnira";
            this.cmbNazivTurnira.Size = new System.Drawing.Size(121, 21);
            this.cmbNazivTurnira.TabIndex = 1;
            this.cmbNazivTurnira.SelectedIndexChanged += new System.EventHandler(this.cmbNazivTurnira_SelectedIndexChanged);
            // 
            // btnUcitajTurnir
            // 
            this.btnUcitajTurnir.Location = new System.Drawing.Point(200, 106);
            this.btnUcitajTurnir.Name = "btnUcitajTurnir";
            this.btnUcitajTurnir.Size = new System.Drawing.Size(161, 23);
            this.btnUcitajTurnir.TabIndex = 2;
            this.btnUcitajTurnir.Text = "Učitaj postojeći turnir";
            this.btnUcitajTurnir.UseVisualStyleBackColor = true;
            this.btnUcitajTurnir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKreirajNoviTurnir
            // 
            this.btnKreirajNoviTurnir.Location = new System.Drawing.Point(200, 150);
            this.btnKreirajNoviTurnir.Name = "btnKreirajNoviTurnir";
            this.btnKreirajNoviTurnir.Size = new System.Drawing.Size(161, 23);
            this.btnKreirajNoviTurnir.TabIndex = 3;
            this.btnKreirajNoviTurnir.Text = "Kreiraj novi turnir";
            this.btnKreirajNoviTurnir.UseVisualStyleBackColor = true;
            this.btnKreirajNoviTurnir.Click += new System.EventHandler(this.btnKreirajNoviTurnir_Click);
            // 
            // TurnirAsistent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKreirajNoviTurnir);
            this.Controls.Add(this.btnUcitajTurnir);
            this.Controls.Add(this.cmbNazivTurnira);
            this.Controls.Add(this.label1);
            this.Name = "TurnirAsistent";
            this.Text = "TurnirAsistent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNazivTurnira;
        private System.Windows.Forms.Button btnUcitajTurnir;
        private System.Windows.Forms.Button btnKreirajNoviTurnir;
    }
}