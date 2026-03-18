using BE;
using Seguridad;
using Seguridad.Composite;
using Seguridad.MultiIdioma;
using Seguridad.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DIPLOMA.Negocio
{
    public partial class Ventasfrm : Form
    {
        public Ventasfrm()
        {
            InitializeComponent();
        }
        public void enlazar()
        {
          
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorped.JoinsCobros();
            estilizargrid();

        }
        public void TraerCL()
        {

            var clientes = gestorCL.listar()// List<Cliente> con IdCliente, Nombre
                            .OrderBy(c => c.Nombre)
                            .ToList();
            clientes.Insert(0, new BE.Maestros.Clientes { Idcl = 0, Nombre = "(Todos)" });
            comboBox2.DisplayMember= "nombre";
            comboBox2.ValueMember = "Idcl";
            comboBox2.DataSource = clientes;
            comboBox2.SelectedIndex = 0;


        }
        private void Ventasfrm_Load(object sender, EventArgs e)
        {
            
            enlazar();
            TraerCL();
            comboBox1.DataSource = estdos.listarestados();
            comboBox1.DisplayMember = "Descrip"; // Se mostrará la descripción en el ComboBox
            comboBox1.ValueMember = "Idestado";
            Traducir(); 
        }

        BE.Negocio.Pedido_Cab cab = new BE.Negocio.Pedido_Cab();
        BE.Auxiliares.Aux_JoinsNegocio join=new BE.Auxiliares.Aux_JoinsNegocio();
        BE.Maestros.Clientes CL=new BE.Maestros.Clientes();
        BLL.Maestros.Clientes gestorCL = new BLL.Maestros.Clientes();
        BLL.Negocio.Pedidos gestorped = new BLL.Negocio.Pedidos();
        BLL.Estado estdos = new BLL.Estado();
        BLL.Traductor tradu = new BLL.Traductor();

        public void estilizargrid()
        {
            dataGridView1.Columns["ID_pedido"].Name = "Pedido";
        }

        private void button2_Click(object sender, EventArgs e)//buscar
        {
           
            var datos = gestorped.JoinsCobros();
            var q = datos.AsEnumerable();

            if (int.TryParse(textBox1.Text, out int id))
                q = q.Where(x => x.ID_pedido == id);



            if (radioButton1.Checked)
            {
                // Si tu DTO tiene IdEstado (int)
                q = q.Where(x =>
                       (x.Estado == "Creado" || x.Estado== "Pagado")
                    
                );
            }



            var clienteSel = comboBox2.Text?.Trim();
            if (!string.IsNullOrEmpty(clienteSel) && !string.Equals(clienteSel, "(Todos)", StringComparison.OrdinalIgnoreCase))
                q = q.Where(x => string.Equals(x.Cliente, clienteSel, StringComparison.OrdinalIgnoreCase));



            if (dateTimePicker1.Checked)
                q = q.Where(x => x.Generado >= dateTimePicker1.Value.Date);

            if (dateTimePicker2.Checked)
                q = q.Where(x => x.Generado <= dateTimePicker2.Value.Date.AddDays(1).AddTicks(-1));

            dataGridView1.DataSource = q.OrderByDescending(x => x.Generado)
                                        .ThenByDescending(x => x.ID_pedido)
                                        .ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BE.Negocio.Pedido_Cab cabe = new BE.Negocio.Pedido_Cab();
            foreach (BE.Auxiliares.Aux_JoinsNegocio item in gestorped.JoinsCobros())
            {
                if (textBox1.Text == item.ID_pedido.ToString())
                {
                    cabe.ID_pedido = item.ID_pedido;
                    cabe.Estado = comboBox1.SelectedIndex;
                    cabe.Fechaact = DateTime.Now;

                    gestorped.editarestado(cabe);
                    MessageBox.Show("El cambio fue registrado");
                    enlazar();
                    textBox1.Clear();
                    comboBox1.SelectedIndex = -1;
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                join=(BE.Auxiliares.Aux_JoinsNegocio)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                

                textBox1.Text = join.ID_pedido.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void limpiar()
        {
            textBox1.Clear();
            radioButton1.Checked=false;
            dateTimePicker1.Checked=false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            enlazar();
            limpiar();

        }

        public void Traducir()
        {
            Iidioma idioma = null;

            if (SingletonSesion.Instancia.IsLogged())
                idioma = SingletonSesion.Instancia.Usuario.Idioma;
            var traducciones = tradu.ObtenerTraducciones(idioma);

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (traducciones.ContainsKey(col.Name))
                    col.HeaderText = traducciones[col.Name].Texto;
            }


            if (label1.Tag != null && traducciones.ContainsKey(label1.Tag.ToString()))
                label1.Text = traducciones[label1.Tag.ToString()].Texto;

            if (label2.Tag != null && traducciones.ContainsKey(label2.Tag.ToString()))
                label2.Text = traducciones[label2.Tag.ToString()].Texto;

            if (label3.Tag != null && traducciones.ContainsKey(label3.Tag.ToString()))
                label3.Text = traducciones[label3.Tag.ToString()].Texto;

            if (label4.Tag != null && traducciones.ContainsKey(label4.Tag.ToString()))
                label4.Text = traducciones[label4.Tag.ToString()].Texto;

            if (label5.Tag != null && traducciones.ContainsKey(label5.Tag.ToString()))
                label5.Text = traducciones[label5.Tag.ToString()].Texto;

            if (radioButton1.Tag != null && traducciones.ContainsKey(radioButton1.Tag.ToString()))
                radioButton1.Text = traducciones[radioButton1.Tag.ToString()].Texto;

            if (button1.Tag != null && traducciones.ContainsKey(button1.Tag.ToString()))
                button1.Text = traducciones[button1.Tag.ToString()].Texto;

            if (button2.Tag != null && traducciones.ContainsKey(button2.Tag.ToString()))
                button2.Text = traducciones[button2.Tag.ToString()].Texto;

            if (button3.Tag != null && traducciones.ContainsKey(button3.Tag.ToString()))
                button3.Text = traducciones[button3.Tag.ToString()].Texto;
        }
    }
}
