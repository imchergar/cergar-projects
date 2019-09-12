namespace DotNet3
{
    partial class PredmetiStudenti
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dotNet3DataSet2 = new DotNet3.DotNet3DataSet2();
            this.studentPredmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentPredmetiTableAdapter = new DotNet3.DotNet3DataSet2TableAdapters.StudentPredmetiTableAdapter();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNet3DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPredmetiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.punoImeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentPredmetiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(131, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(494, 233);
            this.dataGridView1.TabIndex = 1;
            // 
            // dotNet3DataSet2
            // 
            this.dotNet3DataSet2.DataSetName = "DotNet3DataSet2";
            this.dotNet3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentPredmetiBindingSource
            // 
            this.studentPredmetiBindingSource.DataMember = "StudentPredmeti";
            this.studentPredmetiBindingSource.DataSource = this.dotNet3DataSet2;
            // 
            // studentPredmetiTableAdapter
            // 
            this.studentPredmetiTableAdapter.ClearBeforeFill = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // punoImeDataGridViewTextBoxColumn
            // 
            this.punoImeDataGridViewTextBoxColumn.DataPropertyName = "PunoIme";
            this.punoImeDataGridViewTextBoxColumn.HeaderText = "PunoIme";
            this.punoImeDataGridViewTextBoxColumn.Name = "punoImeDataGridViewTextBoxColumn";
            this.punoImeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PredmetiStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "PredmetiStudenti";
            this.Text = "PredmetiStudenti";
            this.Load += new System.EventHandler(this.PredmetiStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNet3DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPredmetiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DotNet3DataSet2 dotNet3DataSet2;
        private System.Windows.Forms.BindingSource studentPredmetiBindingSource;
        private DotNet3DataSet2TableAdapters.StudentPredmetiTableAdapter studentPredmetiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punoImeDataGridViewTextBoxColumn;
    }
}