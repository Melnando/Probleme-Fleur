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
            ///mise en page initiale

            box_mail.Visible = false;
            box_mdp.Visible = false;
            couriel.Visible = false;
            mdp.Visible = false;
            validateur.Visible = false;
            erreurmail.Visible = false;
            erreurmdp.Visible = false;
            mdp_admin.Visible = false;
            statistiques.Visible = false;
            etat_cmd.Visible = false;
            box_lieu.Visible = true;
            designer.Visible = false;
            pageclient.Visible = false;

            box_lieu.Items.Add("M1");
            box_lieu.Items.Add("M2");
            box_lieu.Items.Add("M3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mdp_admin.Visible = false;
            Page_inscription formulaire = new Page_inscription();
            formulaire.Show();


            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            designer.Visible = false;
            statistiques.Visible = false;
            etat_cmd.Visible = false;
            mdp_admin.Visible = false;
            box_mail.Visible = true;
            box_mdp.Visible = true;
            couriel.Visible = true;
            mdp.Visible = true;
            validateur.Visible = true;
            pageclient.Visible = false;
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string ID_mail { get; set; }
        public string Magasin { get; set; }
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
                    string magasin = Lieu.Text;
                    formulaire.Magasin = Lieu.Text;
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
            ///mise en page client
            statistiques.Visible = false;
            etat_cmd.Visible = false;
            mdp_admin.Visible = false;
            erreurmail.Visible = false;
            designer.Visible = false;
            pageclient.Visible = false;
        }

        private void box_mdp_TextChanged(object sender, EventArgs e)
        {
            /// mise en page client
            statistiques.Visible = false;
            etat_cmd.Visible = false;
            mdp_admin.Visible = false;
            erreurmdp.Visible = false;
            designer.Visible = false;
            pageclient.Visible = false;
        }

        private void Admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /// pour entrer en session admin
            mdp_admin.Visible = true;

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && mdp_admin.Text == "admin") /// en entrant le mdp admin et en pressant entrer on accède aux fonctionnalités admin
            {
                statistiques.Visible = true;
                etat_cmd.Visible = true;
                designer.Visible = true;
                pageclient.Visible = true;
            }
        }

        private void statistiques_Click(object sender, EventArgs e)
        {
            Page_Statistiques stats = new Page_Statistiques(); ///accès à la page statisiques
            stats.Show();
        }

        private void etat_cmd_Click(object sender, EventArgs e)
        {
            Etat_commandes etat_Commandes = new Etat_commandes(); ///accès à la pag état des commandes
            etat_Commandes.Show();
        }

        private void box_lieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lieu.Text = box_lieu.SelectedItem.ToString(); /// possibilité de changer le magasin ou est effectué la commande
        }

        private void designer_Click(object sender, EventArgs e)
        {
            Page_designer design = new Page_designer(); /// accès à la page designer
            design.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Page_designer client = new Page_designer(); /// accès à la page client
            client.Show();
        }
    }
}
