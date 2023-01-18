using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient; //Wird benötigt für die Verbindung mit MySql
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TEST123123
{
    public partial class LS_Admin_Panel : Form
    {
        //Hier geben wir die Connection zur Datenbank an mit IP Username dem Passwort und welche Datenbank
        MySqlConnection cn = new MySqlConnection("Datasource =94.130.133.100;username=LF8Projekt;password=BDbD)dw!Dvv!7q6k;database=LF8Projekt");
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader reader;
        DataTable dt;
        public LS_Admin_Panel()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Hier wird direkt nachdem Start einmal die Datenbank geladen/geupdatet (Oben)
            try
            {
                cn.Open();
                command = new MySqlCommand("Select * from benutzerdaten", cn);
                command.ExecuteNonQuery();
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SpeBtn_Click(object sender, EventArgs e)
        {
            //hier wird für jedes Fahrzeig ein String angelegt,
            int W24 ;
            int W25 ;


            //Um diese hier zu Checken ob die Abgehackt sind.

            if (checkBox24.Checked)
            {
                W24 = 1;
            }
            else
            {
                W24 = 0 ;
                    
             }

            if (checkBox25.Checked)
            {
                W25 = 1;
            }
            else
            {
                W25 = 0 ;

            }
            //Hier werden alle Strings in einen String gepackt damit wir mehrere Wagen gleichzeitig Alamieren können
            if (txtPass.Text == "" || txtBenutzername.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Text Felder aus!");
            }
            else
            {
                try
                {
                    cn.Close();
                    cn.Open();
                    //Hiermit können wir Daten aus den Textboxen einfügen
                    command = new MySqlCommand("Insert into benutzerdaten(Passwort,Benutzername,LS,Admin) VALUES('" + txtPass.Text + "','" + txtBenutzername.Text + "','" + W24 + "','" + W25 + "')", cn);
                    command.ExecuteNonQuery();
                    cn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Hier werden Automatisch nachdem einfügen die Text Felder geleert
                txtusrid.Clear();
                txtBenutzername.Clear();
                txtPass.Clear();
                checkBox24.Checked = false;
                checkBox25.Checked = false;
                //Hier wird direkt nachdem Einfügen einmal die Datenbank geladen/geupdatet (Oben)
                try
                {
                    cn.Open();
                    command = new MySqlCommand("Select * from benutzerdaten'", cn);
                    command.ExecuteNonQuery();
                    dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }

        //Hiermit können wir die Einsätze als Erledigt kennzeichen.
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusrid.Text == "")
            {
                MessageBox.Show("Bitte User ID eintragen!");
            }
            else {
                cn.Close();
                string Probe = (txtusrid.Text);
                string SQL = ("DELETE FROM `benutzerdaten` WHERE `ID` = '" + Probe + "'");

            


                cn.Open();
                command = new MySqlCommand(SQL, cn);
                command.ExecuteNonQuery();
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                cn.Close();
                txtusrid.Clear();
                //Hier wird nachdem man den Einsatz Beendet hat einmal die Datenbank geladen/geupdatet (Oben)
                try
                {
                    cn.Open();
                    command = new MySqlCommand("Select * from benutzerdaten", cn);
                    command.ExecuteNonQuery();
                    dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } 

    }
}
