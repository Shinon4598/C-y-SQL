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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        

        public void Ingresar(int metodo, int tipo_id)
        {
            FrmIngresar frmIngresar = new FrmIngresar(metodo, tipo_id);
            frmIngresar.ShowDialog();
        }
        

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas frmListas = new frmListas();
            frmListas.ShowDialog();
            
        }

        private void debitoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Débito Gasto
            Ingresar(2, 2);
        }

        private void efectivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Efectivo Gasto
            Ingresar(3, 2);
        }
        private void efectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Efectivo Ingreso
            Ingresar(3, 1);

        }
        private void debitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Débito Ingreso
            Ingresar(2, 1);
        }
        private void creditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crédito Gasto
            Ingresar(1, 2);
        }

       
    }
}
