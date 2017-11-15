namespace FIGURY
{
    partial class Form1
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbxKolo = new System.Windows.Forms.RadioButton();
            this.cbxKula = new System.Windows.Forms.RadioButton();
            this.cbxWalec = new System.Windows.Forms.RadioButton();
            this.cbxStozek = new System.Windows.Forms.RadioButton();
            this.btnUsun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblParametry = new System.Windows.Forms.Label();
            this.lbxListaFigur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(12, 36);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(215, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbxKolo
            // 
            this.cbxKolo.AutoSize = true;
            this.cbxKolo.Location = new System.Drawing.Point(13, 13);
            this.cbxKolo.Name = "cbxKolo";
            this.cbxKolo.Size = new System.Drawing.Size(48, 17);
            this.cbxKolo.TabIndex = 1;
            this.cbxKolo.TabStop = true;
            this.cbxKolo.Text = "Koło";
            this.cbxKolo.UseVisualStyleBackColor = true;
            this.cbxKolo.CheckedChanged += new System.EventHandler(this.cbxKolo_CheckedChanged);
            // 
            // cbxKula
            // 
            this.cbxKula.AutoSize = true;
            this.cbxKula.Location = new System.Drawing.Point(67, 13);
            this.cbxKula.Name = "cbxKula";
            this.cbxKula.Size = new System.Drawing.Size(46, 17);
            this.cbxKula.TabIndex = 2;
            this.cbxKula.TabStop = true;
            this.cbxKula.Text = "Kula";
            this.cbxKula.UseVisualStyleBackColor = true;
            this.cbxKula.CheckedChanged += new System.EventHandler(this.cbxKula_CheckedChanged);
            // 
            // cbxWalec
            // 
            this.cbxWalec.AutoSize = true;
            this.cbxWalec.Location = new System.Drawing.Point(116, 13);
            this.cbxWalec.Name = "cbxWalec";
            this.cbxWalec.Size = new System.Drawing.Size(56, 17);
            this.cbxWalec.TabIndex = 3;
            this.cbxWalec.TabStop = true;
            this.cbxWalec.Text = "Walec";
            this.cbxWalec.UseVisualStyleBackColor = true;
            this.cbxWalec.CheckedChanged += new System.EventHandler(this.cbxWalec_CheckedChanged);
            // 
            // cbxStozek
            // 
            this.cbxStozek.AutoSize = true;
            this.cbxStozek.Location = new System.Drawing.Point(169, 13);
            this.cbxStozek.Name = "cbxStozek";
            this.cbxStozek.Size = new System.Drawing.Size(58, 17);
            this.cbxStozek.TabIndex = 4;
            this.cbxStozek.TabStop = true;
            this.cbxStozek.Text = "Stożek";
            this.cbxStozek.UseVisualStyleBackColor = true;
            this.cbxStozek.CheckedChanged += new System.EventHandler(this.cbxStozek_CheckedChanged);
            // 
            // btnUsun
            // 
            this.btnUsun.Enabled = false;
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(13, 65);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(215, 23);
            this.btnUsun.TabIndex = 5;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(248, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parametry:";
            // 
            // lblParametry
            // 
            this.lblParametry.AutoSize = true;
            this.lblParametry.Location = new System.Drawing.Point(250, 95);
            this.lblParametry.Name = "lblParametry";
            this.lblParametry.Size = new System.Drawing.Size(0, 13);
            this.lblParametry.TabIndex = 8;
            // 
            // lbxListaFigur
            // 
            this.lbxListaFigur.FormattingEnabled = true;
            this.lbxListaFigur.Location = new System.Drawing.Point(13, 94);
            this.lbxListaFigur.Name = "lbxListaFigur";
            this.lbxListaFigur.Size = new System.Drawing.Size(216, 160);
            this.lbxListaFigur.TabIndex = 9;
            this.lbxListaFigur.SelectedIndexChanged += new System.EventHandler(this.lbxListaFigur_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 266);
            this.Controls.Add(this.lbxListaFigur);
            this.Controls.Add(this.lblParametry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.cbxStozek);
            this.Controls.Add(this.cbxWalec);
            this.Controls.Add(this.cbxKula);
            this.Controls.Add(this.cbxKolo);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.RadioButton cbxKolo;
        private System.Windows.Forms.RadioButton cbxKula;
        private System.Windows.Forms.RadioButton cbxWalec;
        private System.Windows.Forms.RadioButton cbxStozek;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParametry;
        private System.Windows.Forms.ListBox lbxListaFigur;
    }
}

