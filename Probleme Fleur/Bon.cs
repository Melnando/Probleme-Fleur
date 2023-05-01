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
            label_prix.Visible = false;
            Avertissement.Visible = false;
            box_budget.Visible = false;
            label_budget.Visible = false;
            categories_dispo();
            dateTimePicker1.MinDate = DateTime.Today.AddDays(1);



            if (box_adresse.Text != "" && box_zip.Text != "" && textBox1.Text == "")
            {
                erreuradresse.Visible = false;
            }




        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            choix_fleurs.Visible = false;
            box_budget.Visible = false;
            label_budget.Visible = false;
            box_catégorie.Visible = true;
            erreurstandard.Visible = true;
            erreurperso.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void fleurs_dispo()
        {
            string[] sortes_dispo = Commande("select sorte from stock").Split(';'); /// where quantite > 0
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
            box_budget.Visible = true;
            label_budget.Visible = true;
            erreurstandard.Visible = false;
            erreurperso.Visible = true;


        }
        public void categories_dispo()
        {
            string[] categoriesreq = Commande("select distinct categorie from bouquet").Split(';'); /// inner join stock on bouquet.sorte = stock.sorte where stock.quantite > 0 pas utile -> vérification par les employés
            foreach (string categorie in categoriesreq)
            {
                if (categorie != "")
                {
                    box_catégorie.Items.Add(categorie);
                }
                
            }
        }

        private void box_catégorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            erreurstandard.Visible = true;
            box_nom.SelectedIndex = -1;
            label_composition.Visible = false;
            label_prix.Visible = false;

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
                erreurstandard.Visible = false;
                string prix = Commande($"select distinct prix from bouquet where nom_bouquet = '{bouquetselec}';")[0..^1];
                label_prix.Text = "Montant de la commande : "+prix+" €";
                label_prix.Visible = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Avertissement.Visible = true;
            DateTime dateChoisie = dateTimePicker1.Value;
            if (dateChoisie <= DateTime.Today.AddDays(3) && dateChoisie >= DateTime.Today.AddDays(1))
            {
                Avertissement.Text = "Pour les commandes effectuées moins de 3 jours avant la date de livraison"+'\n'+"le client assume le risque de pénuerie";
                
            }
            else
            {
                Avertissement.Visible = false;
            }
        }

        private void box_zip_TextChanged(object sender, EventArgs e)
        {
            if (box_adresse.Text != "" && box_zip.Text != "" && textBox1.Text != "" && box_zip.Text.Length ==5)
            {
                erreuradresse.Visible = false;
            }
            else
            {
                erreuradresse.Visible = true;
            }
        }
        private void box_zip_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie si le caractère saisi est un chiffre et si le texte ne dépasse pas 5 caractères
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Empêche la saisie du caractère en cours
                e.Handled = true;
            }
        }
        public string ID_mail { get; set; }
        private void validation_Click(object sender, EventArgs e)
        {
            if(erreuradresse.Visible == true)
            {
                MessageBox.Show(erreuradresse.Text);
            }
            if(erreurperso.Visible == true)
            {
                MessageBox.Show(erreurperso.Text);
            }
            if(erreurstandard.Visible == true)
            {
                MessageBox.Show(erreurstandard.Text);
            }
            if (erreuradresse.Visible == false && erreurperso.Visible == false && erreurstandard.Visible == false)
            {
                MessageBox.Show("Commande validée");

                ///enregistrement du bon de commande
                
                string adresse_livraison = box_adresse.Text + " " + box_zip.Text + " " + textBox1.Text;
                string message = null;
                if (box_message.Text != "")
                {
                    message = box_message.Text;
                }
                string date_livraison = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                string date_commande = DateTime.Today.ToString("dd/MM/yyyy");
                string etat = "VINV";
                string mail = ID_mail;
                string no_client = Commande($"select no_client from client where couriel = '{mail}'")[0..^1];
                string nb_commande = Convert.ToInt32(Commande($"select count(*) from commande").Split(';')[0]).ToString("D6");
                string no_commande = "BO" + nb_commande;
                Commande("insert into commande (montant, no_commande ,adresse_livraison ,message ,date_livraison,date_commande,etat,no_client) " +
                    $"values (null,'{no_commande}','{adresse_livraison}' ,'{message}' ,'{date_livraison}','{date_commande}','{etat}','{no_client}')");

                ///commande standard

                if (boutonstandard.Checked == true)
                {
                    
                    /// Création du bouquet pour le designer
                    string bouquetselec = box_nom.SelectedItem.ToString();
                    string[] compo = Commande($"select distinct(sorte) from bouquet where nom_bouquet = '{bouquetselec}';").Split(';');
                    string categorie = Commande($"select distinct categorie from bouquet where nom_bouquet = '{bouquetselec}';")[0..^1];
                    string prix = Commande($"select distinct prix from bouquet where nom_bouquet = '{bouquetselec}';")[0..^1];
                    string no_bouquet = no_commande;
                    int i = 0;
                    foreach(string sorte in compo)
                    {
                        
                        if(sorte != "")
                        {
                            no_bouquet += i.ToString("00");
                            Commande($"INSERT INTO bouquet(no_bouquet,no_commande,nom_bouquet,categorie,prix,nb_fleurs,sorte) VALUES('{no_bouquet}', '{no_commande}', '{bouquetselec}', '{categorie}', {prix}, null, '{sorte}');");
                            i++;
                        }
                    }
                }
                ///Commande personnalisée
                else
                {
                    /// Création du bouquet pour le designer
                    string bouquetselec = null;
                    string[] compo = choix_fleurs.CheckedItems.Cast<string>().ToArray();
                    string categorie = "personalisée";
                    string prix = box_budget.Value.ToString();
                    string no_bouquet = no_commande;
                    int i = 0;
                    foreach (string sorte in compo)
                    {

                        if (sorte != "")
                        {
                            no_bouquet += i.ToString("00");
                            Commande($"INSERT INTO bouquet(no_bouquet,no_commande,nom_bouquet,categorie,prix,nb_fleurs,sorte) VALUES('{no_bouquet}', '{no_commande}', '{bouquetselec}', '{categorie}', {prix}, null, '{sorte}');");
                            i++;
                        }
                    }
                }

                /* éventuellement
                foreach (Form form in Application.OpenForms)
                {
                    form.Close();
                }
                */




            }
        }

        private void choix_fleurs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (choix_fleurs.CheckedItems.Count == 0)
            {
                erreurperso.Visible = true;
            }
            else
            {
                erreurperso.Visible = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (box_adresse.Text != "" && box_zip.Text != "" && textBox1.Text != "")
            {
                erreuradresse.Visible = false;
            }
            else
            {
                erreuradresse.Visible = true;
            }
        }

        private void box_adresse_TextChanged(object sender, EventArgs e)
        {
            if (box_adresse.Text != "" && box_zip.Text != "" && textBox1.Text != "")
            {
                erreuradresse.Visible = false;
            }
            else
            {
                erreuradresse.Visible = true;
            }

        }
    }
}
