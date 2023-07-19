
namespace TP_DIPLOMA
{
    partial class ABMusuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMusuarios));
            this.controlUsuario1 = new TP_DIPLOMA.ControlUsuario();
            this.controlUsuario2 = new TP_DIPLOMA.ControlUsuario();
            this.controlUsuario3 = new TP_DIPLOMA.ControlUsuario();
            this.controlUsuario4 = new TP_DIPLOMA.ControlUsuario();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblidcl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idiomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPMODELOSDataSet7 = new TP_DIPLOMA.TPMODELOSDataSet7();
            this.label1 = new System.Windows.Forms.Label();
            this.idiomaTableAdapter = new TP_DIPLOMA.TPMODELOSDataSet7TableAdapters.IdiomaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tPMODELOSDataSet12 = new TP_DIPLOMA.TPMODELOSDataSet12();
            this.idiomaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idiomaTableAdapter1 = new TP_DIPLOMA.TPMODELOSDataSet12TableAdapters.IdiomaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlUsuario1
            // 
            this.controlUsuario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario1.BackgroundImage")));
            this.controlUsuario1.Etiqueta = "Nombre";
            this.controlUsuario1.Location = new System.Drawing.Point(47, 38);
            this.controlUsuario1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlUsuario1.Name = "controlUsuario1";
            this.controlUsuario1.Size = new System.Drawing.Size(237, 55);
            this.controlUsuario1.TabIndex = 0;
            this.controlUsuario1.Texto = "";
            // 
            // controlUsuario2
            // 
            this.controlUsuario2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario2.BackgroundImage")));
            this.controlUsuario2.Etiqueta = "Nick";
            this.controlUsuario2.Location = new System.Drawing.Point(47, 86);
            this.controlUsuario2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlUsuario2.Name = "controlUsuario2";
            this.controlUsuario2.Size = new System.Drawing.Size(237, 55);
            this.controlUsuario2.TabIndex = 1;
            this.controlUsuario2.Texto = "";
            // 
            // controlUsuario3
            // 
            this.controlUsuario3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario3.BackgroundImage")));
            this.controlUsuario3.Etiqueta = "Contraseña";
            this.controlUsuario3.Location = new System.Drawing.Point(47, 137);
            this.controlUsuario3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlUsuario3.Name = "controlUsuario3";
            this.controlUsuario3.Size = new System.Drawing.Size(237, 55);
            this.controlUsuario3.TabIndex = 2;
            this.controlUsuario3.Texto = "";
            // 
            // controlUsuario4
            // 
            this.controlUsuario4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlUsuario4.BackgroundImage")));
            this.controlUsuario4.Etiqueta = "Mail";
            this.controlUsuario4.Location = new System.Drawing.Point(47, 199);
            this.controlUsuario4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlUsuario4.Name = "controlUsuario4";
            this.controlUsuario4.Size = new System.Drawing.Size(237, 55);
            this.controlUsuario4.TabIndex = 3;
            this.controlUsuario4.Texto = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(449, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(551, 475);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(103, 391);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblidcl
            // 
            this.lblidcl.AutoSize = true;
            this.lblidcl.Location = new System.Drawing.Point(121, 18);
            this.lblidcl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidcl.Name = "lblidcl";
            this.lblidcl.Size = new System.Drawing.Size(76, 17);
            this.lblidcl.TabIndex = 20;
            this.lblidcl.Text = ".................";
            this.lblidcl.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.idiomaBindingSource1;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 278);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // idiomaBindingSource
            // 
            this.idiomaBindingSource.DataMember = "Idioma";
            this.idiomaBindingSource.DataSource = this.tPMODELOSDataSet7;
            // 
            // tPMODELOSDataSet7
            // 
            this.tPMODELOSDataSet7.DataSetName = "TPMODELOSDataSet7";
            this.tPMODELOSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Idioma";
            // 
            // idiomaTableAdapter
            // 
            this.idiomaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(103, 455);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 28);
            this.button2.TabIndex = 23;
            this.button2.Text = "Modificar Usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Estado";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Activo",
            "Bloqueado"});
            this.comboBox2.Location = new System.Drawing.Point(137, 332);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // tPMODELOSDataSet12
            // 
            this.tPMODELOSDataSet12.DataSetName = "TPMODELOSDataSet12";
            this.tPMODELOSDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idiomaBindingSource1
            // 
            this.idiomaBindingSource1.DataMember = "Idioma";
            this.idiomaBindingSource1.DataSource = this.tPMODELOSDataSet12;
            // 
            // idiomaTableAdapter1
            // 
            this.idiomaTableAdapter1.ClearBeforeFill = true;
            // 
            // ABMusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblidcl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.controlUsuario4);
            this.Controls.Add(this.controlUsuario3);
            this.Controls.Add(this.controlUsuario2);
            this.Controls.Add(this.controlUsuario1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ABMusuarios";
            this.Text = "ABMusuarios";
            this.Load += new System.EventHandler(this.ABMusuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPMODELOSDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlUsuario controlUsuario1;
        private ControlUsuario controlUsuario2;
        private ControlUsuario controlUsuario3;
        private ControlUsuario controlUsuario4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblidcl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private TPMODELOSDataSet7 tPMODELOSDataSet7;
        private System.Windows.Forms.BindingSource idiomaBindingSource;
        private TPMODELOSDataSet7TableAdapters.IdiomaTableAdapter idiomaTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private TPMODELOSDataSet12 tPMODELOSDataSet12;
        private System.Windows.Forms.BindingSource idiomaBindingSource1;
        private TPMODELOSDataSet12TableAdapters.IdiomaTableAdapter idiomaTableAdapter1;
    }
}