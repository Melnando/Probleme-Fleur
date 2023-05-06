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
using System.Text.RegularExpressions;


namespace Probleme_Fleur
{
    public partial class Page_inscription : Form
    {
        char[] forbiddenChars = { '\'', '\\', '/', '*', '+', '=', ';', ',', '.', '<', '>', '!', '?', '%', '#', '@', '&', '(', ')', '[', ']', '{', '}', '|', '$' };
        public Page_inscription()
        {
            InitializeComponent();
            Inscription.Visible = false;
            if (erreurnom.Visible == false &&
            erreurprenom.Visible == false &&
            erreurtel.Visible == false &&
            erreurmail.Visible == false &&
            erreurmdp.Visible == false &&
            erreurCB.Visible == false)
            {
                Inscription.Visible = true;


            }

        }

        private void Inscription_Click(object sender, EventArgs e)
        {
          
            string nom = Convert.ToString(box_nom.Text);

            string prenom = Convert.ToString(box_prenom.Text);

            string tel = Convert.ToString(box_tel.Text);

            string mdp = Convert.ToString(box_mdp.Text);

            string adresse = Convert.ToString(box_adresse.Text);

            string CB = Convert.ToString(box_CB.Text);

            string mail = Convert.ToString(box_mail.Text);

            string verif = Commande($"SELECT COUNT(*) FROM client WHERE couriel = '{mail}'");

            if (Convert.ToInt32(verif.Split(';')[0]) == 0)
            {
                Inscription_BDD(nom, prenom, tel, mdp, adresse, CB, mail);
                this.Close();
            }
            else
            {
                erreurmail.Text = "couriel déjà utilisé";
                erreurmail.Visible = true;
            }


        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

            string nom = box_nom.Text;
            if (nom == "" || nom.Any(char.IsDigit) || forbiddenChars.Any(c => nom.Contains(c)))
            {
                erreurnom.Visible = true;
            }
            else erreurnom.Visible = false;
        }

        static void Inscription_BDD(string nom, string prenom, string tel, string mdp, string adresse, string CB, string mail)
        {
            string no_client = CreationCodeClient();
            string requete = $"insert into fleurs.client (no_client, couriel, nom, prenom, no_telephone,mdp,adresse,statut,cb) " +
                $"values('{no_client}', '{mail}', '{nom}', '{prenom}', '{tel}','{mdp}','{adresse}',null,'{CB}')";
            Commande(requete);
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
        static string CreationCodeClient()
        {
            string[] nbclient = Commande("select count(*) from client").Split(';');
            string noclient = "C" + Convert.ToString(Convert.ToInt32(nbclient[0])+1);
            return noclient;
        }
        private void box_prenom_TextChanged(object sender, EventArgs e)
        {
            string prenom = box_prenom.Text;
            if (prenom == "" || prenom.Any(char.IsDigit) || forbiddenChars.Any(c => prenom.Contains(c)))
            {
                erreurprenom.Visible = true;
            }
            else erreurprenom.Visible = false;
        }

        private void box_tel_TextChanged(object sender, EventArgs e)
        {
            string tel = box_tel.Text;
            if (tel.Length != 10 || !Regex.IsMatch(tel, "^[0-9]+$"))
            {
                erreurtel.Visible = true;
            }
            else erreurtel.Visible = false;
        }

        private void box_mail_TextChanged(object sender, EventArgs e)
        {
            erreurmail.Text = "format incorrect";
            string mail = box_mail.Text;
            if (!Regex.IsMatch(mail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                erreurmail.Visible = true;
            }
            else erreurmail.Visible = false;
        }

        private void box_mdp_TextChanged(object sender, EventArgs e)
        {
            string mdp = box_mdp.Text;
            if (mdp.Length < 7)
            {
                erreurmdp.Visible = true;
            }
            else erreurmdp.Visible = false;
        }

        private void box_CB_TextChanged(object sender, EventArgs e)
        {
            string cb = box_CB.Text;
            if (cb.Length != 16 || !Regex.IsMatch(cb, "^[0-9]+$"))
            {
                erreurCB.Visible = true;
            }
            else erreurCB.Visible = false;
        }
    }
}
