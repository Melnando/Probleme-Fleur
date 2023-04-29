using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Probleme_Fleur
{
    public partial class Bon : Form
    {
        public Bon()
        {
            InitializeComponent();
            fleurs_dispo();
            choix_fleurs.Visible = false;
            box_catégorie.Visible = false;
            box_nom.Visible = false;
            label_composition.Visible = false;
            label_composition.Visible = false;
            categories_dispo();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choix_fleurs.Visible = false;
            box_catégorie.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        public void fleurs_dispo()
        {
            string[] sortes_dispo = Commande("select sorte from stock where quantite > 0").Split(';');
            foreach (string sorte in sortes_dispo)
            {
                if (sorte != "")
                {
                    choix_fleurs.Items.Add(sorte);
                }
                
            }
             
        }
        static string Commande(string requete)
        {
            // Bien vérifier, via Workbench par exemple, que ces paramètres de connexion sont valides !!!
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=fleurs;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();

            command.CommandText = requete; // exemple de requete bien-sur !

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            string retour = "";
            /* exemple de manipulation du resultat */
            while (reader.Read())                           // parcours ligne par ligne
            {
                string currentRowAsString = "";
                for (int i = 0; i < reader.FieldCount; i++)    // parcours cellule par cellule
                {
                    string valueAsString = reader.GetValue(i).ToString();  // recuperation de la valeur de chaque cellule sous forme d'une string (voir cependant les differentes methodes disponibles !!)
                    currentRowAsString += valueAsString + ";";
                }
                retour += currentRowAsString;
                // affichage de la ligne (sous forme d'une "grosse" string) sur la sortie standard
            }


            connection.Close();
            return retour;
        }

        private void Boutonpersonnalisee_CheckedChanged(object sender, EventArgs e)
        {
            choix_fleurs.Visible = true;
            box_catégorie.Visible = false;
            box_nom.Visible = false;
            box_catégorie.SelectedIndex = -1;

        }
        public void categories_dispo()
        {
            string[] categoriesreq = Commande("select distinct categorie from bouquet inner join stock on bouquet.sorte = stock.sorte where stock.quantite > 0").Split(';');
            foreach(string categorie in categoriesreq)
            {
                if (categorie != "")
                {
                    box_catégorie.Items.Add(categorie);
                }
                
            }
        }

        private void box_catégorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            box_nom.SelectedIndex = -1;
            label_composition.Visible = false;

            if (box_catégorie.SelectedIndex != -1)
            {
                box_nom.Items.Clear();
                box_nom.Visible = true;
                string categorieselec = box_catégorie.SelectedItem.ToString();
                string[] noms_bouquets = Commande($"select distinct nom_bouquet from bouquet where categorie = '{categorieselec}';").Split(';');
                foreach(string nom in noms_bouquets)
                {
                    if(nom != "")
                    {
                        box_nom.Items.Add(nom);
                    }
                }
            }
                
        }

        private void box_nom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_nom.SelectedIndex != -1)
            {
                string bouquetselec = box_nom.SelectedItem.ToString();
                string compo = Commande($"select distinct(sorte) from bouquet where nom_bouquet = '{bouquetselec}';")[0..^1].Replace(";", ", ");
                label_composition.Text = "Composition : " + compo;
                label_composition.Visible = true;
            }
        }
    }
}
