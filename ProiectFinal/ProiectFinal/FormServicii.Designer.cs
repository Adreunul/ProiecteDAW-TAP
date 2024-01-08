namespace ProiectFinal
{
    partial class FormServicii
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
            this.btnStergere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idServiciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireServiciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriviciiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new ProiectFinal.DataSet2();
            this.seriviciiTableAdapter = new ProiectFinal.DataSet2TableAdapters.SeriviciiTableAdapter();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbld = new System.Windows.Forms.Label();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.lblUM = new System.Windows.Forms.Label();
            this.lblTarif = new System.Windows.Forms.Label();
            this.lblOperatie = new System.Windows.Forms.Label();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriviciiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(30, 37);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 0;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(192, 37);
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
            this.idServiciDataGridViewTextBoxColumn,
            this.denumireServiciDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seriviciiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // idServiciDataGridViewTextBoxColumn
            // 
            this.idServiciDataGridViewTextBoxColumn.DataPropertyName = "IdServici";
            this.idServiciDataGridViewTextBoxColumn.HeaderText = "IdServici";
            this.idServiciDataGridViewTextBoxColumn.Name = "idServiciDataGridViewTextBoxColumn";
            this.idServiciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denumireServiciDataGridViewTextBoxColumn
            // 
            this.denumireServiciDataGridViewTextBoxColumn.DataPropertyName = "DenumireServici";
            this.denumireServiciDataGridViewTextBoxColumn.HeaderText = "DenumireServici";
            this.denumireServiciDataGridViewTextBoxColumn.Name = "denumireServiciDataGridViewTextBoxColumn";
            this.denumireServiciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarifDataGridViewTextBoxColumn
            // 
            this.tarifDataGridViewTextBoxColumn.DataPropertyName = "Tarif";
            this.tarifDataGridViewTextBoxColumn.HeaderText = "Tarif";
            this.tarifDataGridViewTextBoxColumn.Name = "tarifDataGridViewTextBoxColumn";
            this.tarifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seriviciiBindingSource
            // 
            this.seriviciiBindingSource.DataMember = "Serivicii";
            this.seriviciiBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seriviciiTableAdapter
            // 
            this.seriviciiTableAdapter.ClearBeforeFill = true;
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(526, 122);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 20);
            this.txtDenumire.TabIndex = 4;
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(526, 148);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(100, 20);
            this.txtUM.TabIndex = 5;
            // 
            // txtTarif
            // 
            this.txtTarif.Location = new System.Drawing.Point(526, 174);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(100, 20);
            this.txtTarif.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriviciiBindingSource, "IdServici", true));
            this.txtId.Location = new System.Drawing.Point(526, 89);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(29, 20);
            this.txtId.TabIndex = 7;
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Location = new System.Drawing.Point(476, 95);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(18, 13);
            this.lbld.TabIndex = 8;
            this.lbld.Text = "ID";
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(468, 122);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(52, 13);
            this.lblDenumire.TabIndex = 9;
            this.lblDenumire.Text = "Denumire";
            // 
            // lblUM
            // 
            this.lblUM.AutoSize = true;
            this.lblUM.Location = new System.Drawing.Point(476, 148);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(24, 13);
            this.lblUM.TabIndex = 10;
            this.lblUM.Text = "UM";
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Location = new System.Drawing.Point(476, 174);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(28, 13);
            this.lblTarif.TabIndex = 11;
            this.lblTarif.Text = "Tarif";
            // 
            // lblOperatie
            // 
            this.lblOperatie.AutoSize = true;
            this.lblOperatie.Location = new System.Drawing.Point(523, 47);
            this.lblOperatie.Name = "lblOperatie";
            this.lblOperatie.Size = new System.Drawing.Size(31, 13);
            this.lblOperatie.TabIndex = 12;
            this.lblOperatie.Text = "lblOp";
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(480, 216);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 13;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(561, 216);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 14;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click_1);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(111, 37);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 1;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // FormServicii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 476);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.lblOperatie);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.lblUM);
            this.Controls.Add(this.lblDenumire);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.txtUM);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "FormServicii";
            this.Text = "FormServicii";
            this.Load += new System.EventHandler(this.FormServicii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriviciiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource seriviciiBindingSource;
        private DataSet2TableAdapters.SeriviciiTableAdapter seriviciiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireServiciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label lblUM;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.Label lblOperatie;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnModificare;
    }
}