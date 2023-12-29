using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectFinal.ImaginiPacienti
{
    public partial class FormInternari : Form
    {
        SqlConnection con;

        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        DataTable internariTable, pacientiTable;

        public FormInternari()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NewPC\source\repos\ProiectFinal\ProiectFinal\Database1.mdf;Integrated Security=True;");

            pacientiTable = new DataTable();
            String query = "SELECT * FROM Pacienti";
            con.Open();

            cmd = new SqlCommand(query, con);
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(pacientiTable);

            con.Close();
        }

        private void FormInternari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet2.DataTable1);
            // TODO: This line of code loads data into the 'dataSet2.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.dataSet2.Pacienti);
            // TODO: This line of code loads data into the 'dataSet2.Serivicii' table. You can move, or remove it, as needed.
            this.seriviciiTableAdapter.Fill(this.dataSet2.Serivicii);
            // TODO: This line of code loads data into the 'dataSet2.Internari' table. You can move, or remove it, as needed.
            this.internariTableAdapter.Fill(this.dataSet2.Internari);

            config(true);
        }

        public void config(Boolean v)
        {

            btnAdaugaInternare.Visible = v;
            btnStergeInternare.Visible = v;
            btnModificaInternare.Visible = v;

            btnConfirma.Visible = !v;
            btnRenunta.Visible = !v;

            txtSectie.ReadOnly = v;
            txtDiagnostic.ReadOnly = v;
            comboPacient.Enabled = !v;
            dateTimePicker1.Enabled = !v;
            dateTimePicker2.Enabled = !v;

            lblOperatie.Visible = !v;
        }

        private void dezlegareControale()
        {
            comboPacient.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker2.DataBindings.Clear();
            txtDiagnostic.DataBindings.Clear();
            txtSectie.DataBindings.Clear();
            txtTotal.DataBindings.Clear();
            idInternarePicker.DataBindings.Clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idInternarePicker_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            Int32.TryParse(idInternarePicker.Text, out x);
            dataTable1BindingSource.Filter = "IdInternare = " + x;
        }

        private void btnAdaugaInternare_Click(object sender, EventArgs e)
        {
            config(false);
            dezlegareControale();
            lblOperatie.Text = "Adauga Internare";
        }

        private void btnModificaInternare_Click(object sender, EventArgs e)
        {
            config(false);
            dezlegareControale();
            lblOperatie.Text = "Modifica Internare";
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            confirmareInternare();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            //refreshLaBinds();
            
           // refreshGrid();
            config(true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Boolean validareCampuriObligatorii()
        {
            if (comboPacient.SelectedIndex <= -1)
            {
                MessageBox.Show("Selectati un pacient !");
                comboPacient.Focus();
                return false;
            }
            if (txtSectie.Text == "")
            {
                MessageBox.Show("Completati Sectia !");
                txtSectie.Focus();
                return false;
            }

            if (txtDiagnostic.Text == "")
            {
                MessageBox.Show("Completati Diagnosticul !");
                txtDiagnostic.Focus();
                return false;
            }
            return true;

        }

        private void confirmareInternare()
        {
            if (lblOperatie.Text == "Adauga Internare")
            {
                MessageBox.Show("Am ajuns aici !");
                if (!validareCampuriObligatorii()) return;
           
                adaugaInregistrare();

                //golireCampuri();

                comboPacient.Focus();

                refreshGrid();
            }
            else if (lblOperatie.Text == "MODIFICARE")
            {
                modificaInregistrare();
                refreshGrid();
                config(true);
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void modificaInregistrare()
        {
            int id;
            bool result = int.TryParse(comboPacient.SelectedValue.ToString(), out id);

            string query;
            con.Open();

            query = "UPDATE Internari SET DataInternare = @DataInternare, " +
                  "DataExternare = @DataExternare, Sectie = @Sectie, " +
            "Diagonstic = @Diagnostic WHERE IdPacient = @IdPacient";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdPacient", id);
            cmd.Parameters.AddWithValue("@DataInternare", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@DataExternare", dateTimePicker2.Value.Date);
            cmd.Parameters.AddWithValue("@Sectie", txtSectie.Text);
            cmd.Parameters.AddWithValue("@Diagnostic", txtDiagnostic.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void refreshLaBinds(DataTable data)
        {
            dezlegareControale();

            dateTimePicker1.DataBindings.Add("Text", data, "DataInternare");
            dateTimePicker2.DataBindings.Add("Text", data, "DataExternare");
            txtSectie.DataBindings.Add("Text", data, "Sectie");
            txtDiagnostic.DataBindings.Add("Text", data, "Diagnostic");
            idInternarePicker.DataBindings.Add("Text", data, "IdInternare");
        }


        private void refreshGrid()
        {
            internariTable = new DataTable();
            String query = "SELECT * FROM Internari";
            con.Open();

            cmd = new SqlCommand(query, con);
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(internariTable);

            refreshLaBinds(internariTable);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = internariTable;


            DataTable dataPacienti = new DataTable();
            query = "SELECT * FROM Pacienti";
            cmd = new SqlCommand(query, con);
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataPacienti);


            comboPacient.DataBindings.Add("Text", dataPacienti, "NumePacient");

            con.Close();
        }

        private void adaugaInregistrare()
        {
            int id;
            bool result = int.TryParse(comboPacient.SelectedValue.ToString(), out id);

            

            con.Open();

            string QUERY = "INSERT INTO Internari " +
            "(IdPacient, DataInternare, DataExternare, Sectie, Diagnostic)" +
            "VALUES (@IdPacient, @DataInternare, @DataExternare, @Sectie, @Diagnostic)";

            SqlCommand cmd = new SqlCommand(QUERY, con);
            cmd.Parameters.AddWithValue("@IdPacient", id);
            cmd.Parameters.AddWithValue("@DataInternare", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@DataExternare", dateTimePicker2.Value.Date);
            cmd.Parameters.AddWithValue("@Sectie", txtSectie.Text);
            cmd.Parameters.AddWithValue("@Diagnostic", txtDiagnostic.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        
    }
}
