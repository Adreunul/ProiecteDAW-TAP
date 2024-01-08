using ProiectFinal.ImaginiPacienti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinal
{
    public partial class FormStart : Form
    {
        String query;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;

        public FormStart()
        {
            InitializeComponent();
        }

       

        private void FormStart_Load(object sender, EventArgs e)
        {
            A1(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPacienti f = new FormPacienti();
            f.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormInternari f = new FormInternari();
            f.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormServicii f = new FormServicii();
            f.ShowDialog();
        }

        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            lblTitlu.Visible = !v;
            lblAutor.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUsername.Visible = v;
            txtUsername.Visible = v;
            if (v) btnStart.Text = "Log In";
            else btnStart.Text = "Log Out";
        }
        private Boolean Logare_OK()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUsername.Focus();
                return false;
            }

            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return false;
            }

            query = "Select IdUtilizator,Parola from Utilizatori " +
                              "where Username='" + txtUsername.Text + "'";
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NewPC\source\repos\ModelAlexandrescu\ModelAlexandrescu\Database1.mdf;Integrated Security=True;");

            cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                MessageBox.Show("Conexiune realizata");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            dataReader = cmd.ExecuteReader();

           
            if (dataReader.Read())
            {
                if (txtParola.Text != dataReader.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtParola.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUsername.Focus();
                con.Close();
                return false;
            }
        }
    }
}
