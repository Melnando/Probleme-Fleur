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
    public partial class Page_clients : Form
    {
        public Page_clients()
        {
            InitializeComponent();
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=fleurs;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Définir la requête SQL pour sélectionner toutes les colonnes de la table commande
            string requete = "select nom, prenom, statut, couriel from client;";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
