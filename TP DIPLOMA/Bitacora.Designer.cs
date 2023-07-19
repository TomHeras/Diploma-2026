
namespace TP_DIPLOMA
{
    partial class Bitacora
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbusuarios = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.checkcriticidad = new System.Windows.Forms.CheckBox();
            this.checkusuarios = new System.Windows.Forms.CheckBox();
            this.checkmodulos = new System.Windows.Forms.CheckBox();
            this.checkdias = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 267);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(866, 489);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LOGIN",
            "LOGOUT",
            "Facturas",
            "Compras"});
            this.comboBox1.Location = new System.Drawing.Point(55, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // cmbusuarios
            // 
            this.cmbusuarios.FormattingEnabled = true;
            this.cmbusuarios.Location = new System.Drawing.Point(55, 125);
            this.cmbusuarios.Name = "cmbusuarios";
            this.cmbusuarios.Size = new System.Drawing.Size(163, 24);
            this.cmbusuarios.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Baja",
            "Alta",
            "Media"});
            this.comboBox3.Location = new System.Drawing.Point(55, 196);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(163, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(469, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar registros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkcriticidad
            // 
            this.checkcriticidad.AutoSize = true;
            this.checkcriticidad.Location = new System.Drawing.Point(55, 169);
            this.checkcriticidad.Name = "checkcriticidad";
            this.checkcriticidad.Size = new System.Drawing.Size(88, 21);
            this.checkcriticidad.TabIndex = 6;
            this.checkcriticidad.Text = "Criticidad";
            this.checkcriticidad.UseVisualStyleBackColor = true;
            // 
            // checkusuarios
            // 
            this.checkusuarios.AutoSize = true;
            this.checkusuarios.Location = new System.Drawing.Point(55, 98);
            this.checkusuarios.Name = "checkusuarios";
            this.checkusuarios.Size = new System.Drawing.Size(86, 21);
            this.checkusuarios.TabIndex = 7;
            this.checkusuarios.Text = "Usuarios";
            this.checkusuarios.UseVisualStyleBackColor = true;
            // 
            // checkmodulos
            // 
            this.checkmodulos.AutoSize = true;
            this.checkmodulos.Location = new System.Drawing.Point(55, 28);
            this.checkmodulos.Name = "checkmodulos";
            this.checkmodulos.Size = new System.Drawing.Size(83, 21);
            this.checkmodulos.TabIndex = 8;
            this.checkmodulos.Text = "Modulos";
            this.checkmodulos.UseVisualStyleBackColor = true;
            // 
            // checkdias
            // 
            this.checkdias.AutoSize = true;
            this.checkdias.Location = new System.Drawing.Point(368, 28);
            this.checkdias.Name = "checkdias";
            this.checkdias.Size = new System.Drawing.Size(69, 21);
            this.checkdias.TabIndex = 9;
            this.checkdias.Text = "Fecha";
            this.checkdias.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(469, 115);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasta";
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 764);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.checkdias);
            this.Controls.Add(this.checkmodulos);
            this.Controls.Add(this.checkusuarios);
            this.Controls.Add(this.checkcriticidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cmbusuarios);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bitacora";
            this.Text = "Desde";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbusuarios;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkcriticidad;
        private System.Windows.Forms.CheckBox checkusuarios;
        private System.Windows.Forms.CheckBox checkmodulos;
        private System.Windows.Forms.CheckBox checkdias;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}