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
        public int? Id { get; set; }
        public int Metodo_id { get; set; }
        public int Tipo_id { get; set; }
        //Agregar transacción a BD
        public FrmIngresar(int metodo_id, int tipo_id)
        {
            InitializeComponent();
            this.Metodo_id = metodo_id;
            this.Tipo_id = tipo_id;
            Motivos();
            this.cboCategoria.SelectedIndex = 0;
            this.CenterToScreen();
        }

        //Editar transacción BD
        public FrmIngresar(int id)
        {
            InitializeComponent();
            Motivos();

            this.Id = id;

            TransaccionesDB OtransaccionDB = new TransaccionesDB();
            Transaccion Otransaccion = OtransaccionDB.Get(id);

            dtpFecha.Value = Otransaccion.Fecha;

            foreach (var item in cboCategoria.Items)
            {
                string motivo = item.ToString();
                if (motivo == Otransaccion.Motivo)
                {
                    cboCategoria.SelectedItem = item;
                    break;
                }
            }

            txtMonto.Text = Otransaccion.Monto.ToString();
            txtDescripcion.Text = Otransaccion.Descripcion;

            //Si es bastante croto sori :(
            if (Otransaccion.Metodo == "efectivo")
                this.Metodo_id = 3;
            else if (Otransaccion.Metodo == "débito")
                this.Metodo_id = 2;
            else
                this.Metodo_id = 1;

            //si funciona no lo toques
            if (Otransaccion.Tipo == "ingreso")
                this.Tipo_id = 1;
            else
                this.Tipo_id = 2;

            //acá termina lo croto

            this.cboCategoria.SelectedIndex = 0;
            this.CenterToScreen();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!(NoVacios() && ValidarNumeros()))
                return;
            try
                {
                    int indiceCBOMotivo = cboCategoria.SelectedIndex + 1;

                    TransaccionesDB transaccionesDB = new TransaccionesDB();
                    if (Id == null)
                    {
                            transaccionesDB.Add(dtpFecha.Value, indiceCBOMotivo, decimal.Parse(txtMonto.Text), this.Metodo_id, this.Tipo_id, txtDescripcion.Text);
                    }
                    else
                    {
                           transaccionesDB.Update((int)Id, dtpFecha.Value, indiceCBOMotivo, decimal.Parse(txtMonto.Text), this.Metodo_id, this.Tipo_id, txtDescripcion.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            this.Close();
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
