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

namespace ProiectFinal
{
    public partial class FormAdaugaServiciu : Form
    {
        String idInternare;
        SqlConnection con;

        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        DataTable internariTable, pacientiTable;

        public FormAdaugaServiciu(String idInternare)
        {
            InitializeComponent();
            this.idInternare = idInternare;
        }

        private void FormAdaugaServiciu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Serivicii' table. You can move, or remove it, as needed.
            this.seriviciiTableAdapter.Fill(this.dataSet2.Serivicii);

            txtDenumireServiciu.ReadOnly = true;
            txtTarif.ReadOnly = true;
            txtUM.ReadOnly = true;

            txtCantitate.ReadOnly = false;

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NewPC\source\repos\ProiectFinal\ProiectFinal\Database1.mdf;Integrated Security=True;");

            refreshGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCantitate_Click(object sender, EventArgs e)
        {

        }

        private void refreshGrid()
        {
            DataTable serviciiTable = new DataTable();
            String query = "SELECT * FROM Serivicii";
            con.Open();

            cmd = new SqlCommand(query, con);
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(serviciiTable);

            refreshLaBinds(serviciiTable);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = serviciiTable;


            con.Close();
        }

        private void refreshLaBinds(DataTable data)
        {
            txtIdServiciu.DataBindings.Clear();
            txtIdServiciu.DataBindings.Add("Text", data, "IdServici");

            txtUM.DataBindings.Clear();
            txtUM.DataBindings.Add("Text", data, "UM");

            txtTarif.DataBindings.Clear();
            txtTarif.DataBindings.Add("Text", data, "Tarif");

            txtDenumireServiciu.DataBindings.Clear();
            txtDenumireServiciu.DataBindings.Add("Text", data, "DenumireServici");
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (txtCantitate.Text != "")
            {
                /*try 
                { 

                } catch { }*/

                confirmareServiciu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Va rugam completati cantitatea !");
            }
        }

        private void confirmareServiciu()
        {
            con.Open();

            string QUERY = "INSERT INTO InternareContinut " +
            "(Nrc, IdServici, IdInternare, Tarif, Cantitate)" +
            "VALUES (@Nrc, @IdServici, @IdInternare, @Tarif, @Cantitate)";

            SqlCommand cmd = new SqlCommand(QUERY, con);
            cmd.Parameters.AddWithValue("@Nrc", calculeazaNrc());
            cmd.Parameters.AddWithValue("@IdServici", txtIdServiciu.Text);
            cmd.Parameters.AddWithValue("@IdInternare", idInternare);
            cmd.Parameters.AddWithValue("@Tarif", txtTarif.Text);
            cmd.Parameters.AddWithValue("@Cantitate", txtCantitate.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private int calculeazaNrc()
        {
            DataTable internariContinutTable = new DataTable();
            String query = "SELECT * FROM InternareContinut";

            try
            {
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }


            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(internariContinutTable);

            int count = internariContinutTable.AsEnumerable()
           .Count(row => row.Field<int>("IdInternare") == int.Parse(idInternare));

            return count + 1;
        }
    }
}
