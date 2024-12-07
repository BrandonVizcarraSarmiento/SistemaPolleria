namespace SistemaPolleria.presentacion.cajaPagos.pagos
{
    partial class FrmAgregarPago
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
            this.cboPedido = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCancelarAsistencia = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarAsistencia = new FontAwesome.Sharp.IconButton();
            this.btnGuardarPago = new FontAwesome.Sharp.IconButton();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboPedido
            // 
            this.cboPedido.FormattingEnabled = true;
            this.cboPedido.Location = new System.Drawing.Point(27, 90);
            this.cboPedido.Name = "cboPedido";
            this.cboPedido.Size = new System.Drawing.Size(254, 21);
            this.cboPedido.TabIndex = 75;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(27, 169);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(255, 20);
            this.dtpFecha.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(87, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "Agregar Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Id pedido";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFecha.Location = new System.Drawing.Point(24, 153);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 67;
            this.lblFecha.Text = "Fecha";
            // 
            // btnCancelarAsistencia
            // 
            this.btnCancelarAsistencia.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAsistencia.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAsistencia.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelarAsistencia.IconColor = System.Drawing.Color.White;
            this.btnCancelarAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarAsistencia.IconSize = 21;
            this.btnCancelarAsistencia.Location = new System.Drawing.Point(201, 244);
            this.btnCancelarAsistencia.Name = "btnCancelarAsistencia";
            this.btnCancelarAsistencia.Size = new System.Drawing.Size(81, 33);
            this.btnCancelarAsistencia.TabIndex = 66;
            this.btnCancelarAsistencia.Text = "Cancelar";
            this.btnCancelarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarAsistencia.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarAsistencia
            // 
            this.btnLimpiarAsistencia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarAsistencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarAsistencia.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarAsistencia.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarAsistencia.IconSize = 21;
            this.btnLimpiarAsistencia.Location = new System.Drawing.Point(114, 244);
            this.btnLimpiarAsistencia.Name = "btnLimpiarAsistencia";
            this.btnLimpiarAsistencia.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarAsistencia.TabIndex = 65;
            this.btnLimpiarAsistencia.Text = "Limpiar";
            this.btnLimpiarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarAsistencia.UseVisualStyleBackColor = false;
            // 
            // btnGuardarPago
            // 
            this.btnGuardarPago.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPago.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarPago.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarPago.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarPago.IconSize = 21;
            this.btnGuardarPago.Location = new System.Drawing.Point(27, 244);
            this.btnGuardarPago.Name = "btnGuardarPago";
            this.btnGuardarPago.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarPago.TabIndex = 64;
            this.btnGuardarPago.Text = "Guardar";
            this.btnGuardarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarPago.UseVisualStyleBackColor = false;
            this.btnGuardarPago.Click += new System.EventHandler(this.btnGuardarPago_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(27, 130);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(255, 20);
            this.txtMonto.TabIndex = 76;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl.Location = new System.Drawing.Point(24, 114);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(37, 13);
            this.lbl.TabIndex = 77;
            this.lbl.Text = "Monto";
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Location = new System.Drawing.Point(27, 208);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(255, 20);
            this.txtMetodoPago.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(24, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Metodo de pago";
            // 
            // FrmAgregarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 308);
            this.Controls.Add(this.txtMetodoPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cboPedido);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnCancelarAsistencia);
            this.Controls.Add(this.btnLimpiarAsistencia);
            this.Controls.Add(this.btnGuardarPago);
            this.Name = "FrmAgregarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarPago";
            this.Load += new System.EventHandler(this.FrmAgregarPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPedido;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
        private FontAwesome.Sharp.IconButton btnCancelarAsistencia;
        private FontAwesome.Sharp.IconButton btnLimpiarAsistencia;
        private FontAwesome.Sharp.IconButton btnGuardarPago;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.Label label1;
    }
}