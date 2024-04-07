using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroStockHerramientas
{
    public partial class frmPedirDatos : Form
    {
        private int? _id;
        public frmPedirDatos()
        {
            InitializeComponent();
        }
        public frmPedirDatos(int id)
        {
            InitializeComponent();

            this._id = id;
            HerramientasDB herramientasDB = new HerramientasDB();
            Herramienta Oherramienta = herramientasDB.Get((int)this._id);

            txtNombre.Text = Oherramienta.Nombre;
            txtMarca.Text = Oherramienta.Marca;
            txtCodigoEntero.Text = Oherramienta.Codigo.Substring(0, 3);
            txtCodigoLetra.Text = Oherramienta.Codigo.Substring(3);
            txtDescripcion.Text = Oherramienta.Descripcion;
            txtStockMinimo.Text = Oherramienta.Stock_minimo.ToString();
            txtStockMaximo.Text = Oherramienta.Stock_maximo.ToString();
            txtPrecio.Text = Oherramienta.Precio_unitario.ToString();
        }

        private void frmPedirDatos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtCodigoLetra.MaxLength = 3;
            txtCodigoEntero.MaxLength = 3;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (!ValidarVacios() && ValidarEntero() && ValidarLetra() && ValidarStockMaximo())
                return;

            try
            {
                HerramientasDB OherramientasDB = new HerramientasDB();
                string codigo = txtCodigoLetra.Text + txtCodigoEntero.Text;

                if (this._id == null)
                    OherramientasDB.Add(txtNombre.Text, codigo, txtMarca.Text, int.Parse(txtStockMinimo.Text), int.Parse(txtStockMaximo.Text), double.Parse(txtPrecio.Text), txtDescripcion.Text);
                else
                    OherramientasDB.Update((int)_id, txtNombre.Text, codigo, txtMarca.Text, int.Parse(txtStockMinimo.Text), int.Parse(txtStockMaximo.Text), double.Parse(txtPrecio.Text), txtDescripcion.Text);

                MessageBox.Show("Se ingresaron los datos correctamente 😊");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        //----------------------------------------------------------------------//
        
        private bool ValidarVacios()
        {
            bool OK = true;

            if (txtNombre.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNombre, "Nombre no puede estar vacio");
                OK = false;
            }
            if (txtMarca.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtMarca, "Marca no puede estar vacio");
                OK = false;
            }
            if (txtCodigoLetra.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtCodigoLetra, "Codigo Letra no puede estar vacio");
                OK = false;
            }
            if (txtCodigoEntero.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtCodigoEntero, "Codigo Entero no puede estar vacio");
                OK = false;
            }
            if (txtStockMinimo.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtStockMinimo, "Stock Minimo no puede estar vacio");
                OK = false;
            }
            if (txtStockMaximo.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtStockMaximo, "Stock Maximo no puede estar vacio");
                OK = false;
            }
            if (txtPrecio.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtPrecio, "Precio no puede estar vacio");
                OK = false;
            }
            return OK;
        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtMarca, "");
            errorProvider1.SetError(txtCodigoLetra, "");
            errorProvider1.SetError(txtCodigoEntero, "");
            errorProvider1.SetError(txtStockMinimo, "");
            errorProvider1.SetError(txtStockMaximo, "");
            errorProvider1.SetError(txtPrecio, "");
        }
        private bool ValidarLetra()
        {
            bool OK = true;
            foreach (char letra in txtCodigoLetra.Text.Trim())
            {
                if (!char.IsLetter(letra))
                {
                    errorProvider1.SetError(txtCodigoLetra, "Solo letras");
                    OK = false;
                }
            }
            return OK;
        }
        private bool ValidarEntero()
        {
            bool OK = true;
            int num;
            if (!int.TryParse(txtCodigoEntero.Text, out num))
            {
                errorProvider1.SetError(txtCodigoEntero, "Debe ser un número entero");
                OK = false;
            }
            if (!int.TryParse(txtStockMinimo.Text, out num))
            {
                errorProvider1.SetError(txtStockMinimo, "Debe ser un número entero");
                OK = false;
            }
            if (!int.TryParse(txtStockMaximo.Text, out num))
            {
                errorProvider1.SetError(txtStockMaximo, "Debe ser un número entero");
                OK = false;
            }
            if (!double.TryParse(txtPrecio.Text, out double num1))
            {
                errorProvider1.SetError(txtPrecio, "Debe ser un número con decimales");
                OK = false;
            }
            return OK;
        }
        private bool ValidarStockMaximo()
        {
            bool OK = true;
            if(int.Parse(txtStockMaximo.Text) < int.Parse(txtStockMinimo.Text))
            {
                errorProvider1.SetError(txtStockMaximo, "No puede ser menor que Stock Minimo");
                OK = false;
            }
            return OK;
        }
    }
}
