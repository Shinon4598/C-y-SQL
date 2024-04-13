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
            Balance();
        }
        

        public void Ingresar(int metodo, int tipo_id)
        {
            FrmIngresar frmIngresar = new FrmIngresar(metodo, tipo_id);
            frmIngresar.ShowDialog();
            Balance();

        }


        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas frmListas = new frmListas();
            frmListas.ShowDialog();
            Balance();


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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas frmListas = new frmListas(true);
            frmListas.ShowDialog();
            Balance();

        }

        //mostrar Balance
        public void Balance()
        {
            TransaccionesDB transaccionesDB = new TransaccionesDB();
            List<Balance> transacciones = transaccionesDB.GetBalance();

            decimal total = 0;

            decimal ingresos = 0;
            decimal gastos = 0;

            decimal efectivo = 0;
            decimal debito = 0;
            decimal credito = 0;

            foreach (Balance Obalance in transacciones)
            {
                decimal monto = Obalance.Tipo == "ingreso" ? Obalance.Monto : -Obalance.Monto;

                //Metodo
                if (Obalance.Metodo == "efectivo")
                {
                    efectivo += monto;
                }
                else if (Obalance.Metodo == "debito")
                {
                    debito += monto;
                }
                else if (Obalance.Metodo == "credito")
                {
                    credito -= monto;
                }

                //Tipo
                if (Obalance.Tipo == "ingreso")
                {
                    ingresos += Obalance.Monto;
                }
                else if (Obalance.Tipo == "gasto")
                {
                    gastos += Obalance.Monto;
                }

                total += monto;
            }
            txtBalance.Text = string.Format("{0:C}", total);
            txtCredito.Text = string.Format("{0:C}", credito);
            txtDebito.Text = string.Format("{0:C}", debito);
            txtEfectivo.Text = string.Format("{0:C}", efectivo);
            txtIngresos.Text = string.Format("{0:C}", ingresos);
            txtEgresos.Text = string.Format("{0:C}", gastos);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas frmListas = new frmListas(1);
            frmListas.ShowDialog();
            Balance();
        }
    }
}
