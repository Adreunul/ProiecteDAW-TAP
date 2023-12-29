using System;
using System.Collections;
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
    public partial class FormPacienti : Form
    {
        SqlConnection con;

        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        DataTable pacientiTable;

        public FormPacienti()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NewPC\source\repos\ProiectFinal\ProiectFinal\Database1.mdf;Integrated Security=True;");
        }



        private void FormPacienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.dataSet2.Pacienti);

            configureazaButoane(true);

            //legareControale(true);

            protectiePanel(true);

            txtIdPacient.ReadOnly = true;
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            adaugarePacient();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            modificarePacient();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            confirmarePacient();
        }

        private void adaugarePacient() //A2
        {
            lblOperatie.Text = "Adaugare pacient";

            configureazaButoane(false);

            legareControale(false);

            protectiePanel(false);

            txtNume.Focus();

            golireCampuri();

        }

        private void stareNeutra()
        {
            //Initializare lblOp
            lblOperatie.Text = "";

            //Çonfigurare(butoane)
            configureazaButoane(true);

            //Protectie componente Panel
            protectiePanel(true);

            //Legare controale
            //legareControale(true);

        }

        private void modificarePacient() //A7
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOperatie.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            txtNume.Focus();

        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtSpImagine.DataBindings.Add("Text", pacientiBindingSource, "SpPoza");
                txtNume.DataBindings.Add("Text", pacientiBindingSource, "NumePacient");
                txtCNP.DataBindings.Add("Text", pacientiBindingSource, "CNP");
                txtNrTelefon.DataBindings.Add("Text", pacientiBindingSource, "NrTelefon");
                txtAdresa.DataBindings.Add("Text", pacientiBindingSource, "Adresa");
                txtIdPacient.DataBindings.Add("Text", pacientiBindingSource, "IdPacient");
      
            }
            else
            {
                txtSpImagine.DataBindings.Clear();
                txtNume.DataBindings.Clear();
                txtCNP.DataBindings.Clear();
                txtNrTelefon.DataBindings.Clear();
                txtAdresa.DataBindings.Clear();
                txtIdPacient.DataBindings.Clear();
            }

        }

        private void refreshLaBinds(DataTable data)
        {
           txtSpImagine.DataBindings.Add("Text", data, "SpPoza");
           txtNume.DataBindings.Add("Text", data, "NumePacient");
           txtCNP.DataBindings.Add("Text", data, "CNP");
           txtNrTelefon.DataBindings.Add("Text", data, "NrTelefon");
           txtAdresa.DataBindings.Add("Text", data, "Adresa");
           txtIdPacient.DataBindings.Add("Text", data, "IdPacient");
        }

        private void protectiePanel(bool v)
        {
            txtNume.ReadOnly = v;
            txtCNP.ReadOnly = v;
            txtNrTelefon.ReadOnly = v;
            txtAdresa.ReadOnly = v;
            txtSpImagine.ReadOnly = v;
    
        }

        private void golireCampuri()
        {
            txtNume.Text = "";
            txtCNP.Text = "";
            txtNrTelefon.Text = "";
            txtAdresa.Text = "";
            txtSpImagine.Text = "";
            txtIdPacient.Text = "";
            pb.ImageLocation = "";
        }

        private void confirmarePacient()  //A4
        {
            if (lblOperatie.Text == "Adaugare pacient")
            {
                if (!validareCampuriObligatorii()) return;

                adaugaInregistrare();

                golireCampuri();

                txtNume.Focus();

                refreshGrid();
            }
            else if (lblOperatie.Text == "MODIFICARE")
            {
                modificaInregistrare();
                refreshGrid();
                stareNeutra();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");

        }

        private Boolean validareCampuriObligatorii()
        {
            if (txtNume.Text == "")
            {
                MessageBox.Show("Completati DPartener !");
                txtNume.Focus();
                return false;
            }
            if (txtCNP.Text == "")
            {
                MessageBox.Show("Completati CodPartener !");
                txtCNP.Focus();
                return false;
            }
            if (txtNrTelefon.Text == "")
            {
                MessageBox.Show("Completati Localitate !");
                txtNrTelefon.Focus();
                return false;
            }

            if (txtAdresa.Text == "")
            {
                MessageBox.Show("Completati Adresa !");
                txtAdresa.Focus();
                return false;
            }
            return true;

        }

        private void adaugaInregistrare()
        {
            con.Open();
            
            string QUERY = "INSERT INTO Pacienti " +
            "(NumePacient, CNP, NrTelefon, Adresa, SpPoza)" +
            "VALUES (@NumePacient, @CNP, @NrTelefon, @Adresa, @SpPoza)";

            SqlCommand cmd = new SqlCommand(QUERY, con);
            cmd.Parameters.AddWithValue("@NumePacient", txtNume.Text);
            cmd.Parameters.AddWithValue("@CNP", txtCNP.Text);
            cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);
            cmd.Parameters.AddWithValue("@Adresa", txtAdresa.Text);
            cmd.Parameters.AddWithValue("@SpPoza", txtSpImagine.Text);
            cmd.ExecuteNonQuery();

            this.pacientiTableAdapter.Fill(this.dataSet2.Pacienti);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pacientiBindingSource;

            pacientiBindingSource.ResetBindings(false);
            dataGridView1.Update();
            dataGridView1.Refresh();

            con.Close();
        }

        private void modificaInregistrare()
        {
            string query;
            con.Open();

            query = "UPDATE Pacienti SET NumePacient = @NumePacient, " +
                 "CNP = @CNP, NrTelefon = @NrTelefon, " +
                 "SpPoza = @SpPoza, Adresa = @Adresa " +
                 "WHERE IdPacient = @ID";

            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@NumePacient", txtNume.Text);
            cmd.Parameters.AddWithValue("@CNP", txtCNP.Text);
            cmd.Parameters.AddWithValue("@Adresa", txtAdresa.Text);
            cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);
            cmd.Parameters.AddWithValue("@SpPoza", txtSpImagine.Text);
            cmd.Parameters.AddWithValue("@ID", txtIdPacient.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void stergeInregistrare() //A8
        {
            String query;
            query = "DELETE FROM Pacienti WHERE IdPacient = @ID";

            con.Open();

            try
            {
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", txtIdPacient.Text);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                
            }

            con.Close();
        }


        private void refreshGrid()
        {
            pacientiTable = new DataTable();
            String query = "SELECT * FROM Pacienti";
            con.Open();

            cmd = new SqlCommand(query, con);
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(pacientiTable);

            refreshLaBinds(pacientiTable);
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pacientiTable;

            con.Close();
        }



        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            stergeInregistrare();
            refreshGrid();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            refreshGrid();
            stareNeutra();
        }
    }
}
