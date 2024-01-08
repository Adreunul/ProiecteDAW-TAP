namespace ProiectFinal
{
    partial class FormAdaugaServiciu
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
            this.idServiciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireServiciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriviciiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new ProiectFinal.DataSet2();
            this.seriviciiTableAdapter = new ProiectFinal.DataSet2TableAdapters.SeriviciiTableAdapter();
            this.txtDenumireServiciu = new System.Windows.Forms.TextBox();
            this.lblDenumireServiciu = new System.Windows.Forms.Label();
            this.lblUM = new System.Windows.Forms.Label();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.lblTarif = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.txtIdServiciu = new System.Windows.Forms.TextBox();
            this.lblIdServiciu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriviciiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 0;
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
            // txtDenumireServiciu
            // 
            this.txtDenumireServiciu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriviciiBindingSource, "DenumireServici", true));
            this.txtDenumireServiciu.Location = new System.Drawing.Point(109, 29);
            this.txtDenumireServiciu.Name = "txtDenumireServiciu";
            this.txtDenumireServiciu.Size = new System.Drawing.Size(100, 20);
            this.txtDenumireServiciu.TabIndex = 1;
            this.txtDenumireServiciu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDenumireServiciu
            // 
            this.lblDenumireServiciu.AutoSize = true;
            this.lblDenumireServiciu.Location = new System.Drawing.Point(9, 29);
            this.lblDenumireServiciu.Name = "lblDenumireServiciu";
            this.lblDenumireServiciu.Size = new System.Drawing.Size(94, 13);
            this.lblDenumireServiciu.TabIndex = 2;
            this.lblDenumireServiciu.Text = "Denumire serviciu:";
            // 
            // lblUM
            // 
            this.lblUM.AutoSize = true;
            this.lblUM.Location = new System.Drawing.Point(76, 57);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(27, 13);
            this.lblUM.TabIndex = 3;
            this.lblUM.Text = "UM:";
            // 
            // txtUM
            // 
            this.txtUM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriviciiBindingSource, "UM", true));
            this.txtUM.Location = new System.Drawing.Point(109, 54);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(100, 20);
            this.txtUM.TabIndex = 4;
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Location = new System.Drawing.Point(259, 29);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(31, 13);
            this.lblTarif.TabIndex = 5;
            this.lblTarif.Text = "Tarif:";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(238, 57);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(52, 13);
            this.lblCantitate.TabIndex = 6;
            this.lblCantitate.Text = "Cantitate:";
            this.lblCantitate.Click += new System.EventHandler(this.lblCantitate_Click);
            // 
            // txtTarif
            // 
            this.txtTarif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriviciiBindingSource, "Tarif", true));
            this.txtTarif.Location = new System.Drawing.Point(296, 29);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(100, 20);
            this.txtTarif.TabIndex = 7;
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(296, 54);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(100, 20);
            this.txtCantitate.TabIndex = 8;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(510, 29);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 9;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(510, 57);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(75, 23);
            this.btnRenunta.TabIndex = 10;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            // 
            // txtIdServiciu
            // 
            this.txtIdServiciu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriviciiBindingSource, "IdServici", true));
            this.txtIdServiciu.Location = new System.Drawing.Point(480, 32);
            this.txtIdServiciu.Name = "txtIdServiciu";
            this.txtIdServiciu.Size = new System.Drawing.Size(24, 20);
            this.txtIdServiciu.TabIndex = 11;
            // 
            // lblIdServiciu
            // 
            this.lblIdServiciu.AutoSize = true;
            this.lblIdServiciu.Location = new System.Drawing.Point(455, 35);
            this.lblIdServiciu.Name = "lblIdServiciu";
            this.lblIdServiciu.Size = new System.Drawing.Size(19, 13);
            this.lblIdServiciu.TabIndex = 12;
            this.lblIdServiciu.Text = "Id:";
            // 
            // FormAdaugaServiciu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdServiciu);
            this.Controls.Add(this.txtIdServiciu);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.txtUM);
            this.Controls.Add(this.lblUM);
            this.Controls.Add(this.lblDenumireServiciu);
            this.Controls.Add(this.txtDenumireServiciu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAdaugaServiciu";
            this.Text = "FormAdaugaServiciu";
            this.Load += new System.EventHandler(this.FormAdaugaServiciu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriviciiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource seriviciiBindingSource;
        private DataSet2TableAdapters.SeriviciiTableAdapter seriviciiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireServiciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtDenumireServiciu;
        private System.Windows.Forms.Label lblDenumireServiciu;
        private System.Windows.Forms.Label lblUM;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.TextBox txtIdServiciu;
        private System.Windows.Forms.Label lblIdServiciu;
    }
}