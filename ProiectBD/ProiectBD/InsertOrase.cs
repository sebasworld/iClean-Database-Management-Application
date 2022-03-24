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
    public partial class InsertOrase : Form
    {
        string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
        public InsertOrase()
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

        private void nume_serviciu_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void sbmButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("insert into Orase values(@NumeOras, @JudetOras)", sqlCon);
            cmd.Parameters.AddWithValue("@NumeOras", nume_oras_box.Text);
            cmd.Parameters.AddWithValue("@JudetOras", judet_box.Text);
            cmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show("Date introduse cu succes!");
        }

        private void judet_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insrtTextbox_Click(object sender, EventArgs e)
        {

        }
    }
}
