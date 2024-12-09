namespace SistemaPolleria.presentacion.gestionPedidosVentas.detallePedido
{
    partial class FrmAgregarDetallePedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboPlato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardarDetallePedido = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cboIdPedido = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboPlato
            // 
            this.cboPlato.FormattingEnabled = true;
            this.cboPlato.Location = new System.Drawing.Point(53, 125);
            this.cboPlato.Name = "cboPlato";
            this.cboPlato.Size = new System.Drawing.Size(254, 21);
            this.cboPlato.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(50, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "Nombre de plato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(50, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 121;
            this.label6.Text = "Precio Unitario";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(53, 204);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(255, 20);
            this.txtPrecioUnitario.TabIndex = 120;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFecha.Location = new System.Drawing.Point(50, 149);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 13);
            this.lblFecha.TabIndex = 118;
            this.lblFecha.Text = "Cantidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 21;
            this.btnCancelar.Location = new System.Drawing.Point(226, 269);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 33);
            this.btnCancelar.TabIndex = 117;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 21;
            this.btnLimpiar.Location = new System.Drawing.Point(139, 269);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiar.TabIndex = 116;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarDetallePedido
            // 
            this.btnGuardarDetallePedido.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarDetallePedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarDetallePedido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarDetallePedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDetallePedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarDetallePedido.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarDetallePedido.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarDetallePedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarDetallePedido.IconSize = 21;
            this.btnGuardarDetallePedido.Location = new System.Drawing.Point(52, 269);
            this.btnGuardarDetallePedido.Name = "btnGuardarDetallePedido";
            this.btnGuardarDetallePedido.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarDetallePedido.TabIndex = 115;
            this.btnGuardarDetallePedido.Text = "Guardar";
            this.btnGuardarDetallePedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDetallePedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarDetallePedido.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(68, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 24);
            this.label2.TabIndex = 114;
            this.label2.Text = "Agregar detalle pedido";
            // 
            // cboIdPedido
            // 
            this.cboIdPedido.FormattingEnabled = true;
            this.cboIdPedido.Location = new System.Drawing.Point(53, 87);
            this.cboIdPedido.Name = "cboIdPedido";
            this.cboIdPedido.Size = new System.Drawing.Size(254, 21);
            this.cboIdPedido.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(52, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "ID pedido";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(52, 165);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(255, 20);
            this.txtCantidad.TabIndex = 126;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(49, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 128;
            this.label4.Text = "Sub Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(52, 243);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(255, 20);
            this.txtSubTotal.TabIndex = 127;
            // 
            // FrmAgregarDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboIdPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPlato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardarDetallePedido);
            this.Controls.Add(this.label2);
            this.Name = "FrmAgregarDetallePedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarDetallePedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPlato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblFecha;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardarDetallePedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboIdPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubTotal;
    }
}