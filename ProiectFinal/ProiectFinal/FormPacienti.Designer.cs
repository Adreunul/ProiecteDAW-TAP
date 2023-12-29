namespace ProiectFinal
{
    partial class FormPacienti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numePacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spPozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new ProiectFinal.DataSet2();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSpImagine = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtNrTelefon = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtIdPacient = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.lblOperatie = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.pacientiTableAdapter = new ProiectFinal.DataSet2TableAdapters.PacientiTableAdapter();
            this.pacientiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(38, 85);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 0;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(119, 85);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 1;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(200, 85);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPacientDataGridViewTextBoxColumn,
            this.numePacientDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.spPozaDataGridViewTextBoxColumn,
            this.nrTelefonDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pacientiBindingSource, "IdPacient", true));
            this.dataGridView1.DataSource = this.pacientiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idPacientDataGridViewTextBoxColumn
            // 
            this.idPacientDataGridViewTextBoxColumn.DataPropertyName = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.HeaderText = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.Name = "idPacientDataGridViewTextBoxColumn";
            this.idPacientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numePacientDataGridViewTextBoxColumn
            // 
            this.numePacientDataGridViewTextBoxColumn.DataPropertyName = "NumePacient";
            this.numePacientDataGridViewTextBoxColumn.HeaderText = "NumePacient";
            this.numePacientDataGridViewTextBoxColumn.Name = "numePacientDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // spPozaDataGridViewTextBoxColumn
            // 
            this.spPozaDataGridViewTextBoxColumn.DataPropertyName = "SpPoza";
            this.spPozaDataGridViewTextBoxColumn.HeaderText = "SpPoza";
            this.spPozaDataGridViewTextBoxColumn.Name = "spPozaDataGridViewTextBoxColumn";
            // 
            // nrTelefonDataGridViewTextBoxColumn
            // 
            this.nrTelefonDataGridViewTextBoxColumn.DataPropertyName = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.HeaderText = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.Name = "nrTelefonDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(648, 85);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 5;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(567, 85);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SpImagine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CNP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nr telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id Pacient";
            // 
            // txtSpImagine
            // 
            this.txtSpImagine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "SpPoza", true));
            this.txtSpImagine.Location = new System.Drawing.Point(625, 127);
            this.txtSpImagine.Name = "txtSpImagine";
            this.txtSpImagine.Size = new System.Drawing.Size(204, 20);
            this.txtSpImagine.TabIndex = 12;
            // 
            // txtNume
            // 
            this.txtNume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "NumePacient", true));
            this.txtNume.Location = new System.Drawing.Point(625, 159);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(204, 20);
            this.txtNume.TabIndex = 13;
            // 
            // txtCNP
            // 
            this.txtCNP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "CNP", true));
            this.txtCNP.Location = new System.Drawing.Point(625, 189);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(204, 20);
            this.txtCNP.TabIndex = 14;
            // 
            // txtNrTelefon
            // 
            this.txtNrTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "NrTelefon", true));
            this.txtNrTelefon.Location = new System.Drawing.Point(625, 215);
            this.txtNrTelefon.Name = "txtNrTelefon";
            this.txtNrTelefon.Size = new System.Drawing.Size(204, 20);
            this.txtNrTelefon.TabIndex = 15;
            // 
            // txtAdresa
            // 
            this.txtAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "Adresa", true));
            this.txtAdresa.Location = new System.Drawing.Point(623, 241);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(204, 20);
            this.txtAdresa.TabIndex = 16;
            // 
            // txtIdPacient
            // 
            this.txtIdPacient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientiBindingSource, "IdPacient", true));
            this.txtIdPacient.Location = new System.Drawing.Point(625, 267);
            this.txtIdPacient.Name = "txtIdPacient";
            this.txtIdPacient.Size = new System.Drawing.Size(29, 20);
            this.txtIdPacient.TabIndex = 17;
            // 
            // pb
            // 
            this.pb.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pacientiBindingSource, "SpPoza", true));
            this.pb.Location = new System.Drawing.Point(695, 267);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(134, 113);
            this.pb.TabIndex = 18;
            this.pb.TabStop = false;
            // 
            // lblOperatie
            // 
            this.lblOperatie.AutoSize = true;
            this.lblOperatie.Location = new System.Drawing.Point(729, 90);
            this.lblOperatie.Name = "lblOperatie";
            this.lblOperatie.Size = new System.Drawing.Size(31, 13);
            this.lblOperatie.TabIndex = 19;
            this.lblOperatie.Text = "lblOp";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(386, 85);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 20;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // pacientiBindingSource1
            // 
            this.pacientiBindingSource1.DataMember = "Pacienti";
            this.pacientiBindingSource1.DataSource = this.dataSet2;
            // 
            // FormPacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.lblOperatie);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.txtIdPacient);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNrTelefon);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtSpImagine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "FormPacienti";
            this.Text = "FormPacienti";
            this.Load += new System.EventHandler(this.FormPacienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSpImagine;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtNrTelefon;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtIdPacient;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label lblOperatie;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private DataSet2TableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.BindingSource pacientiBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spPozaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
    }
}