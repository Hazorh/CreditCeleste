namespace TravailCreditCsp
{
    partial class frmListCredit
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
            this.CmdCredit = new System.Windows.Forms.Button();
            this.cmdInit = new System.Windows.Forms.Button();
            this.lsbCredit = new System.Windows.Forms.ListBox();
            this.cmdEnregistre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdCredit
            // 
            this.CmdCredit.Location = new System.Drawing.Point(203, 185);
            this.CmdCredit.Name = "CmdCredit";
            this.CmdCredit.Size = new System.Drawing.Size(75, 23);
            this.CmdCredit.TabIndex = 5;
            this.CmdCredit.Text = "credit";
            this.CmdCredit.UseVisualStyleBackColor = true;
            this.CmdCredit.Click += new System.EventHandler(this.CmdCredit_Click);
            // 
            // cmdInit
            // 
            this.cmdInit.Location = new System.Drawing.Point(79, 185);
            this.cmdInit.Name = "cmdInit";
            this.cmdInit.Size = new System.Drawing.Size(75, 23);
            this.cmdInit.TabIndex = 4;
            this.cmdInit.Text = "Init";
            this.cmdInit.UseVisualStyleBackColor = true;
            this.cmdInit.Click += new System.EventHandler(this.cmdInit_Click);
            // 
            // lsbCredit
            // 
            this.lsbCredit.FormattingEnabled = true;
            this.lsbCredit.Location = new System.Drawing.Point(32, 46);
            this.lsbCredit.Name = "lsbCredit";
            this.lsbCredit.Size = new System.Drawing.Size(415, 95);
            this.lsbCredit.TabIndex = 3;
            // 
            // cmdEnregistre
            // 
            this.cmdEnregistre.Location = new System.Drawing.Point(328, 185);
            this.cmdEnregistre.Name = "cmdEnregistre";
            this.cmdEnregistre.Size = new System.Drawing.Size(75, 23);
            this.cmdEnregistre.TabIndex = 6;
            this.cmdEnregistre.Text = "Enregistre";
            this.cmdEnregistre.UseVisualStyleBackColor = true;
            this.cmdEnregistre.Click += new System.EventHandler(this.cmdEnregistre_Click);
            // 
            // frmListCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 261);
            this.Controls.Add(this.cmdEnregistre);
            this.Controls.Add(this.CmdCredit);
            this.Controls.Add(this.cmdInit);
            this.Controls.Add(this.lsbCredit);
            this.Name = "frmListCredit";
            this.Text = "frmListCredit";
            this.Load += new System.EventHandler(this.frmListCredit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button CmdCredit;
        internal System.Windows.Forms.Button cmdInit;
        internal System.Windows.Forms.ListBox lsbCredit;
        internal System.Windows.Forms.Button cmdEnregistre;
    }
}