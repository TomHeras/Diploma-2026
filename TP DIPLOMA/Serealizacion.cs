using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DIPLOMA
{
    public partial class Serealizacion : Form
    {
        public Serealizacion()
        {
            InitializeComponent();
        }
        string CarpetaB;
        string ArchivoB;

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                FolderBrowserDialog Carpeta = new FolderBrowserDialog();


                OpenFileDialog Archivo = new OpenFileDialog();

                if (Archivo.ShowDialog() == DialogResult.OK)
                {
                    ArchivoB = Archivo.FileName;

                    textBox1.Text = ArchivoB;
                }
            }
        }
        void enlazar()
        {

            DataSet DS = new DataSet();
           
            
            if (textBox1.Text== "C:\\Users\\BX657MT\\OneDrive - EY\\Desktop\\UAI\\proveedores.xml")
            {
                DS.ReadXml("C:\\Users\\BX657MT\\OneDrive - EY\\Desktop\\UAI\\proveedores.xml");
                dataGridView1.DataSource = DS;
                dataGridView1.DataMember = "proveedores";
            }
            else if (textBox1.Text == "C:\\Users\\BX657MT\\OneDrive - EY\\Desktop\\UAI\\Compras.xml")
            {
                DS.ReadXml("C:\\Users\\BX657MT\\OneDrive - EY\\Desktop\\UAI\\Compras.xml");
                dataGridView1.DataSource = DS;
                dataGridView1.DataMember = "Compras";
            }
            else if (textBox1.Text == "C:\\Users\\BX657MT\\OneDrive - EY\\Desktop\\UAI\\ventas.xml")
            {
                DS.ReadXml("C:\\Users\\BX657MT\\OneDrive - EY\\Desktop\\UAI\\ventas.xml");
                dataGridView1.DataSource = DS;
                dataGridView1.DataMember = "ventas";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                enlazar();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
