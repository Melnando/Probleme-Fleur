﻿
namespace Probleme_Fleur
{
    partial class Etat_commandes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etatcmd = new System.Windows.Forms.Button();
            this.livraison = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // etatcmd
            // 
            this.etatcmd.Location = new System.Drawing.Point(12, 461);
            this.etatcmd.Name = "etatcmd";
            this.etatcmd.Size = new System.Drawing.Size(218, 29);
            this.etatcmd.TabIndex = 1;
            this.etatcmd.Text = "Etat des commandes";
            this.etatcmd.UseVisualStyleBackColor = true;
            this.etatcmd.Click += new System.EventHandler(this.etatcmd_Click);
            // 
            // livraison
            // 
            this.livraison.Location = new System.Drawing.Point(565, 461);
            this.livraison.Name = "livraison";
            this.livraison.Size = new System.Drawing.Size(223, 29);
            this.livraison.TabIndex = 2;
            this.livraison.Text = "commandes à fusionner";
            this.livraison.UseVisualStyleBackColor = true;
            this.livraison.Click += new System.EventHandler(this.livraison_Click);
            // 
            // Etat_commandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.livraison);
            this.Controls.Add(this.etatcmd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Etat_commandes";
            this.Text = "Etat_commandes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button etatcmd;
        private System.Windows.Forms.Button livraison;
    }
}