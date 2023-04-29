
namespace Probleme_Fleur
{
    partial class Page_inscription
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
            this.box_nom = new System.Windows.Forms.TextBox();
            this.box_prenom = new System.Windows.Forms.TextBox();
            this.box_tel = new System.Windows.Forms.TextBox();
            this.box_mail = new System.Windows.Forms.TextBox();
            this.box_mdp = new System.Windows.Forms.TextBox();
            this.box_adresse = new System.Windows.Forms.TextBox();
            this.box_CB = new System.Windows.Forms.TextBox();
            this.Inscription = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.no_tel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.erreurnom = new System.Windows.Forms.Label();
            this.erreurprenom = new System.Windows.Forms.Label();
            this.erreurtel = new System.Windows.Forms.Label();
            this.erreurmail = new System.Windows.Forms.Label();
            this.erreurmdp = new System.Windows.Forms.Label();
            this.erreurCB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box_nom
            // 
            this.box_nom.Location = new System.Drawing.Point(341, 65);
            this.box_nom.Name = "box_nom";
            this.box_nom.Size = new System.Drawing.Size(125, 27);
            this.box_nom.TabIndex = 0;
            this.box_nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // box_prenom
            // 
            this.box_prenom.Location = new System.Drawing.Point(341, 113);
            this.box_prenom.Name = "box_prenom";
            this.box_prenom.Size = new System.Drawing.Size(125, 27);
            this.box_prenom.TabIndex = 1;
            this.box_prenom.TextChanged += new System.EventHandler(this.box_prenom_TextChanged);
            // 
            // box_tel
            // 
            this.box_tel.Location = new System.Drawing.Point(341, 160);
            this.box_tel.Name = "box_tel";
            this.box_tel.Size = new System.Drawing.Size(125, 27);
            this.box_tel.TabIndex = 2;
            this.box_tel.TextChanged += new System.EventHandler(this.box_tel_TextChanged);
            // 
            // box_mail
            // 
            this.box_mail.Location = new System.Drawing.Point(341, 210);
            this.box_mail.Name = "box_mail";
            this.box_mail.Size = new System.Drawing.Size(125, 27);
            this.box_mail.TabIndex = 3;
            this.box_mail.TextChanged += new System.EventHandler(this.box_mail_TextChanged);
            // 
            // box_mdp
            // 
            this.box_mdp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_mdp.Location = new System.Drawing.Point(341, 256);
            this.box_mdp.Name = "box_mdp";
            this.box_mdp.Size = new System.Drawing.Size(125, 27);
            this.box_mdp.TabIndex = 4;
            this.box_mdp.TextChanged += new System.EventHandler(this.box_mdp_TextChanged);
            // 
            // box_adresse
            // 
            this.box_adresse.Location = new System.Drawing.Point(341, 303);
            this.box_adresse.Name = "box_adresse";
            this.box_adresse.Size = new System.Drawing.Size(125, 27);
            this.box_adresse.TabIndex = 5;
            this.box_adresse.TextChanged += new System.EventHandler(this.box_adresse_TextChanged);
            // 
            // box_CB
            // 
            this.box_CB.Location = new System.Drawing.Point(341, 353);
            this.box_CB.Name = "box_CB";
            this.box_CB.Size = new System.Drawing.Size(125, 27);
            this.box_CB.TabIndex = 6;
            this.box_CB.TextChanged += new System.EventHandler(this.box_CB_TextChanged);
            // 
            // Inscription
            // 
            this.Inscription.Location = new System.Drawing.Point(356, 397);
            this.Inscription.Name = "Inscription";
            this.Inscription.Size = new System.Drawing.Size(94, 29);
            this.Inscription.TabIndex = 7;
            this.Inscription.Text = "Inscription";
            this.Inscription.UseVisualStyleBackColor = true;
            this.Inscription.Click += new System.EventHandler(this.Inscription_Click);
            // 
            // CB
            // 
            this.CB.AutoSize = true;
            this.CB.Location = new System.Drawing.Point(341, 333);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(103, 20);
            this.CB.TabIndex = 8;
            this.CB.Text = "numero de CB";
            // 
            // adresse
            // 
            this.adresse.AutoSize = true;
            this.adresse.Location = new System.Drawing.Point(341, 286);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(139, 20);
            this.adresse.TabIndex = 9;
            this.adresse.Text = "adresse de livraison";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(341, 240);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(98, 20);
            this.mdp.TabIndex = 10;
            this.mdp.Text = "mot de passe";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(341, 190);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(54, 20);
            this.mail.TabIndex = 11;
            this.mail.Text = "couriel";
            // 
            // no_tel
            // 
            this.no_tel.AutoSize = true;
            this.no_tel.Location = new System.Drawing.Point(341, 143);
            this.no_tel.Name = "no_tel";
            this.no_tel.Size = new System.Drawing.Size(155, 20);
            this.no_tel.TabIndex = 12;
            this.no_tel.Text = "Numéro de téléphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prénom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(354, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "INSCRIPTION";
            // 
            // erreurnom
            // 
            this.erreurnom.AutoSize = true;
            this.erreurnom.ForeColor = System.Drawing.Color.Red;
            this.erreurnom.Location = new System.Drawing.Point(470, 70);
            this.erreurnom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurnom.Name = "erreurnom";
            this.erreurnom.Size = new System.Drawing.Size(116, 20);
            this.erreurnom.TabIndex = 16;
            this.erreurnom.Text = "format incorrect";
            // 
            // erreurprenom
            // 
            this.erreurprenom.AutoSize = true;
            this.erreurprenom.ForeColor = System.Drawing.Color.Red;
            this.erreurprenom.Location = new System.Drawing.Point(470, 118);
            this.erreurprenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurprenom.Name = "erreurprenom";
            this.erreurprenom.Size = new System.Drawing.Size(116, 20);
            this.erreurprenom.TabIndex = 17;
            this.erreurprenom.Text = "format incorrect";
            // 
            // erreurtel
            // 
            this.erreurtel.AutoSize = true;
            this.erreurtel.ForeColor = System.Drawing.Color.Red;
            this.erreurtel.Location = new System.Drawing.Point(470, 165);
            this.erreurtel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurtel.Name = "erreurtel";
            this.erreurtel.Size = new System.Drawing.Size(116, 20);
            this.erreurtel.TabIndex = 18;
            this.erreurtel.Text = "format incorrect";
            // 
            // erreurmail
            // 
            this.erreurmail.AutoSize = true;
            this.erreurmail.ForeColor = System.Drawing.Color.Red;
            this.erreurmail.Location = new System.Drawing.Point(470, 214);
            this.erreurmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurmail.Name = "erreurmail";
            this.erreurmail.Size = new System.Drawing.Size(116, 20);
            this.erreurmail.TabIndex = 19;
            this.erreurmail.Text = "format incorrect";
            // 
            // erreurmdp
            // 
            this.erreurmdp.AutoSize = true;
            this.erreurmdp.ForeColor = System.Drawing.Color.Red;
            this.erreurmdp.Location = new System.Drawing.Point(470, 258);
            this.erreurmdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurmdp.Name = "erreurmdp";
            this.erreurmdp.Size = new System.Drawing.Size(116, 20);
            this.erreurmdp.TabIndex = 20;
            this.erreurmdp.Text = "format incorrect";
            // 
            // erreurCB
            // 
            this.erreurCB.AutoSize = true;
            this.erreurCB.ForeColor = System.Drawing.Color.Red;
            this.erreurCB.Location = new System.Drawing.Point(470, 353);
            this.erreurCB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurCB.Name = "erreurCB";
            this.erreurCB.Size = new System.Drawing.Size(116, 20);
            this.erreurCB.TabIndex = 22;
            this.erreurCB.Text = "format incorrect";
            // 
            // Page_inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.erreurCB);
            this.Controls.Add(this.erreurmdp);
            this.Controls.Add(this.erreurmail);
            this.Controls.Add(this.erreurtel);
            this.Controls.Add(this.erreurprenom);
            this.Controls.Add(this.erreurnom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.no_tel);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.Inscription);
            this.Controls.Add(this.box_CB);
            this.Controls.Add(this.box_adresse);
            this.Controls.Add(this.box_mdp);
            this.Controls.Add(this.box_mail);
            this.Controls.Add(this.box_tel);
            this.Controls.Add(this.box_prenom);
            this.Controls.Add(this.box_nom);
            this.Name = "Page_inscription";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Page_inscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_nom;
        private System.Windows.Forms.TextBox box_prenom;
        private System.Windows.Forms.TextBox box_tel;
        private System.Windows.Forms.TextBox box_mail;
        private System.Windows.Forms.TextBox box_mdp;
        private System.Windows.Forms.TextBox box_adresse;
        private System.Windows.Forms.TextBox box_CB;
        private System.Windows.Forms.Button Inscription;
        private System.Windows.Forms.Label CB;
        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label no_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label erreurnom;
        private System.Windows.Forms.Label erreurprenom;
        private System.Windows.Forms.Label erreurtel;
        private System.Windows.Forms.Label erreurmail;
        private System.Windows.Forms.Label erreurmdp;
        private System.Windows.Forms.Label erreurCB;
    }
}