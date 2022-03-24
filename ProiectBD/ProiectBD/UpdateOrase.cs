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
    public partial class UpdateOrase : Form
    {
        string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
        public UpdateOrase()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void extButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void sbmButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("update Orase set NumeOras=@NumeOras, JudetOras=@JudetOras where NumeOras=@NumeOras1", sqlCon);
            cmd.Parameters.AddWithValue("@NumeOras1", oras_vechi.Text);
            cmd.Parameters.AddWithValue("@NumeOras", nume_oras_box.Text);
            cmd.Parameters.AddWithValue("@JudetOras", judet_box.Text);
            cmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show("Date actualizate cu succes!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
