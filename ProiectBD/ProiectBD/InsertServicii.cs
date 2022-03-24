using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBD
{
    public partial class InsertServicii : Form
    {
        string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
        public InsertServicii()
        {
            InitializeComponent();
        }

        private void extButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void sbmButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("insert into Servicii values(@NumeServiciu, @BugetAlocat, @PretServiciu)", sqlCon);
            cmd.Parameters.AddWithValue("@NumeServiciu", nume_serviciu_box.Text);
            cmd.Parameters.AddWithValue("@BugetAlocat", decimal.Parse(buget_alocat_box.Text));
            cmd.Parameters.AddWithValue("@PretServiciu", decimal.Parse(pret_serviciu_box.Text));
            cmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show("Date introduse cu succes!");
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
