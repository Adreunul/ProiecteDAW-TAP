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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectFinal
{
    public partial class FormServicii : Form
    {
        SqlConnection con;

        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        DataTable serviciTable;

        public FormServicii()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NewPC\source\repos\ProiectFinal\ProiectFinal\Database1.mdf;Integrated Security=True;");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            txtId.ReadOnly = true;
        }

        private void FormServicii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Serivicii' table. You can move, or remove it, as needed.
            this.seriviciiTableAdapter.Fill(this.dataSet2.Serivicii);

            config(true);

            refreshGrid();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            config(false);
            lblOperatie.Text = "Adaugare serviciu";
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                config(false);
                lblOperatie.Text = "Modifica serviciu";
            }
            else
                MessageBox.Show("Selectati un serviciu !");
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            confirmareServiciu();
        }

        private void btnRenuntare_Click_1(object sender, EventArgs e)
        {
            config(true);
            refreshGrid();
            lblOperatie.Text = "lblOp";
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

        public void config(Boolean v)
        {
            txtDenumire.ReadOnly = v;
            txtUM.ReadOnly = v;
            txtTarif.ReadOnly = v;

            btnAdaugare.Visible = v;
            btnModificare.Visible = v;
            btnStergere.Visible = v;

            btnConfirmare.Visible = !v;
            btnRenuntare.Visible = !v;

            txtId.Visible = v;
        }

        private bool completareCampuri()
        {
            if (txtDenumire.Text == "")
            {
                MessageBox.Show("Completati denumirea serviciului !");
                txtDenumire.Focus();
                return false;
            }
            if (txtUM.Text == "")
            {
                MessageBox.Show("Completati unitatea de masura !");
                txtUM.Focus();
                return false;
            }
            if (txtTarif.Text == "")
            {
                MessageBox.Show("Completati tariful !");
                txtTarif.Focus();
                return false;
            }

            return true;
        }


        private void confirmareServiciu()  //A4
        {
            if (lblOperatie.Text == "Adaugare serviciu")
            {
                if (!completareCampuri()) return;

                adaugaInregistrare();

                //golireCampuri();

                //txtNume.Focus();

                config(true);

                refreshGrid();

                lblOperatie.Text = "lblOp";
            }
            else if (lblOperatie.Text == "Modifica serviciu")
            {
                modificaInregistrare();
                config(true);
                refreshGrid();
                lblOperatie.Text = "lblOp";
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");

        }

        private void adaugaInregistrare()
        {
            con.Open();

            string QUERY = "INSERT INTO Serivicii " +
            "(DenumireServici, UM, Tarif)" +
            "VALUES (@DenumireServici, @UM, @Tarif)";

            SqlCommand cmd = new SqlCommand(QUERY, con);
            cmd.Parameters.AddWithValue("@DenumireServici", txtDenumire.Text);
            cmd.Parameters.AddWithValue("@UM", txtUM.Text);
            cmd.Parameters.AddWithValue("@Tarif", txtTarif.Text);
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

        private void modificaInregistrare()
        {
            string query;
            con.Open();

            query = "UPDATE Serivicii SET DenumireServici = @DenumireServici, " +
                 "UM = @UM, Tarif = @Tarif " +
                 "WHERE IdServici = @ID";

            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@DenumireServici", txtDenumire.Text);
            cmd.Parameters.AddWithValue("@UM", txtUM.Text);
            cmd.Parameters.AddWithValue("@Tarif", txtTarif.Text);
            cmd.Parameters.AddWithValue("@ID", txtId.Text);
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

        private void stergeInregistrare()
        {
            String query;
            query = "DELETE FROM Serivicii WHERE IdServici = @ID";

            con.Open();

            try
            {
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", txtId.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


            con.Close();
        }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(btnStergere.Focused)
            {
                dataGridView1.CancelEdit();
                config(true);

                return;
            }
            MessageBox.Show("Format eronat");
        }


        private void refreshGrid()
        {
            serviciTable = new DataTable();
            String query = "SELECT * FROM Serivicii";
            con.Open();

            cmd = new SqlCommand(query, con);
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(serviciTable);


            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", serviciTable, "IdServici");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = serviciTable;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
