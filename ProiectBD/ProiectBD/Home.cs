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
    public partial class Home : Form
    {
        string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
        public Home()
        {
            InitializeComponent();
        }

        private void extButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select c.NumeCartier, o.NumeOras, c.CodPostal from Cartiere c inner join Orase o on c.OrasID = o.OrasID", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iCleanDataSet.AngajatiClientiServicii' table. You can move, or remove it, as needed.
            this.angajatiClientiServiciiTableAdapter.Fill(this.iCleanDataSet.AngajatiClientiServicii);
            // TODO: This line of code loads data into the 'iCleanDataSet.Cartiere' table. You can move, or remove it, as needed.
            this.cartiereTableAdapter.Fill(this.iCleanDataSet.Cartiere);
            // TODO: This line of code loads data into the 'iCleanDataSet.Angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.iCleanDataSet.Angajati);

        }

        private void btnAngajati_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select Nume, Prenume, DataAngajarii, Salariu from Angajati", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void btnServicii_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select NumeServiciu, BugetAlocat, PretServiciu from Servicii", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select a.NumeClient, a.PrenumeClient, c.NumeCartier as CartierDomiciliu, a.TelefonClient, a.EmailClient, a.StradaClient, a.NumarClient from Clienti a inner join Cartiere c on a.CartierID = c.CartierID", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void btnOrase_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select NumeOras, JudetOras from Orase", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void btnACS_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select a.Nume as NumeAngajatRecenziat, c.NumeClient as AutorRecenzie , s.NumeServiciu, ac.RecenzieAngajat as NotaRecenzie, ac.NrOreSapt from AngajatiClientiServicii ac inner join Servicii s on ac.ServiciuID = s.ServiciuID inner join Clienti c on ac.ClientID= c.ClientID inner join Angajati a on a.AngajatID = ac.AngajatID", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void insertOrase_Click(object sender, EventArgs e)
        {
            new InsertOrase().Show();
            this.Hide();
        }

        private void updOrase_Click(object sender, EventArgs e)
        {
            new UpdateOrase().Show();
            this.Hide();
        }

        private void delServicii_Click(object sender, EventArgs e)
        {
            new DeleteServiciu().Show();
            this.Hide();
        }

        private void insertServicii_Click(object sender, EventArgs e)
        {
            new InsertServicii().Show();
            this.Hide();
        }

        private void delOrase_Click(object sender, EventArgs e)
        {
            new DeleteOras().Show();
            this.Hide();
        }

        private void updServicii_Click(object sender, EventArgs e)
        {
            new UpdateServicii().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleqButton_Click(object sender, EventArgs e)
        {
            new SimpleQ().Show();
            this.Hide();
        }

        private void complexqButton_Click(object sender, EventArgs e)
        {
            new ComplexQ().Show();
            this.Hide();
        }
    }
}
