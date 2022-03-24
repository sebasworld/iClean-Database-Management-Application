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
    public partial class ComplexQ : Form
    {
        public ComplexQ()
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("select a.Nume, a.Prenume, s.PretServiciu from Angajati a inner join AngajatiClientiServicii ac on a.AngajatID = ac.AngajatID inner join Servicii s on s.ServiciuID = ac.ServiciuID where (select avg(s2.PretServiciu) from Servicii s2) < s.PretServiciu group by a.Nume, a.Prenume, s.PretServiciu", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                label1.Text = "Angajatii care presteaza servicii mai scumpe decat media preturilor tuturor serviciilor existente:";
                sqlCon.Close();
            }
        }

        private void q2button_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select distinct a.Nume, a.Prenume, a.AngajatID from Angajati a inner join AngajatiClientiServicii ac on a.AngajatID <> ac.AngajatID where a.Sex = 'F' and a.AngajatID not in (select ac2.AngajatID from AngajatiClientiServicii ac2)", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                label1.Text = "Angajatii de sex feminin care nu presteaza niciun serviciu:";
                sqlCon.Close();
            }
        }

        private void q3button_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select a.Nume, a.Prenume from Angajati a inner join AngajatiClientiServicii acs on a.AngajatID = acs.AngajatID group by a.Nume, a.Prenume having count(acs.ClientID) = (select top 1 count(acs.ClientID) as nrclienti from AngajatiClientiServicii acs inner join Angajati a on a.AngajatID = acs.AngajatID group by a.AngajatID)", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                label1.Text = "Angajatii care presteaza numarul cel mai mare de servicii:";
                sqlCon.Close();
            }
        }

        private void q4button_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                label1.Text = "Judetele din care provine un singur client si pentru care au lucrat numai angajati cu un anumit nr. de ore/sapt:";
            }
            else
            {
                string connectionString = @"Data Source=DESKTOP-MU1D2BV\SQLEXPRESS;Initial Catalog=iClean;Integrated Security=True";
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("select o.JudetOras as Judet_Sector from Orase o inner join Cartiere ca on ca.OrasID = o.OrasID inner join Clienti c2 on c2.CartierID = ca.CartierID where c2.ClientID = any(select distinct c.ClientID from Clienti c inner join AngajatiClientiServicii acs on c.ClientID = acs.ClientID where acs.NrOreSapt >= @nrore group by c.ClientID) and (select count(c3.ClientID) from Clienti c3 where c3.CartierID = c2.CartierID) = 1 group by o.JudetOras", sqlCon);
                    sqlDa.SelectCommand.Parameters.Add("@nrore", SqlDbType.Decimal).Value = textBox1.Text;
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                    label1.Text = "Judetele din care provine un singur client si pentru care au lucrat numai angajati cu nr. de ore/sapt introdus:";
                    sqlCon.Close();
                }
            }
            
        }
    }
}
