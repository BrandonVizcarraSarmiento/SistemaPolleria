namespace SistemaPolleria.presentacion.cajaPagos.pagos
{
    partial class FrmEditarPago
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
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.cboPedido = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCancelarAsistencia = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarAsistencia = new FontAwesome.Sharp.IconButton();
            this.btnEditarPago = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Location = new System.Drawing.Point(41, 206);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(255, 20);
            this.txtMetodoPago.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(38, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "Metodo de pago";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(41, 128);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(255, 20);
            this.txtMonto.TabIndex = 88;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl.Location = new System.Drawing.Point(38, 112);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(37, 13);
            this.lbl.TabIndex = 89;
            this.lbl.Text = "Monto";
            // 
            // cboPedido
            // 
            this.cboPedido.FormattingEnabled = true;
            this.cboPedido.Location = new System.Drawing.Point(41, 88);
            this.cboPedido.Name = "cboPedido";
            this.cboPedido.Size = new System.Drawing.Size(254, 21);
            this.cboPedido.TabIndex = 87;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(41, 167);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(255, 20);
            this.dtpFecha.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(101, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 85;
            this.label2.Text = "Editar Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(38, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Id pedido";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFecha.Location = new System.Drawing.Point(38, 151);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 83;
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
            this.btnCancelarAsistencia.Location = new System.Drawing.Point(215, 242);
            this.btnCancelarAsistencia.Name = "btnCancelarAsistencia";
            this.btnCancelarAsistencia.Size = new System.Drawing.Size(81, 33);
            this.btnCancelarAsistencia.TabIndex = 82;
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
            this.btnLimpiarAsistencia.Location = new System.Drawing.Point(128, 242);
            this.btnLimpiarAsistencia.Name = "btnLimpiarAsistencia";
            this.btnLimpiarAsistencia.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarAsistencia.TabIndex = 81;
            this.btnLimpiarAsistencia.Text = "Limpiar";
            this.btnLimpiarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarAsistencia.UseVisualStyleBackColor = false;
            // 
            // btnEditarPago
            // 
            this.btnEditarPago.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPago.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPago.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditarPago.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarPago.IconSize = 21;
            this.btnEditarPago.Location = new System.Drawing.Point(41, 242);
            this.btnEditarPago.Name = "btnEditarPago";
            this.btnEditarPago.Size = new System.Drawing.Size(81, 33);
            this.btnEditarPago.TabIndex = 80;
            this.btnEditarPago.Text = "Guardar";
            this.btnEditarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarPago.UseVisualStyleBackColor = false;
            this.btnEditarPago.Click += new System.EventHandler(this.btnEditarPago_Click);
            // 
            // FrmEditarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 302);
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
            this.Controls.Add(this.btnEditarPago);
            this.Name = "FrmEditarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarPago";
            this.Load += new System.EventHandler(this.FrmEditarPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cboPedido;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
        private FontAwesome.Sharp.IconButton btnCancelarAsistencia;
        private FontAwesome.Sharp.IconButton btnLimpiarAsistencia;
        private FontAwesome.Sharp.IconButton btnEditarPago;
    }
}