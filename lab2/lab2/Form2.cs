using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        LinkedList<Persona> lista = new LinkedList<Persona>();
        LogGeografia geografia = new LogGeografia();
        List<int> listaTel = new List<int>();

        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private List<Persona> listaPersonas()
        {
            return lista.ToList();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona();
                persona.cedula = txtCedula.Text;
                persona.nombre = txtNombre.Text;
                persona.apellido1 = txtApellido1.Text;
                persona.apellido2 = txtApellido2.Text;
                persona.fechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Value.ToString("dd/MM/yyyy"));
                persona.edad = persona.calculaEdad();
                persona.estado = cbxEstado.SelectedItem.ToString();
                persona.telefonos = capturar();
                persona.provincia = cbxProvincias.SelectedItem.ToString();
                persona.canton = cbxCantones.SelectedItem.ToString();
                lista.AddLast(persona);
                limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            listaTelefonos.Items.Clear();
        }

        private List<int> capturar()
        {
            foreach (String s in listaTelefonos.Items)
            {
                listaTel.Add(int.Parse(s));

            }
            return listaTel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listaTelefonos.Items.Add(txtTelefono.Text);
            txtTelefono.Text = "";
        }
        private void LProvincias()
        {
            List<Geografia> provincia = geografia.listadoProvincia(1);
            cbxProvincias.DataSource = provincia;
            cbxProvincias.ValueMember = "id";
            cbxProvincias.DisplayMember = "nombre";
        }

        private void LCanton()
        {
            cbxCantones.DataSource = null;
            String provincia = cbxProvincias.SelectedValue.ToString();
            int dato = int.Parse(provincia);
            List<Geografia> canton = geografia.listadoCanton(2, dato);
            cbxCantones.DataSource = canton;
            cbxCantones.ValueMember = "id";
            cbxCantones.DisplayMember = "nombre";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LProvincias();
            
            
        }

        

        private void cbxProvincias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LCanton();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = listaPersonas();
        }

        
    }
}
