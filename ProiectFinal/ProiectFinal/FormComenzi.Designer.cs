namespace ModelAlexandrescu
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
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.txtSpPoza = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(611, 167);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(86, 34);
            this.btnActualizare.TabIndex = 0;
            this.btnActualizare.Text = "Comanda noua";
            this.btnActualizare.UseVisualStyleBackColor = true;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(612, 207);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(85, 36);
            this.btnSalvare.TabIndex = 1;
            this.btnSalvare.Text = "Modificare comanda";
            this.btnSalvare.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 188);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(611, 249);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(85, 38);
            this.btnRenuntare.TabIndex = 5;
            this.btnRenuntare.Text = "Sterge comanda";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            // 
            // txtSpPoza
            // 
            this.txtSpPoza.Location = new System.Drawing.Point(611, 141);
            this.txtSpPoza.Name = "txtSpPoza";
            this.txtSpPoza.Size = new System.Drawing.Size(86, 20);
            this.txtSpPoza.TabIndex = 20;
            this.txtSpPoza.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(58, 326);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(639, 116);
            this.dataGridView2.TabIndex = 21;
            // 
            // FormInternari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 463);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtSpPoza);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Name = "FormInternari";
            this.Text = "Form Internari";
            this.Load += new System.EventHandler(this.FormInternari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.TextBox txtSpPoza;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}