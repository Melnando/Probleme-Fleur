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
    public partial class Page_designer : Form
    {
        public Page_designer()
        {
            InitializeComponent();
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=fleurs;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Définir la requête SQL pour sélectionner toutes les colonnes de la table commande
            string requete = "select no_bouquet, date_livraison, nom_bouquet, sorte, nb_fleurs from bouquet b join commande c on c.no_commande = b.no_commande;";

            // Créer un objet MySqlDataAdapter avec la requête et la connexion
            MySqlDataAdapter adapter = new MySqlDataAdapter(requete, connection);

            // Créer un DataSet pour stocker les données
            DataSet dataset = new DataSet();

            // Remplir le DataSet avec les données de la table commande
            adapter.Fill(dataset, "commande");

            // Configurer le DataGridView pour afficher les données du DataSet
            dataGridView1.DataSource = dataset.Tables["commande"];



            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;

        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            // Récupération des données de la cellule éditée
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string no_bouquet = (string)row.Cells["no_bouquet"].Value;
            int nb_fleurs = (int)row.Cells["nb_fleurs"].Value;
            string sorte = (string)row.Cells["sorte"].Value;
            
                ///vérification du stock

                int stock = Convert.ToInt32(Commande($"select sum(quantite) from stock where sorte = '{sorte}';").Split(';')[0]);
                if (nb_fleurs > stock)
                {
                    MessageBox.Show("Stock insuffisant pour " + sorte);
                    dataGridView1.CancelEdit();
                }
                else
                {
                    // Mise à jour de la base de données
                    string connectionString = "SERVER=localhost;PORT=3306;DATABASE=fleurs;UID=root;PASSWORD=root;";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("UPDATE bouquet SET nb_fleurs=@nb_fleurs WHERE no_bouquet=@no_bouquet", connection);
                    command.Parameters.AddWithValue("@no_bouquet", no_bouquet);
                    command.Parameters.AddWithValue("@nb_fleurs", nb_fleurs);

                    MySqlCommand command2 = new MySqlCommand("UPDATE stock SET quantite=@quantite WHERE sorte=@sorte", connection);
                    command2.Parameters.AddWithValue("@quantite", Convert.ToString(stock - nb_fleurs));
                    command2.Parameters.AddWithValue("@sorte", sorte);


                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    connection.Close();
                }
               
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void bouquets_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=fleurs;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Définir la requête SQL pour sélectionner toutes les colonnes de la table commande
            string requete = "select no_bouquet, date_livraison, nom_bouquet, sorte, nb_fleurs from bouquet b join commande c on c.no_commande = b.no_commande;";

            // Créer un objet MySqlDataAdapter avec la requête et la connexion
            MySqlDataAdapter adapter = new MySqlDataAdapter(requete, connection);

            // Créer un DataSet pour stocker les données
            DataSet dataset = new DataSet();

            // Remplir le DataSet avec les données de la table commande
            adapter.Fill(dataset, "commande");

            // Configurer le DataGridView pour afficher les données du DataSet
            dataGridView1.DataSource = dataset.Tables["commande"];



            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
        }

        private void stocks_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=fleurs;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Définir la requête SQL pour sélectionner toutes les colonnes de la table commande
            string requete = "select sorte, lieu, code_stock, quantite from stock s;";

            // Créer un objet MySqlDataAdapter avec la requête et la connexion
            MySqlDataAdapter adapter = new MySqlDataAdapter(requete, connection);

            // Créer un DataSet pour stocker les données
            DataSet dataset = new DataSet();

            // Remplir le DataSet avec les données de la table commande
            adapter.Fill(dataset, "stock");

            // Configurer le DataGridView pour afficher les données du DataSet
            dataGridView1.DataSource = dataset.Tables["stock"];



            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Vérifie si la colonne est "Montant" et si la valeur est inférieure à 100
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "quantite" && Convert.ToInt32(e.Value) < 10 && e.Value != null)
            {
                // Change la couleur de fond de la ligne en rouge
                e.CellStyle.BackColor = Color.Red;
            }
        }
    }
}
