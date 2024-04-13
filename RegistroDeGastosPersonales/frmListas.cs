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
    public partial class frmListas : Form
    {
        private bool _editar = false;
        public frmListas()
        {
            InitializeComponent();
        }
        public frmListas(bool editar = true)
        {
            InitializeComponent();
            this._editar = editar;
            lblEditar.Text = "Selecciona la fila a Editar";
        }
        private void frmListas_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Refresh();
            cmbFiltros.SelectedIndex = 0;
            cmbFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private new void Refresh()
        {
            TransaccionesDB transaccionesDB = new TransaccionesDB();
            dgvTransacciones.DataSource = transaccionesDB.Get();
        }


        private void dgvTransacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!_editar)
                return;

            if (dgvTransacciones.SelectedRows.Count > 0)
            {
                FrmIngresar frmIngresar = new FrmIngresar(Convert.ToInt32(dgvTransacciones.Rows[dgvTransacciones.CurrentRow.Index].Cells[0].Value.ToString()));
                frmIngresar.ShowDialog();
            }
        }
    }
}
