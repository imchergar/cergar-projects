namespace DotNet3
{
    partial class PredmetiUnosStudenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotNet3DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotNet3DataSet1 = new DotNet3.DotNet3DataSet1();
            this.studentsTableAdapter = new DotNet3.DotNet3DataSet1TableAdapters.StudentsTableAdapter();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.predmetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotNet3DataSet3 = new DotNet3.DotNet3DataSet3();
            this.predmetsTableAdapter = new DotNet3.DotNet3DataSet3TableAdapters.PredmetsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNet3DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNet3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNet3DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Studenti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(353, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Predmeti";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.studentsBindingSource;
            this.listBox1.DisplayMember = "PunoIme";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            this.listBox1.ValueMember = "Id";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.dotNet3DataSet1BindingSource;
            // 
            // dotNet3DataSet1BindingSource
            // 
            this.dotNet3DataSet1BindingSource.DataSource = this.dotNet3DataSet1;
            this.dotNet3DataSet1BindingSource.Position = 0;
            // 
            // dotNet3DataSet1
            // 
            this.dotNet3DataSet1.DataSetName = "DotNet3DataSet1";
            this.dotNet3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.predmetsBindingSource;
            this.listBox2.DisplayMember = "Naziv";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(356, 94);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 4;
            this.listBox2.ValueMember = "Id";
            // 
            // predmetsBindingSource
            // 
            this.predmetsBindingSource.DataMember = "Predmets";
            this.predmetsBindingSource.DataSource = this.dotNet3DataSet3;
            // 
            // dotNet3DataSet3
            // 
            this.dotNet3DataSet3.DataSetName = "DotNet3DataSet3";
            this.dotNet3DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predmetsTableAdapter
            // 
            this.predmetsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PredmetiUnosStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "PredmetiUnosStudenta";
            this.Text = "PredmetiUnosStudenta";
            this.Load += new System.EventHandler(this.PredmetiUnosStudenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNet3DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNet3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNet3DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource dotNet3DataSet1BindingSource;
        private DotNet3DataSet1 dotNet3DataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DotNet3DataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.ListBox listBox2;
        private DotNet3DataSet3 dotNet3DataSet3;
        private System.Windows.Forms.BindingSource predmetsBindingSource;
        private DotNet3DataSet3TableAdapters.PredmetsTableAdapter predmetsTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}