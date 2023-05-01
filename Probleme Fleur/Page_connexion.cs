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
    public partial class Page_connexion : Form
    {
        public Page_connexion()
        {
            InitializeComponent();


            box_mail.Visible = false;
            box_mdp.Visible = false;
            couriel.Visible = false;
            mdp.Visible = false;
            validateur.Visible = false;
            erreurmail.Visible = false;
            erreurmdp.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page_inscription formulaire = new Page_inscription();
            formulaire.Show();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            box_mail.Visible = true;
            box_mdp.Visible = true;
            couriel.Visible = true;
            mdp.Visible = true;
            validateur.Visible = true;
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string ID_mail { get; set; }
    private void validateur_Click(object sender, EventArgs e)
        {
            string mail = box_mail.Text;
            string verif = Commande($"SELECT COUNT(*) FROM client WHERE couriel = '{mail}'");
            if (Convert.ToInt32(verif.Split(';')[0]) != 0)
            {
                string requetemdp = Commande($"SELECT mdp FROM client WHERE couriel = '{mail}'").Split(';')[0];
                if (requetemdp == box_mdp.Text)
                {
                    this.Hide();
                    Bon formulaire = new Bon();
                    formulaire.ID_mail = box_mail.Text;
                    formulaire.Show();
                    
                }
                else erreurmdp.Visible = true;
            }
            else erreurmail.Visible = true;
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

        private void box_mail_TextChanged(object sender, EventArgs e)
        {
            erreurmail.Visible = false;
        }

        private void box_mdp_TextChanged(object sender, EventArgs e)
        {
            erreurmdp.Visible = false;
        }
    }
}
