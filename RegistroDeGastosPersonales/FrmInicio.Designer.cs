namespace RegistroDeGastosPersonales
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efectivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debitoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblDebito = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtEgresos = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Brown;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.gastosToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efectivoToolStripMenuItem,
            this.debitoToolStripMenuItem});
            this.ingresosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // efectivoToolStripMenuItem
            // 
            this.efectivoToolStripMenuItem.Name = "efectivoToolStripMenuItem";
            this.efectivoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.efectivoToolStripMenuItem.Text = "Efectivo";
            this.efectivoToolStripMenuItem.Click += new System.EventHandler(this.efectivoToolStripMenuItem_Click);
            // 
            // debitoToolStripMenuItem
            // 
            this.debitoToolStripMenuItem.Name = "debitoToolStripMenuItem";
            this.debitoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.debitoToolStripMenuItem.Text = "Debito";
            this.debitoToolStripMenuItem.Click += new System.EventHandler(this.debitoToolStripMenuItem_Click);
            // 
            // gastosToolStripMenuItem
            // 
            this.gastosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efectivoToolStripMenuItem1,
            this.debitoToolStripMenuItem1,
            this.creditoToolStripMenuItem});
            this.gastosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            this.gastosToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gastosToolStripMenuItem.Text = "Egresos";
            // 
            // efectivoToolStripMenuItem1
            // 
            this.efectivoToolStripMenuItem1.Name = "efectivoToolStripMenuItem1";
            this.efectivoToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.efectivoToolStripMenuItem1.Text = "Efectivo";
            this.efectivoToolStripMenuItem1.Click += new System.EventHandler(this.efectivoToolStripMenuItem1_Click);
            // 
            // debitoToolStripMenuItem1
            // 
            this.debitoToolStripMenuItem1.Name = "debitoToolStripMenuItem1";
            this.debitoToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.debitoToolStripMenuItem1.Text = "Debito";
            this.debitoToolStripMenuItem1.Click += new System.EventHandler(this.debitoToolStripMenuItem1_Click);
            // 
            // creditoToolStripMenuItem
            // 
            this.creditoToolStripMenuItem.Name = "creditoToolStripMenuItem";
            this.creditoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.creditoToolStripMenuItem.Text = "Credito";
            this.creditoToolStripMenuItem.Click += new System.EventHandler(this.creditoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.editarToolStripMenuItem.Text = "Editar ";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total ingresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(399, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total egresos";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngresos.Location = new System.Drawing.Point(15, 54);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(0, 18);
            this.lblIngresos.TabIndex = 3;
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgresos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEgresos.Location = new System.Drawing.Point(474, 55);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(0, 18);
            this.lblEgresos.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(161, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "SALDO ACTUAL TOTAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(18, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "EFECTIVO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(222, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "DEBITO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(423, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "CRÉDITO";
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEfectivo.Location = new System.Drawing.Point(18, 214);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(0, 18);
            this.lblEfectivo.TabIndex = 10;
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDebito.Location = new System.Drawing.Point(213, 214);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(0, 18);
            this.lblDebito.TabIndex = 11;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.Crimson;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBalance.Location = new System.Drawing.Point(0, 100);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(510, 73);
            this.txtBalance.TabIndex = 13;
            this.txtBalance.Text = "$";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEgresos
            // 
            this.txtEgresos.BackColor = System.Drawing.Color.Crimson;
            this.txtEgresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEgresos.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEgresos.Location = new System.Drawing.Point(271, 55);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.ReadOnly = true;
            this.txtEgresos.Size = new System.Drawing.Size(227, 17);
            this.txtEgresos.TabIndex = 14;
            this.txtEgresos.Text = "$";
            this.txtEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCredito
            // 
            this.txtCredito.BackColor = System.Drawing.Color.Crimson;
            this.txtCredito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCredito.Location = new System.Drawing.Point(355, 218);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.ReadOnly = true;
            this.txtCredito.Size = new System.Drawing.Size(143, 17);
            this.txtCredito.TabIndex = 15;
            this.txtCredito.Text = "$";
            this.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIngresos
            // 
            this.txtIngresos.BackColor = System.Drawing.Color.Crimson;
            this.txtIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresos.ForeColor = System.Drawing.SystemColors.Window;
            this.txtIngresos.Location = new System.Drawing.Point(15, 58);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.ReadOnly = true;
            this.txtIngresos.Size = new System.Drawing.Size(205, 17);
            this.txtIngresos.TabIndex = 16;
            this.txtIngresos.Text = "$";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.BackColor = System.Drawing.Color.Crimson;
            this.txtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEfectivo.Location = new System.Drawing.Point(15, 218);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.ReadOnly = true;
            this.txtEfectivo.Size = new System.Drawing.Size(140, 17);
            this.txtEfectivo.TabIndex = 17;
            this.txtEfectivo.Text = "$";
            // 
            // txtDebito
            // 
            this.txtDebito.BackColor = System.Drawing.Color.Crimson;
            this.txtDebito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebito.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDebito.Location = new System.Drawing.Point(168, 215);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(181, 17);
            this.txtDebito.TabIndex = 18;
            this.txtDebito.Text = "$";
            this.txtDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(510, 247);
            this.Controls.Add(this.txtDebito);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.txtEgresos);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEgresos);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.Text = "Registro gastos personales";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efectivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem debitoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblEgresos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtEgresos;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.TextBox txtDebito;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}

