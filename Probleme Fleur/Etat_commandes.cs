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
    public partial class Etat_commandes : Form
    {
        public Etat_commandes()
        {
            InitializeComponent();
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=fleurs;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Définir la requête SQL pour sélectionner toutes les colonnes de la table commande
            string requete = "SELECT c.no_commande, c.date_commande, c.date_livraison, c.montant,GROUP_CONCAT(DISTINCT f.sorte SEPARATOR ', '), c.etat FROM commande c JOIN bouquet cb ON cb.no_commande = c.no_commande JOIN fleur f ON f.sorte = cb.sorte GROUP BY c.no_commande;";

            // Créer un objet MySqlDataAdapter avec la requête et la connexion
            MySqlDataAdapter adapter = new MySqlDataAdapter(requete, connection);

            // Créer un DataSet pour stocker les données
            DataSet dataset = new DataSet();

            // Remplir le DataSet avec les données de la table commande
            adapter.Fill(dataset, "commande");

            // Configurer le DataGridView pour afficher les données du DataSet
            dataGridView1.DataSource = dataset.Tables["commande"];

            string nouveauNom = "fleurs";
            int indexColonne = 4; 

            dataGridView1.Columns[indexColonne].HeaderText = nouveauNom;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;


        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            // Récupération des données de la cellule éditée
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string noCommande = (string)row.Cells["no_commande"].Value;
            string etat = (string)row.Cells["etat"].Value;

            if (etat != "CAV" && etat != "CC" && etat != "CL" && etat != "VINV" && etat != "CPAV")
            {
                MessageBox.Show("erreur de saisie : "+etat);
                dataGridView1.CancelEdit();
                
            }
            else
            {
                // Mise à jour de la base de données
                string connectionString = "SERVER=localhost;PORT=3306;DATABASE=fleurs;UID=root;PASSWORD=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE commande SET etat=@etat WHERE no_commande=@no_commande", connection);
                command.Parameters.AddWithValue("@no_commande", noCommande);
                command.Parameters.AddWithValue("@etat", etat);
                command.ExecuteNonQuery();
                connection.Close();
            }

            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }
    }
}
