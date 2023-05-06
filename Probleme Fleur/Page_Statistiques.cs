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
using System.Xml;
using System.Xml.XPath;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.IO;
namespace Probleme_Fleur
{
    public partial class Page_Statistiques : Form
    {
        private DateTime debut = new DateTime(DateTime.Now.Year, DateTime.Now.Month,DateTime.Now.Day) ;
        private DateTime fin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        private string stat;
        public Page_Statistiques()
        {
            InitializeComponent();
            monthCalendar1.MaxSelectionCount = int.MaxValue;
            label1.Visible = false;
            comboBox1.Items.Add("Prix moyen du bouquet acheté");
            comboBox1.Items.Add("Client du mois");
            comboBox1.Items.Add("Client de l'année");
            comboBox1.Items.Add("Bouquet standard le plus vendu");
            comboBox1.Items.Add("Fleur la moins vendue");
        }

        private void Page_Statistiques_Load(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = comboBox1.SelectedItem + " : ";
            debut = monthCalendar1.SelectionStart;
            fin = monthCalendar1.SelectionEnd;

            if (comboBox1.SelectedItem == "Prix moyen du bouquet acheté")
            {
                label1.Text += Convert.ToString(Prixmoyen());
            }
            else if (comboBox1.SelectedItem == "Bouquet standard le plus vendu")
            {
                string bestbouquet = "";
                foreach (string nom in BestBouquet())
                {
                    bestbouquet += nom + " ";
                }
                label1.Text = bestbouquet[0..^1];

            }
            else if (comboBox1.SelectedItem == "Fleur la moins vendue")
            {
                string worstfleur = "";
                foreach (string nom in WorstFleur())
                {
                    worstfleur += nom + " ";
                }
                label1.Text = worstfleur[0..^1];
            }
            else if (comboBox1.SelectedItem == "Client du mois")
            {
                string bestclient = "";
                foreach (string nom in ClientduMois())
                {
                    bestclient += nom + " ";
                }
                label1.Text = bestclient[0..^1];

            }
            else if (comboBox1.SelectedItem == "Client de l'année")
            {
                string bestclient = "";
                foreach (string nom in Clientdelannee())
                {
                    bestclient += nom + " ";
                }
                label1.Text = bestclient[0..^1];

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem + " : ";
            if(comboBox1.SelectedItem == "Prix moyen du bouquet acheté")
            {
                label1.Text += Convert.ToString(Prixmoyen());
            }
            else if (comboBox1.SelectedItem == "Client du mois")
            {
                string bestclient = "";
                foreach (string nom in ClientduMois())
                {
                    bestclient += nom + " ";
                }
                label1.Text = bestclient[0..^1];

            }
            else if (comboBox1.SelectedItem == "Client de l'année")
            {
                string bestclient = "";
                foreach (string nom in Clientdelannee())
                {
                    bestclient += nom + " ";
                }
                label1.Text = bestclient[0..^1];

            }
            else if (comboBox1.SelectedItem == "Bouquet standard le plus vendu")
            {
                string bestbouquet = "";
                foreach (string nom in BestBouquet())
                {
                    bestbouquet += nom + " ";
                }
                label1.Text = bestbouquet[0..^1];

            }
            else if (comboBox1.SelectedItem == "Fleur la moins vendue")
            {
                string worstfleur = "";
                foreach (string nom in WorstFleur())
                {
                    worstfleur += nom + " ";
                }
                label1.Text = worstfleur[0..^1];
            }
            label1.Visible = true;
        }
        private double Prixmoyen()
        {

            string[] allprix = Commande("select montant, date_commande from commande;").Split(';');
            List<double> pricesInRange = new List<double>();

            for (int i = 1; i < allprix.Length; i += 2)
            {
                DateTime date = DateTime.ParseExact(allprix[i], "dd/MM/yyyy", null);
                if (date >= debut && date <= fin)
                {
                    pricesInRange.Add(Convert.ToDouble(allprix[i - 1]));
                }
            }
            double moyenne;
            if (pricesInRange.Count > 0)
            {
                moyenne = pricesInRange.Average();

            }
            else moyenne = 0;
            
            return Math.Round(moyenne, 2);
        }
        private string[] ClientduMois()
        {
            int mois = DateTime.Now.Month;
            return  Commande("SELECT concat(nom,' ',prenom) FROM client c JOIN commande cmd ON c.no_client = cmd.no_client " +
                $"WHERE MONTH(STR_TO_DATE(cmd.date_commande, '%d/%m/%Y')) = {mois} " +
                "GROUP BY c.no_client HAVING COUNT(*) = ( SELECT MAX(count_commandes) " +
                $"FROM( SELECT COUNT(*) as count_commandes FROM commande WHERE MONTH(STR_TO_DATE(date_commande, '%d/%m/%Y')) = {mois} " +
                "GROUP BY no_client) AS counts) ").Split(',');         
        }
        private string[] Clientdelannee()
        {
            int annee = DateTime.Now.Year;
            return Commande("SELECT concat(nom,' ',prenom) FROM client c JOIN commande cmd ON c.no_client = cmd.no_client " +
                $"WHERE YEAR(STR_TO_DATE(cmd.date_commande, '%d/%m/%Y')) = {annee} " +
                "GROUP BY c.no_client HAVING COUNT(*) = ( SELECT MAX(count_commandes) " +
                $"FROM( SELECT COUNT(*) as count_commandes FROM commande WHERE YEAR(STR_TO_DATE(date_commande, '%d/%m/%Y')) = {annee} " +
                "GROUP BY no_client) AS counts) ").Split(',');
        }

        private string[] BestBouquet()
        {
            return Commande($"SELECT nom_bouquet FROM bouquet WHERE nom_bouquet IS NOT NULL GROUP BY nom_bouquet HAVING COUNT(DISTINCT no_commande) = (SELECT MAX(count) FROM (SELECT COUNT(DISTINCT b.no_commande) AS count FROM bouquet b JOIN commande c ON b.no_commande = c.no_commande WHERE STR_TO_DATE(c.date_commande, '%d/%m/%Y') >= STR_TO_DATE('{debut}', '%d/%m/%Y') AND STR_TO_DATE(c.date_commande, '%d/%m/%Y') <= STR_TO_DATE('{fin}', '%d/%m/%Y') AND nom_bouquet IS NOT NULL GROUP BY nom_bouquet) AS counts);").Split(';');
        }
        private string[] WorstFleur()
        {
            return Commande($"SELECT f.sorte, COUNT(b.no_commande) as nb_apparitions FROM fleur f " +
                $"LEFT JOIN bouquet b ON f.sorte = b.sorte AND b.no_commande IS NOT NULL " +
                $"GROUP BY f.sorte HAVING COUNT(b.no_commande) = (SELECT MIN(counts.nb_apparitions) FROM " +
                $"(SELECT COUNT(b2.no_commande) as nb_apparitions FROM fleur f2 " +
                $"LEFT JOIN bouquet b2 ON f2.sorte = b2.sorte AND b2.no_commande IS NOT NULL " +
                $"GROUP BY f2.sorte) as counts)").Split();
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
            if (retour.Length == 0)
            {
                retour += "xx";
            }
            return retour[0..^1];
        }
        static void exportXML()
        {
            XmlDocument doc = new XmlDocument();

            // Création de l'élément racine
            XmlElement clients = doc.CreateElement("Clients");
            doc.AppendChild(clients);

            // Requête SQL pour récupérer les clients ayant commandé plusieurs fois durant le dernier mois
            DateTime dateDebut = DateTime.Now;///.AddMonths(-1);
            string requete = $"SELECT c.* FROM commande cm JOIN client c ON c.no_client = cm.no_client WHERE Month(STR_TO_DATE(cm.date_commande, '%d/%m/%Y')) = Month(STR_TO_DATE('{dateDebut}', '%d/%m/%Y')) GROUP BY c.no_client HAVING COUNT(*) > 1;";

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

                // Pour chaque client retourné par la requête, on crée un élément "Client" dans le document XML
                
                 XmlElement client = doc.CreateElement("Client");
                 clients.AppendChild(client);

                 XmlElement no_client = doc.CreateElement("NoClient");
                 no_client.InnerText = reader["no_client"].ToString();
                 client.AppendChild(no_client);

                 XmlElement nom = doc.CreateElement("Nom");
                 nom.InnerText = reader["nom"].ToString();
                 client.AppendChild(nom);

                 XmlElement prenom = doc.CreateElement("Prenom");
                 prenom.InnerText = reader["prenom"].ToString();
                 client.AppendChild(prenom);

                 XmlElement couriel = doc.CreateElement("Couriel");
                 couriel.InnerText = reader["couriel"].ToString();
                 client.AppendChild(couriel);

                XmlElement statut = doc.CreateElement("statut");
                couriel.InnerText = reader["statut"].ToString();
                client.AppendChild(statut);

            }
            connection.Close();

            // Enregistrement du document XML
            doc.Save("clients_commandes_recentes.xml");
            MessageBox.Show("Export effectué");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportXML();
            
        }
        static void exportJSON()
        {

            string chemin = "client_afk.json";


            string requete = "SELECT * FROM client WHERE no_client NOT IN (SELECT DISTINCT no_client FROM commande WHERE DATE_ADD(STR_TO_DATE(date_commande, '%d/%m/%Y'), INTERVAL 6 MONTH) >= NOW())";

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=fleurs;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = requete;

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            /* exemple de manipulation du resultat */
            while (reader.Read())
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader.GetName(i), reader.GetValue(i));
                }
                rows.Add(row);
            }
            connection.Close();
            //instanciation des "writer"
            // -----------
            /// à compléter
            StreamWriter writer = new StreamWriter(chemin);
            JsonTextWriter jwriter = new JsonTextWriter(writer);
            
            //debut du fichier Json
            jwriter.WriteStartObject();
            jwriter.WritePropertyName("Clients");

            //ecriture du tableau Json
            // -----------
            // Ã  complÃ©ter
            // -----------
            jwriter.WriteStartArray();
            foreach (Dictionary<string, object> row in rows)
            {
                jwriter.WriteStartObject();
                foreach (KeyValuePair<string, object> kvp in row)
                {
                    jwriter.WritePropertyName(kvp.Key);
                    jwriter.WriteValue(kvp.Value.ToString());
                }
                jwriter.WriteEndObject();
            }
            jwriter.WriteEndArray();

            //fin du fichier Json
            jwriter.WriteEndObject();

            //fermeture des "writer"
            jwriter.Close();
            writer.Close();

            MessageBox.Show("Export effectué");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exportJSON();
        }
    }
}
