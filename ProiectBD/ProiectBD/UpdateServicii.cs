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
    public partial class UpdateServicii : Form
    {
        string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
        public UpdateServicii()
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
            SqlCommand cmd = new SqlCommand("update Servicii set NumeServiciu=@NumeServiciu, BugetAlocat=@BugetAlocat, PretServiciu=@PretServiciu where NumeServiciu=@NumeServiciu1", sqlCon);
            cmd.Parameters.AddWithValue("@NumeServiciu1", serv_vechi.Text);
            cmd.Parameters.AddWithValue("@NumeServiciu", nume_serviciu_box.Text);
            cmd.Parameters.AddWithValue("@BugetAlocat", decimal.Parse(buget_alocat_box.Text));
            cmd.Parameters.AddWithValue("@PretServiciu", decimal.Parse(pret_serviciu_box.Text));


            cmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show("Date actualizate cu succes!");
        }
    }
}
