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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Refresh();
        }

        private new void Refresh()
        {
            HerramientasDB Oherramientas = new HerramientasDB();
            dataGridView1.DataSource = Oherramientas.Get();
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPedirDatos pedirDatos = new frmPedirDatos();
            pedirDatos.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                frmPedirDatos frmPedirDatos = new frmPedirDatos((int)Id);
                frmPedirDatos.ShowDialog();
                Refresh();
            }
            else
            {
                MessageBox.Show("vv debes seleccionar una herramienta para editar 🤦‍", "ay es que tu también", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                HerramientasDB herramientasDB = new HerramientasDB();
                herramientasDB.Delete((int)id);
                Refresh();
            }
        }
    }
}
