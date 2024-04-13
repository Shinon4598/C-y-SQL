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
        public frmListas()
        {
            InitializeComponent();
        }
        public frmListas(bool editar)
        {
            InitializeComponent();
            lblEditar.Visible = true;
            btnEditar.Visible = true;
        }
        public frmListas(int borrar)
        {
            InitializeComponent();
            btnBorrar.Visible = true;
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
            if (dgvTransacciones.SelectedRows.Count > 0)
            {
                FrmIngresar frmIngresar = new FrmIngresar(Convert.ToInt32(dgvTransacciones.Rows[dgvTransacciones.CurrentRow.Index].Cells[0].Value.ToString()));
                frmIngresar.ShowDialog();
                Refresh();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvTransacciones.SelectedRows.Count > 0)
            {
                TransaccionesDB transaccion = new TransaccionesDB();
                transaccion.Delete(Convert.ToInt32(dgvTransacciones.Rows[dgvTransacciones.CurrentRow.Index].Cells[0].Value.ToString()));
                Refresh();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int indice = cmbFiltros.SelectedIndex;
            TransaccionesDB transaccionesDB = new TransaccionesDB();

            switch (indice)
            {
                case 0: Refresh();
                    break;
                case 1: dgvTransacciones.DataSource = transaccionesDB.MasReciente();
                    break;
                case 2: dgvTransacciones.DataSource = transaccionesDB.MasAntiguo();
                    break;
                case 3: dgvTransacciones.DataSource = transaccionesDB.GetForPayMent("efectivo");
                    break;
                case 4: dgvTransacciones.DataSource = transaccionesDB.GetForPayMent("debito");
                    break;
                case 5: dgvTransacciones.DataSource = transaccionesDB.GetForPayMent("credito");
                    break;

            }
        }
    }
}
