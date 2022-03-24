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
    public partial class DeleteServiciu : Form
    {
        string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
        public DeleteServiciu()
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
            SqlCommand cmd = new SqlCommand("delete Servicii where NumeServiciu=@NumeServiciu", sqlCon);
            cmd.Parameters.AddWithValue("@NumeServiciu", nume_serviciu_box.Text);
            cmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show("Date eliminate cu succes!");
        }
    }
}
