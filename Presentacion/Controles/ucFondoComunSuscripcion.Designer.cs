﻿namespace Presentacion.Controles
{
    partial class ucFondoComunSuscripcion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtValorCuotaparte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCuentaBancaria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBancos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFondo = new System.Windows.Forms.ComboBox();
            this.cmsFondo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantCuotaparte = new System.Windows.Forms.TextBox();
            this.cmsFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValorCuotaparte
            // 
            this.txtValorCuotaparte.Location = new System.Drawing.Point(340, 46);
            this.txtValorCuotaparte.Name = "txtValorCuotaparte";
            this.txtValorCuotaparte.ShortcutsEnabled = false;
            this.txtValorCuotaparte.Size = new System.Drawing.Size(118, 20);
            this.txtValorCuotaparte.TabIndex = 3;
            this.txtValorCuotaparte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorCuotaparte.TextChanged += new System.EventHandler(this.txtValorCuotaparte_TextChanged);
            this.txtValorCuotaparte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCuotaparte_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 424;
            this.label5.Text = "Val. Cuotaparte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 422;
            this.label4.Text = "Nro de Cuenta:";
            // 
            // cbCuentaBancaria
            // 
            this.cbCuentaBancaria.FormattingEnabled = true;
            this.cbCuentaBancaria.Location = new System.Drawing.Point(340, 13);
            this.cbCuentaBancaria.Name = "cbCuentaBancaria";
            this.cbCuentaBancaria.Size = new System.Drawing.Size(118, 21);
            this.cbCuentaBancaria.TabIndex = 1;
            this.cbCuentaBancaria.SelectedIndexChanged += new System.EventHandler(this.cbCuentaBancaria_SelectedIndexChanged);
            this.cbCuentaBancaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCuentaBancaria_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 421;
            this.label2.Text = "Banco:";
            // 
            // cbBancos
            // 
            this.cbBancos.FormattingEnabled = true;
            this.cbBancos.Location = new System.Drawing.Point(55, 13);
            this.cbBancos.Name = "cbBancos";
            this.cbBancos.Size = new System.Drawing.Size(173, 21);
            this.cbBancos.TabIndex = 0;
            this.cbBancos.SelectedIndexChanged += new System.EventHandler(this.cbBancos_SelectedIndexChanged);
            this.cbBancos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBancos_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 426;
            this.label1.Text = "Fondo:";
            // 
            // cbFondo
            // 
            this.cbFondo.ContextMenuStrip = this.cmsFondo;
            this.cbFondo.FormattingEnabled = true;
            this.cbFondo.Location = new System.Drawing.Point(55, 45);
            this.cbFondo.Name = "cbFondo";
            this.cbFondo.Size = new System.Drawing.Size(173, 21);
            this.cbFondo.TabIndex = 2;
            this.cbFondo.SelectedIndexChanged += new System.EventHandler(this.cbFondo_SelectedIndexChanged);
            // 
            // cmsFondo
            // 
            this.cmsFondo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.cmsFondo.Name = "cmsFondo";
            this.cmsFondo.Size = new System.Drawing.Size(117, 26);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(340, 78);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ShortcutsEnabled = false;
            this.txtImporte.Size = new System.Drawing.Size(118, 20);
            this.txtImporte.TabIndex = 4;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.TextChanged += new System.EventHandler(this.txtImporte_TextChanged);
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 428;
            this.label3.Text = "Importe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 429;
            this.label6.Text = "Cant. Cuotaparte:";
            // 
            // txtCantCuotaparte
            // 
            this.txtCantCuotaparte.Location = new System.Drawing.Point(135, 78);
            this.txtCantCuotaparte.Name = "txtCantCuotaparte";
            this.txtCantCuotaparte.ReadOnly = true;
            this.txtCantCuotaparte.ShortcutsEnabled = false;
            this.txtCantCuotaparte.Size = new System.Drawing.Size(93, 20);
            this.txtCantCuotaparte.TabIndex = 4;
            this.txtCantCuotaparte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ucFondoComunSuscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCantCuotaparte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFondo);
            this.Controls.Add(this.txtValorCuotaparte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCuentaBancaria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBancos);
            this.Name = "ucFondoComunSuscripcion";
            this.Size = new System.Drawing.Size(469, 106);
            this.cmsFondo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtValorCuotaparte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbCuentaBancaria;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbBancos;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbFondo;
        private System.Windows.Forms.ContextMenuStrip cmsFondo;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        public System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCantCuotaparte;
    }
}
