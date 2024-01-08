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
{   //baga si tu golire campuri peste tot la butonul de adauga taca paca saca la raca taca
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

            //hiddenIdPicker.Visible = false;

            txtTotal.ReadOnly = false;

            txtPacient.ReadOnly = true;
            txtPacient.Visible = false;

            txtIdPacient.ReadOnly = true;
            txtIdPacient.Visible = false;

            lblIdPacient.Visible = false;

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NewPC\source\repos\ProiectFinal\ProiectFinal\Database1.mdf;Integrated Security=True;");

            pacientiTable = new DataTable();
            String query = "SELECT * FROM Pacienti";
            con.Open();

            cmd = new SqlCommand(query, con);
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(pacientiTable);

            con.Close();

            refreshGrid();
        }

        private void FormInternari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet21.InternareContinut' table. You can move, or remove it, as needed.
            this.internareContinutTableAdapter.Fill(this.dataSet21.InternareContinut);
            // TODO: This line of code loads data into the 'dataSet2.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.dataSet2.DataTable2);
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

        private void btnAdaugaInternare_Click(object sender, EventArgs e)
        {
            config(false);
            dezlegareControale();
            comboPacient.Enabled = true;
            lblOperatie.Text = "Adauga Internare";
        }

        private void btnModificaInternare_Click(object sender, EventArgs e)
        {
            config(false);
            //bindLaPacientiiInternati();
            comboPacient.Visible = false;
            txtPacient.Visible = true;
            txtIdPacient.Visible = true;
            lblIdPacient.Visible = true;
            //lblPacient.Visible = false;
            dezlegareControale();
            dataGridView1.Enabled = false;
            lblOperatie.Text = "Modifica Internare";
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (lblOperatie.Text != "Modifica servicii")
            {
                confirmareInternare();

                //astea sunt asa fiindca abia dupa am adaugat sa fie diferita functia de modifica
                // am pus sa iti arate numele in textbox ca era complicat sa il arate in combobox
                // si apare si id-ul, pentru a putea identifica usor unde facem modificarea
                txtPacient.Visible = false;
                txtIdPacient.Visible = false;
                lblIdPacient.Visible = false;
            }
            else
            {
                adaugaServiciu();
            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            //refreshLaBinds();

            txtPacient.Visible = false;
            txtIdPacient.Visible = false;
            lblIdPacient.Visible = false;
            refreshGrid();
            config(true);
            dataGridView1.Enabled = true;
        }

        private void btnStergeInternare_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            stergeInternare();
            refreshGrid();
        }


        private void btnCalculeazaTotal_Click(object sender, EventArgs e)
        {
            calculeazaTotal();
        }

        private void btnAdaugaServiciu_Click(object sender, EventArgs e)
        {
            FormAdaugaServiciu f = new FormAdaugaServiciu(idInternarePicker.Text);
            f.ShowDialog();

            refreshLaServicii();
        }

        private void btnStergeServiciu_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            stergeServiciu();
            refreshLaServicii();
        }

        private void idInternarePicker_TextChanged(object sender, EventArgs e)
        {
            refreshLaServicii();

            txtTotal.Text = "";
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
            comboPacient.Visible = !v;
            lblPacient.Visible = !v;
            dateTimePicker1.Enabled = !v;
            dateTimePicker2.Enabled = !v;

            lblOperatie.Visible = !v;

            idInternarePicker.Visible = v;
            lblIdInternare.Visible = v;
            btnAdaugaServiciu.Visible = v;
            btnStergeServiciu.Visible = v;
            lblTotalPlata.Visible = v;
            lblLei.Visible = v;
            txtTotal.Visible = v;
           

            if (!v)
                bindLaTotiPacientii();
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
           
                adaugaInternare();

                comboPacient.Focus();

                refreshGrid();
            }
            else if (lblOperatie.Text == "Modifica Internare")
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
            string query;
            con.Open();

            query = "UPDATE Internari SET DataInternare = @DataInternare, " +
                  "DataExternare = @DataExternare, Sectie = @Sectie, " +
            "Diagnostic = @Diagnostic WHERE IdPacient = @IdPacient";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdPacient", txtIdPacient.Text);
            cmd.Parameters.AddWithValue("@DataInternare", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@DataExternare", dateTimePicker2.Value.Date);
            cmd.Parameters.AddWithValue("@Sectie", txtSectie.Text);
            cmd.Parameters.AddWithValue("@Diagnostic", txtDiagnostic.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void bindLaTotiPacientii() // pt cand adaugam internare, sa ii vedem pe toti
        {
            DataTable pacientiTable = new DataTable();
            String query = "SELECT * FROM Pacienti";
            con.Open();

            cmd = new SqlCommand(query, con);
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(pacientiTable);

            comboPacient.DataSource = null;
            comboPacient.DataSource = pacientiTable;

            comboPacient.DisplayMember = "NumePacient";

            con.Close() ;
        }

        private void refreshLaBinds(DataTable data)
        {
            dezlegareControale();


            //comboPacient.DataBindings.Add("Text", data, "IdInternare");
            txtPacient.DataBindings.Clear();
            txtPacient.DataBindings.Add("Text", data, "NumePacient");
            txtIdPacient.DataBindings.Clear();
            txtIdPacient.DataBindings.Add("Text", data, "IdPacient");
            dateTimePicker1.DataBindings.Add("Text", data, "DataInternare");
            dateTimePicker2.DataBindings.Add("Text", data, "DataExternare");
            txtSectie.DataBindings.Add("Text", data, "Sectie");
            txtDiagnostic.DataBindings.Add("Text", data, "Diagnostic");
            idInternarePicker.DataBindings.Add("Text", data, "IdInternare");
        }

        private void refreshLaServicii()
        {
            DataTable serviciiTable = new DataTable();
            String query = "SELECT        Serivicii.DenumireServici, Serivicii.IdServici, Serivicii.Tarif, Serivicii.UM, InternareContinut.IdInternareContinut, InternareContinut.Nrc, InternareContinut.IdServici AS Expr1, InternareContinut.IdInternare, \r\n                         InternareContinut.Tarif AS Expr2, InternareContinut.Cantitate, Internari.IdInternare AS Expr3, Internari.IdPacient, Internari.DataInternare, Internari.DataExternare, Internari.Sectie, Internari.Diagnostic\r\nFROM            InternareContinut INNER JOIN\r\n                         Internari ON InternareContinut.IdInternare = Internari.IdInternare INNER JOIN\r\n                         Serivicii ON InternareContinut.IdServici = Serivicii.IdServici";
            //con.Open();

            cmd = new SqlCommand(query, con);
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(serviciiTable);

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = serviciiTable;

            hiddenIdPicker.DataBindings.Clear();
            hiddenIdPicker.DataBindings.Add("Text", serviciiTable, "IdInternareContinut");


            DataView dataView = serviciiTable.DefaultView;
            int filterId;

            if (int.TryParse(idInternarePicker.Text, out filterId))
            {
                dataView.RowFilter = $"IdInternare = {filterId}";
            }


            //con.Close();
        }

        private void refreshGrid()
        {
            internariTable = new DataTable();
            String query = "SELECT        Internari.IdInternare, Internari.IdPacient, Internari.DataInternare, Internari.DataExternare, Internari.Sectie, Internari.Diagnostic, Pacienti.IdPacient AS Expr1, Pacienti.NumePacient, Pacienti.Adresa, Pacienti.SpPoza, \r\n                         Pacienti.NrTelefon, Pacienti.CNP\r\nFROM            Internari INNER JOIN\r\n                         Pacienti ON Internari.IdPacient = Pacienti.IdPacient";
            con.Open();

            cmd = new SqlCommand(query, con);
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(internariTable);

            refreshLaBinds(internariTable);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = internariTable;

            comboPacient.DataBindings.Add("Text", internariTable, "NumePacient");

            con.Close();
        } 

        private void calculeazaTotal()
        {
            DataTable internariContinutTable = new DataTable();
            String query = "SELECT * FROM InternareContinut WHERE IdInternare = @ID";
            con.Open();

            try
            {
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", idInternarePicker.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }


            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(internariContinutTable);

            con.Close();



            decimal totalCombinedPrice = internariContinutTable.AsEnumerable().Sum(row =>
            {
                decimal price = row.Field<decimal>("Tarif");
                int quantity = row.Field<int>("Cantitate");
                return price * quantity;
            });

            txtTotal.Text = totalCombinedPrice.ToString();
        }

        private void adaugaServiciu()
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

        private void stergeServiciu()
        {
            String query;
            query = "DELETE FROM InternareContinut WHERE IdInternareContinut = @ID";

            con.Open();

            MessageBox.Show("Am deschis");
            try
            {
                MessageBox.Show("Am sters" + hiddenIdPicker.Text);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", hiddenIdPicker.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            con.Close();
        }

        private void adaugaInternare()
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
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void stergeInternare()
        {
            String query;
            query = "DELETE FROM Internari WHERE IdInternare = @ID";

            con.Open();

            try
            {
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", idInternarePicker.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            con.Close();
        } 
    }
}
