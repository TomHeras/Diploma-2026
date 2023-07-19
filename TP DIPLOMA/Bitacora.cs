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
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }
        BLL.Bitacora GestorBitacora = new BLL.Bitacora();
        private void Bitacora_Load(object sender, EventArgs e)
        {
            enlazar();
            
        }
        BE.BitacoraCAbmios bitacora2 = new BE.BitacoraCAbmios();
        BLL.Bitacora gestorbitacora = new BLL.Bitacora();
        BLL.Usuarios usugest = new BLL.Usuarios();
        BE.Usuario usus = new BE.Usuario();
        BLL.Maestros.Productos Productos = new BLL.Maestros.Productos();
        BLL.Negocio.Pedidos pedidos = new BLL.Negocio.Pedidos();
        public  void enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GestorBitacora.Listar();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            foreach (BE.Usuario item in usugest.Listarnicks())
            {

                cmbusuarios.Items.Add(item.Nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkdias.Checked == true && checkusuarios.Checked == false && checkmodulos.Checked == false && checkcriticidad.Checked == false)
                {
                    string fecha1 = dateTimePicker1.Value.ToString("MM/dd/yyyy HH:mm:ss");
                    string fecha2 = dateTimePicker2.Value.ToString("MM/dd/yyyy HH:mm:ss");

                    DateTime desde, hasta;
                    hasta = DateTime.Parse(fecha2);
                    desde = DateTime.Parse(fecha1);
                    var listardetcompra = gestorbitacora.Listar().Where(x => x.Fecha >= desde).ToList().Where(x => x.Fecha <= hasta).ToList();
                    dataGridView1.DataSource = listardetcompra;
                }
                else if (checkdias.Checked == false && checkusuarios.Checked == false && checkmodulos.Checked == false && checkcriticidad.Checked == true)
                {
                    string criticidad = comboBox3.SelectedItem.ToString();//int.Parse(cmbusuarios.SelectedIndex.ToString());

                    //if (criticidad == "Baja")
                    //{
                    //    criticidad = " Baja";
                    //}
                    //else if (criticidad == "Alta")
                    //{
                    //    criticidad = " Alta";
                    //}
                    //else
                    //{
                    //    criticidad = " Media";
                    //}
                    var listardetcompra = gestorbitacora.Listar().Where(x => x.Criticidad == criticidad).ToList();
                    dataGridView1.DataSource = listardetcompra;
                }
                else if (checkdias.Checked == false && checkusuarios.Checked == true && checkmodulos.Checked == false && checkcriticidad.Checked == false)
                {
                    var listardetcompra = gestorbitacora.Listar().Where(x => x.NickUsuario == cmbusuarios.SelectedItem.ToString()).ToList();
                    dataGridView1.DataSource = listardetcompra;
                }
                else if (checkdias.Checked == false && checkusuarios.Checked == false && checkmodulos.Checked == true && checkcriticidad.Checked == false)
                {
                    var listardetcompra = gestorbitacora.Listar().Where(x => x.Modulo == comboBox1.SelectedItem.ToString()).ToList();
                    dataGridView1.DataSource = listardetcompra;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
