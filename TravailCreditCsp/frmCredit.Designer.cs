namespace TravailCreditCsp
{
    partial class frmCredit
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdListeCredit = new System.Windows.Forms.Button();
            this.txtMensualité = new System.Windows.Forms.TextBox();
            this.cbxDurée = new System.Windows.Forms.ComboBox();
            this.lblMens = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtTaux = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtMontantFinancé = new System.Windows.Forms.TextBox();
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdListeCredit
            // 
            this.cmdListeCredit.Location = new System.Drawing.Point(140, 232);
            this.cmdListeCredit.Name = "cmdListeCredit";
            this.cmdListeCredit.Size = new System.Drawing.Size(101, 23);
            this.cmdListeCredit.TabIndex = 20;
            this.cmdListeCredit.Text = "Liste des crédits";
            this.cmdListeCredit.UseVisualStyleBackColor = true;
            this.cmdListeCredit.Click += new System.EventHandler(this.cmdListeCredit_Click);
            // 
            // txtMensualité
            // 
            this.txtMensualité.Location = new System.Drawing.Point(46, 169);
            this.txtMensualité.Name = "txtMensualité";
            this.txtMensualité.Size = new System.Drawing.Size(100, 20);
            this.txtMensualité.TabIndex = 19;
            // 
            // cbxDurée
            // 
            this.cbxDurée.FormattingEnabled = true;
            this.cbxDurée.Location = new System.Drawing.Point(47, 53);
            this.cbxDurée.Name = "cbxDurée";
            this.cbxDurée.Size = new System.Drawing.Size(121, 21);
            this.cbxDurée.TabIndex = 18;
            // 
            // lblMens
            // 
            this.lblMens.AutoSize = true;
            this.lblMens.Location = new System.Drawing.Point(44, 199);
            this.lblMens.Name = "lblMens";
            this.lblMens.Size = new System.Drawing.Size(57, 13);
            this.lblMens.TabIndex = 17;
            this.lblMens.Text = "mensualité";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(44, 127);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 13);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Taux annuel";
            // 
            // txtTaux
            // 
            this.txtTaux.Location = new System.Drawing.Point(47, 104);
            this.txtTaux.Name = "txtTaux";
            this.txtTaux.Size = new System.Drawing.Size(100, 20);
            this.txtTaux.TabIndex = 15;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(43, 77);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Durée en mois";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(44, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Montant du crédit";
            // 
            // TxtMontantFinancé
            // 
            this.TxtMontantFinancé.Location = new System.Drawing.Point(47, 6);
            this.TxtMontantFinancé.Name = "TxtMontantFinancé";
            this.TxtMontantFinancé.Size = new System.Drawing.Size(100, 20);
            this.TxtMontantFinancé.TabIndex = 12;
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Location = new System.Drawing.Point(47, 232);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcul.TabIndex = 11;
            this.cmdCalcul.Text = "calcul";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // frmCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdListeCredit);
            this.Controls.Add(this.txtMensualité);
            this.Controls.Add(this.cbxDurée);
            this.Controls.Add(this.lblMens);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtTaux);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtMontantFinancé);
            this.Controls.Add(this.cmdCalcul);
            this.Name = "frmCredit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdListeCredit;
        internal System.Windows.Forms.TextBox txtMensualité;
        internal System.Windows.Forms.ComboBox cbxDurée;
        internal System.Windows.Forms.Label lblMens;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtTaux;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtMontantFinancé;
        internal System.Windows.Forms.Button cmdCalcul;
    }
}

