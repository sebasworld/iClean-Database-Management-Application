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
    public partial class SimpleQ : Form
    {
        public SimpleQ()
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

        private void q1button_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select a.NumeClient, a.StradaClient +' '+ a.NumarClient as AdresaClient from Clienti a inner join Cartiere c on a.CartierID = c.CartierID inner join Orase o on c.OrasID = o.OrasID where o.NumeOras = 'Bucuresti'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                label1.Text = "Numele si adresa clientilor din Bucuresti:";
                sqlCon.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void q2button_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select a.NumeClient, a.PrenumeClient, count(ac.ClientID) as NrRecenzii from Clienti a inner join AngajatiClientiServicii ac on a.ClientID = ac.ClientID group by a.NumeClient, a.PrenumeClient having count(ac.ClientID) > 1", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                label1.Text = "Numele si prenumele clientilor care au oferit recenzie la mai mult de un serviciu:";
                sqlCon.Close();
            }
        }

        private void q3button_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select a.Nume, a.Prenume, ac.RecenzieAngajat from Angajati a inner join AngajatiClientiServicii ac on a.AngajatID = ac.AngajatID where  ac.RecenzieAngajat = '4'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                label1.Text = "Angajatii care au primit 4 la recenzie:";
                sqlCon.Close();
            }
        }

        private void q4button_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select a.Nume, a.Prenume, ac.NrOreSapt from Angajati a inner join AngajatiClientiServicii ac on a.AngajatID = ac.AngajatID where a.Sex = 'M' and ac.NrOreSapt < 16", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                label1.Text = "Angajatii de sex masculin care au mai putin de 16 ore lucrate pe saptamana:";
                sqlCon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                label1.Text = "Toate datele clientilor care sunt dintr-un judet/sector introdus:";
            }
            else
            {
                string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("select c.* from Clienti c inner join Cartiere ca on c.CartierID = ca.CartierID inner join Orase o on ca.OrasID = o.OrasID where o.JudetOras = @Judet", sqlCon);
                    sqlDa.SelectCommand.Parameters.Add("@Judet", SqlDbType.NVarChar).Value = textBox1.Text;
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                    label1.Text = "Toate datele clientilor care sunt din judetul/sectorul introdus:";
                    sqlCon.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select a.* from Angajati a inner join AngajatiClientiServicii ac on a.AngajatID = ac.AngajatID where ac.RecenzieAngajat = '5' and year(a.DataAngajarii)= 2020", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                label1.Text = "Datele angajaților care au fost angajati in anul 2020 si au minim o recenzie de 5:";
                sqlCon.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
