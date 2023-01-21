using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST123123
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string connStr = "Datasource =94.130.133.100;username=LF8Projekt;password=BDbD)dw!Dvv!7q6k;database=LF8Projekt";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                string BEN = textBox1.Text;
                BEN = '"' + BEN + '"';
                string PAS = textBox2.Text;
                conn.Open();
                string sql = "Select * from `benutzerdaten` Where Admin = '1' and `Benutzername` = " + BEN + " and `Passwort` = " + PAS + "";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                }
                int ID = Convert.ToInt32(rdr[0]);
                Console.WriteLine(ID);
                rdr.Close();

                if (ID >= 0)
                {

                    LS_Admin_Panel test = new LS_Admin_Panel();
                    test.Show();
                    this.Hide();
                }

                else
                {

                    Console.WriteLine();
                }



                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Benutzerdaten Falsch");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
