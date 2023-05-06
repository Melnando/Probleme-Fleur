
namespace Probleme_Fleur
{
    partial class Page_connexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inscription = new System.Windows.Forms.Button();
            this.Connexion = new System.Windows.Forms.Button();
            this.box_mail = new System.Windows.Forms.TextBox();
            this.box_mdp = new System.Windows.Forms.TextBox();
            this.couriel = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.validateur = new System.Windows.Forms.Button();
            this.erreurmail = new System.Windows.Forms.Label();
            this.erreurmdp = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.LinkLabel();
            this.mdp_admin = new System.Windows.Forms.TextBox();
            this.statistiques = new System.Windows.Forms.Button();
            this.etat_cmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inscription
            // 
            this.Inscription.Location = new System.Drawing.Point(362, 138);
            this.Inscription.Name = "Inscription";
            this.Inscription.Size = new System.Drawing.Size(94, 29);
            this.Inscription.TabIndex = 0;
            this.Inscription.Text = "Inscription";
            this.Inscription.UseVisualStyleBackColor = true;
            this.Inscription.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connexion
            // 
            this.Connexion.Location = new System.Drawing.Point(362, 199);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(94, 29);
            this.Connexion.TabIndex = 1;
            this.Connexion.Text = "Connexion";
            this.Connexion.UseVisualStyleBackColor = true;
            this.Connexion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // box_mail
            // 
            this.box_mail.Location = new System.Drawing.Point(347, 258);
            this.box_mail.Name = "box_mail";
            this.box_mail.Size = new System.Drawing.Size(125, 27);
            this.box_mail.TabIndex = 2;
            this.box_mail.TextChanged += new System.EventHandler(this.box_mail_TextChanged);
            // 
            // box_mdp
            // 
            this.box_mdp.Location = new System.Drawing.Point(347, 309);
            this.box_mdp.Name = "box_mdp";
            this.box_mdp.Size = new System.Drawing.Size(125, 27);
            this.box_mdp.TabIndex = 3;
            this.box_mdp.TextChanged += new System.EventHandler(this.box_mdp_TextChanged);
            // 
            // couriel
            // 
            this.couriel.AutoSize = true;
            this.couriel.Location = new System.Drawing.Point(347, 235);
            this.couriel.Name = "couriel";
            this.couriel.Size = new System.Drawing.Size(56, 20);
            this.couriel.TabIndex = 4;
            this.couriel.Text = "Couriel";
            this.couriel.Click += new System.EventHandler(this.label1_Click);
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(347, 289);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(98, 20);
            this.mdp.TabIndex = 5;
            this.mdp.Text = "Mot de passe";
            // 
            // validateur
            // 
            this.validateur.Location = new System.Drawing.Point(362, 356);
            this.validateur.Name = "validateur";
            this.validateur.Size = new System.Drawing.Size(94, 29);
            this.validateur.TabIndex = 6;
            this.validateur.Text = "valider";
            this.validateur.UseVisualStyleBackColor = true;
            this.validateur.Click += new System.EventHandler(this.validateur_Click);
            // 
            // erreurmail
            // 
            this.erreurmail.AutoSize = true;
            this.erreurmail.ForeColor = System.Drawing.Color.Red;
            this.erreurmail.Location = new System.Drawing.Point(478, 261);
            this.erreurmail.Name = "erreurmail";
            this.erreurmail.Size = new System.Drawing.Size(123, 20);
            this.erreurmail.TabIndex = 7;
            this.erreurmail.Text = "Couriel inexistant";
            // 
            // erreurmdp
            // 
            this.erreurmdp.AutoSize = true;
            this.erreurmdp.ForeColor = System.Drawing.Color.Red;
            this.erreurmdp.Location = new System.Drawing.Point(478, 312);
            this.erreurmdp.Name = "erreurmdp";
            this.erreurmdp.Size = new System.Drawing.Size(160, 20);
            this.erreurmdp.TabIndex = 8;
            this.erreurmdp.Text = "Mot de passe incorrect";
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(12, 9);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(158, 20);
            this.Admin.TabIndex = 9;
            this.Admin.TabStop = true;
            this.Admin.Text = "Session administrateur";
            this.Admin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Admin_LinkClicked);
            // 
            // mdp_admin
            // 
            this.mdp_admin.Location = new System.Drawing.Point(12, 32);
            this.mdp_admin.Name = "mdp_admin";
            this.mdp_admin.Size = new System.Drawing.Size(158, 27);
            this.mdp_admin.TabIndex = 10;
            this.mdp_admin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // statistiques
            // 
            this.statistiques.Location = new System.Drawing.Point(12, 65);
            this.statistiques.Name = "statistiques";
            this.statistiques.Size = new System.Drawing.Size(158, 30);
            this.statistiques.TabIndex = 11;
            this.statistiques.Text = "Statistiques";
            this.statistiques.UseVisualStyleBackColor = true;
            this.statistiques.Click += new System.EventHandler(this.statistiques_Click);
            // 
            // etat_cmd
            // 
            this.etat_cmd.Location = new System.Drawing.Point(12, 101);
            this.etat_cmd.Name = "etat_cmd";
            this.etat_cmd.Size = new System.Drawing.Size(158, 29);
            this.etat_cmd.TabIndex = 12;
            this.etat_cmd.Text = "Etat des commandes";
            this.etat_cmd.UseVisualStyleBackColor = true;
            this.etat_cmd.Click += new System.EventHandler(this.etat_cmd_Click);
            // 
            // Page_connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etat_cmd);
            this.Controls.Add(this.statistiques);
            this.Controls.Add(this.mdp_admin);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.erreurmdp);
            this.Controls.Add(this.erreurmail);
            this.Controls.Add(this.validateur);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.couriel);
            this.Controls.Add(this.box_mdp);
            this.Controls.Add(this.box_mail);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.Inscription);
            this.Name = "Page_connexion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inscription;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.TextBox box_mail;
        private System.Windows.Forms.TextBox box_mdp;
        private System.Windows.Forms.Label couriel;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Button validateur;
        private System.Windows.Forms.Label erreurmail;
        private System.Windows.Forms.Label erreurmdp;
        private System.Windows.Forms.LinkLabel Admin;
        private System.Windows.Forms.TextBox mdp_admin;
        private System.Windows.Forms.Button statistiques;
        private System.Windows.Forms.Button etat_cmd;
    }
}

