using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeGastosPersonales
{
    public partial class FrmIngresar : Form
    {
        public int Metodo_id { get; set; }
        public int Tipo_id { get; set; }
        public FrmIngresar()
        {
            InitializeComponent();
        }
        public FrmIngresar(int metodo_id, int tipo_id)
        {
            InitializeComponent();
            this.Metodo_id = metodo_id;
            this.Tipo_id = tipo_id;
            Motivos();
            this.cboCategoria.SelectedIndex = 0;
            this.CenterToScreen();
        }

        public FrmIngresar(int id)
        {
            InitializeComponent();
            Motivos();
            this.cboCategoria.SelectedIndex = 0;
            this.CenterToScreen();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (NoVacios() && ValidarNumeros())
            {
                try
                {
                    TransaccionesDB transaccionesDB = new TransaccionesDB();
                    transaccionesDB.Add(dtpFecha.Value, int.Parse(cboCategoria.SelectedIndex.ToString() + 1), decimal.Parse(txtMonto.Text), this.Metodo_id, this.Tipo_id, txtDescripcion.Text);
                    MessageBox.Show("Transacción agregada correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }
        }
        public bool NoVacios()
        {
            bool OK = true;
            if (txtMonto.Text == string.Empty)
            {
                errorProvider1.SetError(txtMonto, "No puede estar vacio >:(");
            }
            return OK;
        }
        public bool ValidarNumeros()
        {
            bool ok = true;
            if (!(decimal.TryParse(txtMonto.Text, out decimal c)))
            {
                errorProvider1.SetError(txtMonto, "Solo se permiten números");
                ok = false;
            }
            return ok;
        }
        private void Motivos()
        {
            TransaccionesDB transaccionesDB = new TransaccionesDB();

            cboCategoria.DataSource = transaccionesDB.GetMotivos();
            cboCategoria.DisplayMember = "Nombre"; //el que se mostrara
            cboCategoria.ValueMember = "Id"; //se seleccionara como valor seleccionado
        }
        private void FrmIngresar_Load(object sender, EventArgs e)
        {
            
        }

    }
}
