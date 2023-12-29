namespace ProiectFinal.ImaginiPacienti
{
    partial class FormInternari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idInternareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInternareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExternareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new ProiectFinal.DataSet2();
            this.internariTableAdapter = new ProiectFinal.DataSet2TableAdapters.InternariTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.denumireServiciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServiciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriviciiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriviciiTableAdapter = new ProiectFinal.DataSet2TableAdapters.SeriviciiTableAdapter();
            this.btnAdaugaServiciu = new System.Windows.Forms.Button();
            this.btnModificaServicii = new System.Windows.Forms.Button();
            this.idInternarePicker = new System.Windows.Forms.TextBox();
            this.comboPacient = new System.Windows.Forms.ComboBox();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientiTableAdapter = new ProiectFinal.DataSet2TableAdapters.PacientiTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblPacient = new System.Windows.Forms.Label();
            this.lblDataInternare = new System.Windows.Forms.Label();
            this.lblDataExternare = new System.Windows.Forms.Label();
            this.txtSectie = new System.Windows.Forms.TextBox();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.lblSectie = new System.Windows.Forms.Label();
            this.lblDiagnostic = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnAdaugaInternare = new System.Windows.Forms.Button();
            this.btnModificaInternare = new System.Windows.Forms.Button();
            this.btnStergeInternare = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.lblTotalPlata = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblLei = new System.Windows.Forms.Label();
            this.dataTable1TableAdapter = new ProiectFinal.DataSet2TableAdapters.DataTable1TableAdapter();
            this.lblOperatie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriviciiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInternareDataGridViewTextBoxColumn,
            this.idPacientDataGridViewTextBoxColumn,
            this.dataInternareDataGridViewTextBoxColumn,
            this.dataExternareDataGridViewTextBoxColumn,
            this.sectieDataGridViewTextBoxColumn,
            this.diagnosticDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.internariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idInternareDataGridViewTextBoxColumn
            // 
            this.idInternareDataGridViewTextBoxColumn.DataPropertyName = "IdInternare";
            this.idInternareDataGridViewTextBoxColumn.HeaderText = "IdInternare";
            this.idInternareDataGridViewTextBoxColumn.Name = "idInternareDataGridViewTextBoxColumn";
            this.idInternareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPacientDataGridViewTextBoxColumn
            // 
            this.idPacientDataGridViewTextBoxColumn.DataPropertyName = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.HeaderText = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.Name = "idPacientDataGridViewTextBoxColumn";
            // 
            // dataInternareDataGridViewTextBoxColumn
            // 
            this.dataInternareDataGridViewTextBoxColumn.DataPropertyName = "DataInternare";
            this.dataInternareDataGridViewTextBoxColumn.HeaderText = "DataInternare";
            this.dataInternareDataGridViewTextBoxColumn.Name = "dataInternareDataGridViewTextBoxColumn";
            // 
            // dataExternareDataGridViewTextBoxColumn
            // 
            this.dataExternareDataGridViewTextBoxColumn.DataPropertyName = "DataExternare";
            this.dataExternareDataGridViewTextBoxColumn.HeaderText = "DataExternare";
            this.dataExternareDataGridViewTextBoxColumn.Name = "dataExternareDataGridViewTextBoxColumn";
            // 
            // sectieDataGridViewTextBoxColumn
            // 
            this.sectieDataGridViewTextBoxColumn.DataPropertyName = "Sectie";
            this.sectieDataGridViewTextBoxColumn.HeaderText = "Sectie";
            this.sectieDataGridViewTextBoxColumn.Name = "sectieDataGridViewTextBoxColumn";
            // 
            // diagnosticDataGridViewTextBoxColumn
            // 
            this.diagnosticDataGridViewTextBoxColumn.DataPropertyName = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.HeaderText = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.Name = "diagnosticDataGridViewTextBoxColumn";
            // 
            // internariBindingSource
            // 
            this.internariBindingSource.DataMember = "Internari";
            this.internariBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // internariTableAdapter
            // 
            this.internariTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireServiciDataGridViewTextBoxColumn,
            this.idServiciDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dataTable1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(55, 221);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(541, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // denumireServiciDataGridViewTextBoxColumn
            // 
            this.denumireServiciDataGridViewTextBoxColumn.DataPropertyName = "DenumireServici";
            this.denumireServiciDataGridViewTextBoxColumn.HeaderText = "DenumireServici";
            this.denumireServiciDataGridViewTextBoxColumn.Name = "denumireServiciDataGridViewTextBoxColumn";
            // 
            // idServiciDataGridViewTextBoxColumn
            // 
            this.idServiciDataGridViewTextBoxColumn.DataPropertyName = "IdServici";
            this.idServiciDataGridViewTextBoxColumn.HeaderText = "IdServici";
            this.idServiciDataGridViewTextBoxColumn.Name = "idServiciDataGridViewTextBoxColumn";
            this.idServiciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarifDataGridViewTextBoxColumn
            // 
            this.tarifDataGridViewTextBoxColumn.DataPropertyName = "Tarif";
            this.tarifDataGridViewTextBoxColumn.HeaderText = "Tarif";
            this.tarifDataGridViewTextBoxColumn.Name = "tarifDataGridViewTextBoxColumn";
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet2;
            // 
            // seriviciiBindingSource
            // 
            this.seriviciiBindingSource.DataMember = "Serivicii";
            this.seriviciiBindingSource.DataSource = this.dataSet2;
            // 
            // seriviciiTableAdapter
            // 
            this.seriviciiTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdaugaServiciu
            // 
            this.btnAdaugaServiciu.Location = new System.Drawing.Point(602, 251);
            this.btnAdaugaServiciu.Name = "btnAdaugaServiciu";
            this.btnAdaugaServiciu.Size = new System.Drawing.Size(96, 36);
            this.btnAdaugaServiciu.TabIndex = 2;
            this.btnAdaugaServiciu.Text = "Adauga serviciu";
            this.btnAdaugaServiciu.UseVisualStyleBackColor = true;
            // 
            // btnModificaServicii
            // 
            this.btnModificaServicii.Location = new System.Drawing.Point(602, 293);
            this.btnModificaServicii.Name = "btnModificaServicii";
            this.btnModificaServicii.Size = new System.Drawing.Size(96, 40);
            this.btnModificaServicii.TabIndex = 3;
            this.btnModificaServicii.Text = "Modifica servicii";
            this.btnModificaServicii.UseVisualStyleBackColor = true;
            // 
            // idInternarePicker
            // 
            this.idInternarePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.internariBindingSource, "IdInternare", true));
            this.idInternarePicker.Location = new System.Drawing.Point(602, 223);
            this.idInternarePicker.Name = "idInternarePicker";
            this.idInternarePicker.Size = new System.Drawing.Size(96, 20);
            this.idInternarePicker.TabIndex = 5;
            this.idInternarePicker.TextChanged += new System.EventHandler(this.idInternarePicker_TextChanged);
            // 
            // comboPacient
            // 
            this.comboPacient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.internariBindingSource, "IdPacient", true));
            this.comboPacient.DataSource = this.pacientiBindingSource;
            this.comboPacient.DisplayMember = "NumePacient";
            this.comboPacient.FormattingEnabled = true;
            this.comboPacient.Location = new System.Drawing.Point(783, 65);
            this.comboPacient.Name = "comboPacient";
            this.comboPacient.Size = new System.Drawing.Size(121, 21);
            this.comboPacient.TabIndex = 6;
            this.comboPacient.ValueMember = "IdPacient";
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.dataSet2;
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.internariBindingSource, "DataInternare", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(783, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.internariBindingSource, "DataExternare", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(783, 118);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // lblPacient
            // 
            this.lblPacient.AutoSize = true;
            this.lblPacient.Location = new System.Drawing.Point(716, 65);
            this.lblPacient.Name = "lblPacient";
            this.lblPacient.Size = new System.Drawing.Size(43, 13);
            this.lblPacient.TabIndex = 9;
            this.lblPacient.Text = "Pacient";
            // 
            // lblDataInternare
            // 
            this.lblDataInternare.AutoSize = true;
            this.lblDataInternare.Location = new System.Drawing.Point(704, 92);
            this.lblDataInternare.Name = "lblDataInternare";
            this.lblDataInternare.Size = new System.Drawing.Size(74, 13);
            this.lblDataInternare.TabIndex = 10;
            this.lblDataInternare.Text = "Data internare";
            // 
            // lblDataExternare
            // 
            this.lblDataExternare.AutoSize = true;
            this.lblDataExternare.Location = new System.Drawing.Point(704, 118);
            this.lblDataExternare.Name = "lblDataExternare";
            this.lblDataExternare.Size = new System.Drawing.Size(77, 13);
            this.lblDataExternare.TabIndex = 11;
            this.lblDataExternare.Text = "Data externare";
            // 
            // txtSectie
            // 
            this.txtSectie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.internariBindingSource, "Sectie", true));
            this.txtSectie.Location = new System.Drawing.Point(783, 144);
            this.txtSectie.Name = "txtSectie";
            this.txtSectie.Size = new System.Drawing.Size(121, 20);
            this.txtSectie.TabIndex = 12;
            // 
            // txtDiagnostic
            // 
            this.txtDiagnostic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.internariBindingSource, "Diagnostic", true));
            this.txtDiagnostic.Location = new System.Drawing.Point(783, 170);
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.Size = new System.Drawing.Size(121, 20);
            this.txtDiagnostic.TabIndex = 13;
            // 
            // lblSectie
            // 
            this.lblSectie.AutoSize = true;
            this.lblSectie.Location = new System.Drawing.Point(724, 144);
            this.lblSectie.Name = "lblSectie";
            this.lblSectie.Size = new System.Drawing.Size(37, 13);
            this.lblSectie.TabIndex = 14;
            this.lblSectie.Text = "Sectie";
            // 
            // lblDiagnostic
            // 
            this.lblDiagnostic.AutoSize = true;
            this.lblDiagnostic.Location = new System.Drawing.Point(716, 170);
            this.lblDiagnostic.Name = "lblDiagnostic";
            this.lblDiagnostic.Size = new System.Drawing.Size(57, 13);
            this.lblDiagnostic.TabIndex = 15;
            this.lblDiagnostic.Text = "Diagnostic";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(746, 196);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(96, 36);
            this.btnConfirma.TabIndex = 16;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnAdaugaInternare
            // 
            this.btnAdaugaInternare.Location = new System.Drawing.Point(55, 12);
            this.btnAdaugaInternare.Name = "btnAdaugaInternare";
            this.btnAdaugaInternare.Size = new System.Drawing.Size(96, 36);
            this.btnAdaugaInternare.TabIndex = 17;
            this.btnAdaugaInternare.Text = "Adauga internare";
            this.btnAdaugaInternare.UseVisualStyleBackColor = true;
            this.btnAdaugaInternare.Click += new System.EventHandler(this.btnAdaugaInternare_Click);
            // 
            // btnModificaInternare
            // 
            this.btnModificaInternare.Location = new System.Drawing.Point(157, 12);
            this.btnModificaInternare.Name = "btnModificaInternare";
            this.btnModificaInternare.Size = new System.Drawing.Size(96, 36);
            this.btnModificaInternare.TabIndex = 18;
            this.btnModificaInternare.Text = "Modifica internare";
            this.btnModificaInternare.UseVisualStyleBackColor = true;
            this.btnModificaInternare.Click += new System.EventHandler(this.btnModificaInternare_Click);
            // 
            // btnStergeInternare
            // 
            this.btnStergeInternare.Location = new System.Drawing.Point(259, 12);
            this.btnStergeInternare.Name = "btnStergeInternare";
            this.btnStergeInternare.Size = new System.Drawing.Size(96, 36);
            this.btnStergeInternare.TabIndex = 19;
            this.btnStergeInternare.Text = "Sterge internare";
            this.btnStergeInternare.UseVisualStyleBackColor = true;
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(848, 196);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(96, 36);
            this.btnRenunta.TabIndex = 20;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // lblTotalPlata
            // 
            this.lblTotalPlata.AutoSize = true;
            this.lblTotalPlata.Location = new System.Drawing.Point(716, 320);
            this.lblTotalPlata.Name = "lblTotalPlata";
            this.lblTotalPlata.Size = new System.Drawing.Size(75, 13);
            this.lblTotalPlata.TabIndex = 21;
            this.lblTotalPlata.Text = "Total de plata:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(797, 317);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(45, 20);
            this.txtTotal.TabIndex = 22;
            // 
            // lblLei
            // 
            this.lblLei.AutoSize = true;
            this.lblLei.Location = new System.Drawing.Point(848, 320);
            this.lblLei.Name = "lblLei";
            this.lblLei.Size = new System.Drawing.Size(20, 13);
            this.lblLei.TabIndex = 23;
            this.lblLei.Text = "lei.";
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // lblOperatie
            // 
            this.lblOperatie.AutoSize = true;
            this.lblOperatie.Location = new System.Drawing.Point(780, 35);
            this.lblOperatie.Name = "lblOperatie";
            this.lblOperatie.Size = new System.Drawing.Size(31, 13);
            this.lblOperatie.TabIndex = 24;
            this.lblOperatie.Text = "lblOp";
            // 
            // FormInternari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.lblOperatie);
            this.Controls.Add(this.lblLei);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotalPlata);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnStergeInternare);
            this.Controls.Add(this.btnModificaInternare);
            this.Controls.Add(this.btnAdaugaInternare);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.lblDiagnostic);
            this.Controls.Add(this.lblSectie);
            this.Controls.Add(this.txtDiagnostic);
            this.Controls.Add(this.txtSectie);
            this.Controls.Add(this.lblDataExternare);
            this.Controls.Add(this.lblDataInternare);
            this.Controls.Add(this.lblPacient);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboPacient);
            this.Controls.Add(this.idInternarePicker);
            this.Controls.Add(this.btnModificaServicii);
            this.Controls.Add(this.btnAdaugaServiciu);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormInternari";
            this.Text = "FormInternari";
            this.Load += new System.EventHandler(this.FormInternari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriviciiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource internariBindingSource;
        private DataSet2TableAdapters.InternariTableAdapter internariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInternareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInternareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExternareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource seriviciiBindingSource;
        private DataSet2TableAdapters.SeriviciiTableAdapter seriviciiTableAdapter;
        private System.Windows.Forms.Button btnAdaugaServiciu;
        private System.Windows.Forms.Button btnModificaServicii;
        private System.Windows.Forms.TextBox idInternarePicker;
        private System.Windows.Forms.ComboBox comboPacient;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private DataSet2TableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblPacient;
        private System.Windows.Forms.Label lblDataInternare;
        private System.Windows.Forms.Label lblDataExternare;
        private System.Windows.Forms.TextBox txtSectie;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.Label lblSectie;
        private System.Windows.Forms.Label lblDiagnostic;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnAdaugaInternare;
        private System.Windows.Forms.Button btnModificaInternare;
        private System.Windows.Forms.Button btnStergeInternare;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Label lblTotalPlata;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblLei;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireServiciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblOperatie;
    }
}