
namespace Probleme_Fleur
{
    partial class Bon
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
            this.boutonstandard = new System.Windows.Forms.RadioButton();
            this.Boutonpersonnalisee = new System.Windows.Forms.RadioButton();
            this.box_catégorie = new System.Windows.Forms.ComboBox();
            this.choix_fleurs = new System.Windows.Forms.CheckedListBox();
            this.box_adresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_zip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.box_message = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_composition = new System.Windows.Forms.Label();
            this.Avertissement = new System.Windows.Forms.Label();
            this.box_nom = new System.Windows.Forms.ComboBox();
            this.label_prix = new System.Windows.Forms.Label();
            this.validation = new System.Windows.Forms.Button();
            this.box_budget = new System.Windows.Forms.NumericUpDown();
            this.label_budget = new System.Windows.Forms.Label();
            this.erreuradresse = new System.Windows.Forms.Label();
            this.erreurstandard = new System.Windows.Forms.Label();
            this.erreurperso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box_budget)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouvelle commande";
            // 
            // boutonstandard
            // 
            this.boutonstandard.AutoSize = true;
            this.boutonstandard.Location = new System.Drawing.Point(129, 45);
            this.boutonstandard.Name = "boutonstandard";
            this.boutonstandard.Size = new System.Drawing.Size(90, 24);
            this.boutonstandard.TabIndex = 1;
            this.boutonstandard.TabStop = true;
            this.boutonstandard.Text = "Standard";
            this.boutonstandard.UseVisualStyleBackColor = true;
            this.boutonstandard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Boutonpersonnalisee
            // 
            this.Boutonpersonnalisee.AutoSize = true;
            this.Boutonpersonnalisee.Location = new System.Drawing.Point(550, 45);
            this.Boutonpersonnalisee.Name = "Boutonpersonnalisee";
            this.Boutonpersonnalisee.Size = new System.Drawing.Size(119, 24);
            this.Boutonpersonnalisee.TabIndex = 2;
            this.Boutonpersonnalisee.TabStop = true;
            this.Boutonpersonnalisee.Text = "Personnalisée";
            this.Boutonpersonnalisee.UseVisualStyleBackColor = true;
            this.Boutonpersonnalisee.CheckedChanged += new System.EventHandler(this.Boutonpersonnalisee_CheckedChanged);
            // 
            // box_catégorie
            // 
            this.box_catégorie.FormattingEnabled = true;
            this.box_catégorie.Location = new System.Drawing.Point(90, 75);
            this.box_catégorie.Name = "box_catégorie";
            this.box_catégorie.Size = new System.Drawing.Size(151, 28);
            this.box_catégorie.TabIndex = 3;
            this.box_catégorie.Text = "Catégorie";
            this.box_catégorie.SelectedIndexChanged += new System.EventHandler(this.box_catégorie_SelectedIndexChanged);
            // 
            // choix_fleurs
            // 
            this.choix_fleurs.CheckOnClick = true;
            this.choix_fleurs.FormattingEnabled = true;
            this.choix_fleurs.Location = new System.Drawing.Point(468, 75);
            this.choix_fleurs.Name = "choix_fleurs";
            this.choix_fleurs.Size = new System.Drawing.Size(291, 114);
            this.choix_fleurs.TabIndex = 4;
            this.choix_fleurs.SelectedIndexChanged += new System.EventHandler(this.choix_fleurs_SelectedIndexChanged);
            // 
            // box_adresse
            // 
            this.box_adresse.Location = new System.Drawing.Point(90, 230);
            this.box_adresse.Name = "box_adresse";
            this.box_adresse.Size = new System.Drawing.Size(342, 27);
            this.box_adresse.TabIndex = 5;
            this.box_adresse.TextChanged += new System.EventHandler(this.box_adresse_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresse de livraison";
            // 
            // box_zip
            // 
            this.box_zip.Location = new System.Drawing.Point(468, 230);
            this.box_zip.Name = "box_zip";
            this.box_zip.Size = new System.Drawing.Size(103, 27);
            this.box_zip.TabIndex = 7;
            this.box_zip.TextChanged += new System.EventHandler(this.box_zip_TextChanged);
            this.box_zip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_zip_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Code postal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(606, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ville";
            // 
            // box_message
            // 
            this.box_message.Location = new System.Drawing.Point(90, 292);
            this.box_message.Name = "box_message";
            this.box_message.Size = new System.Drawing.Size(669, 62);
            this.box_message.TabIndex = 11;
            this.box_message.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date de Livraison";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 380);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 4, 30, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 30, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label_composition
            // 
            this.label_composition.AutoSize = true;
            this.label_composition.Location = new System.Drawing.Point(90, 169);
            this.label_composition.Name = "label_composition";
            this.label_composition.Size = new System.Drawing.Size(94, 20);
            this.label_composition.TabIndex = 15;
            this.label_composition.Text = "Composition";
            // 
            // Avertissement
            // 
            this.Avertissement.AutoSize = true;
            this.Avertissement.ForeColor = System.Drawing.Color.Red;
            this.Avertissement.Location = new System.Drawing.Point(90, 409);
            this.Avertissement.Name = "Avertissement";
            this.Avertissement.Size = new System.Drawing.Size(102, 20);
            this.Avertissement.TabIndex = 16;
            this.Avertissement.Text = "Avertissement";
            // 
            // box_nom
            // 
            this.box_nom.FormattingEnabled = true;
            this.box_nom.Location = new System.Drawing.Point(90, 125);
            this.box_nom.Name = "box_nom";
            this.box_nom.Size = new System.Drawing.Size(151, 28);
            this.box_nom.TabIndex = 17;
            this.box_nom.Text = "Bouquet";
            this.box_nom.SelectedIndexChanged += new System.EventHandler(this.box_nom_SelectedIndexChanged);
            // 
            // label_prix
            // 
            this.label_prix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_prix.AutoSize = true;
            this.label_prix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_prix.Location = new System.Drawing.Point(268, 525);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(247, 28);
            this.label_prix.TabIndex = 18;
            this.label_prix.Text = "Montant de la commande :";
            this.label_prix.Click += new System.EventHandler(this.label8_Click);
            // 
            // validation
            // 
            this.validation.Location = new System.Drawing.Point(338, 556);
            this.validation.Name = "validation";
            this.validation.Size = new System.Drawing.Size(94, 29);
            this.validation.TabIndex = 19;
            this.validation.Text = "Valider";
            this.validation.UseVisualStyleBackColor = true;
            this.validation.Click += new System.EventHandler(this.validation_Click);
            // 
            // box_budget
            // 
            this.box_budget.DecimalPlaces = 2;
            this.box_budget.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.box_budget.Location = new System.Drawing.Point(320, 479);
            this.box_budget.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.box_budget.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.box_budget.Name = "box_budget";
            this.box_budget.Size = new System.Drawing.Size(150, 27);
            this.box_budget.TabIndex = 20;
            this.box_budget.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_budget
            // 
            this.label_budget.AutoSize = true;
            this.label_budget.Location = new System.Drawing.Point(353, 456);
            this.label_budget.Name = "label_budget";
            this.label_budget.Size = new System.Drawing.Size(69, 20);
            this.label_budget.TabIndex = 21;
            this.label_budget.Text = "Budget €";
            // 
            // erreuradresse
            // 
            this.erreuradresse.AutoSize = true;
            this.erreuradresse.ForeColor = System.Drawing.Color.Red;
            this.erreuradresse.Location = new System.Drawing.Point(230, 207);
            this.erreuradresse.Name = "erreuradresse";
            this.erreuradresse.Size = new System.Drawing.Size(192, 20);
            this.erreuradresse.TabIndex = 23;
            this.erreuradresse.Text = "Saisissez une adresse valide";
            // 
            // erreurstandard
            // 
            this.erreurstandard.AutoSize = true;
            this.erreurstandard.ForeColor = System.Drawing.Color.Red;
            this.erreurstandard.Location = new System.Drawing.Point(230, 47);
            this.erreurstandard.Name = "erreurstandard";
            this.erreurstandard.Size = new System.Drawing.Size(156, 20);
            this.erreurstandard.TabIndex = 24;
            this.erreurstandard.Text = "Choisissez un bouquet";
            // 
            // erreurperso
            // 
            this.erreurperso.AutoSize = true;
            this.erreurperso.ForeColor = System.Drawing.Color.Red;
            this.erreurperso.Location = new System.Drawing.Point(669, 47);
            this.erreurperso.Name = "erreurperso";
            this.erreurperso.Size = new System.Drawing.Size(142, 20);
            this.erreurperso.TabIndex = 25;
            this.erreurperso.Text = "Aucune fleur choisie";
            // 
            // Bon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 615);
            this.Controls.Add(this.erreurperso);
            this.Controls.Add(this.erreurstandard);
            this.Controls.Add(this.erreuradresse);
            this.Controls.Add(this.label_budget);
            this.Controls.Add(this.box_budget);
            this.Controls.Add(this.validation);
            this.Controls.Add(this.label_prix);
            this.Controls.Add(this.box_nom);
            this.Controls.Add(this.Avertissement);
            this.Controls.Add(this.label_composition);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_zip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_adresse);
            this.Controls.Add(this.choix_fleurs);
            this.Controls.Add(this.box_catégorie);
            this.Controls.Add(this.Boutonpersonnalisee);
            this.Controls.Add(this.boutonstandard);
            this.Controls.Add(this.label1);
            this.Name = "Bon";
            this.Text = "Bon";
            ((System.ComponentModel.ISupportInitialize)(this.box_budget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton boutonstandard;
        private System.Windows.Forms.RadioButton Boutonpersonnalisee;
        private System.Windows.Forms.ComboBox box_catégorie;
        private System.Windows.Forms.CheckedListBox choix_fleurs;
        private System.Windows.Forms.TextBox box_adresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_zip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox box_message;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_composition;
        private System.Windows.Forms.Label Avertissement;
        private System.Windows.Forms.ComboBox box_nom;
        private System.Windows.Forms.Label label_prix;
        private System.Windows.Forms.Button validation;
        private System.Windows.Forms.NumericUpDown box_budget;
        private System.Windows.Forms.Label label_budget;
        private System.Windows.Forms.Label erreuradresse;
        private System.Windows.Forms.Label erreurstandard;
        private System.Windows.Forms.Label erreurperso;
    }
}