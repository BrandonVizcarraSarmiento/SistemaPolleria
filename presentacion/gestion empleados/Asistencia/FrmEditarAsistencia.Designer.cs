namespace SistemaPolleria.presentacion.gestion_empleados.Asistencia
{
    partial class FrmEditarAsistencia
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
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHoraFinAsistencia = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicioAsistencia = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCancelarAsistencia = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarAsistencia = new FontAwesome.Sharp.IconButton();
            this.btnEditarAsistencia = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(50, 104);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(254, 21);
            this.cboEmpleado.TabIndex = 75;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(50, 143);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(255, 20);
            this.dtpFecha.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(176, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(47, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Inicio";
            // 
            // dtpHoraFinAsistencia
            // 
            this.dtpHoraFinAsistencia.CustomFormat = "";
            this.dtpHoraFinAsistencia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinAsistencia.Location = new System.Drawing.Point(179, 182);
            this.dtpHoraFinAsistencia.MinDate = new System.DateTime(2024, 5, 6, 0, 0, 0, 0);
            this.dtpHoraFinAsistencia.Name = "dtpHoraFinAsistencia";
            this.dtpHoraFinAsistencia.ShowUpDown = true;
            this.dtpHoraFinAsistencia.Size = new System.Drawing.Size(126, 20);
            this.dtpHoraFinAsistencia.TabIndex = 71;
            // 
            // dtpHoraInicioAsistencia
            // 
            this.dtpHoraInicioAsistencia.CustomFormat = "";
            this.dtpHoraInicioAsistencia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicioAsistencia.Location = new System.Drawing.Point(50, 182);
            this.dtpHoraInicioAsistencia.Name = "dtpHoraInicioAsistencia";
            this.dtpHoraInicioAsistencia.ShowUpDown = true;
            this.dtpHoraInicioAsistencia.Size = new System.Drawing.Size(123, 20);
            this.dtpHoraInicioAsistencia.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(88, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "Editar Asistencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(47, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Nombre del empleado";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFecha.Location = new System.Drawing.Point(47, 127);
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
            this.btnCancelarAsistencia.Location = new System.Drawing.Point(224, 235);
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
            this.btnLimpiarAsistencia.Location = new System.Drawing.Point(137, 235);
            this.btnLimpiarAsistencia.Name = "btnLimpiarAsistencia";
            this.btnLimpiarAsistencia.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarAsistencia.TabIndex = 65;
            this.btnLimpiarAsistencia.Text = "Limpiar";
            this.btnLimpiarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarAsistencia.UseVisualStyleBackColor = false;
            // 
            // btnEditarAsistencia
            // 
            this.btnEditarAsistencia.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditarAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAsistencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarAsistencia.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditarAsistencia.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarAsistencia.IconSize = 21;
            this.btnEditarAsistencia.Location = new System.Drawing.Point(50, 235);
            this.btnEditarAsistencia.Name = "btnEditarAsistencia";
            this.btnEditarAsistencia.Size = new System.Drawing.Size(81, 33);
            this.btnEditarAsistencia.TabIndex = 64;
            this.btnEditarAsistencia.Text = "Editar";
            this.btnEditarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarAsistencia.UseVisualStyleBackColor = false;
            this.btnEditarAsistencia.Click += new System.EventHandler(this.btnEditarAsistencia_Click);
            // 
            // FrmEditarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 295);
            this.Controls.Add(this.cboEmpleado);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHoraFinAsistencia);
            this.Controls.Add(this.dtpHoraInicioAsistencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnCancelarAsistencia);
            this.Controls.Add(this.btnLimpiarAsistencia);
            this.Controls.Add(this.btnEditarAsistencia);
            this.Name = "FrmEditarAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarAsistencia";
            this.Load += new System.EventHandler(this.FrmEditarAsistencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHoraFinAsistencia;
        private System.Windows.Forms.DateTimePicker dtpHoraInicioAsistencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
        private FontAwesome.Sharp.IconButton btnCancelarAsistencia;
        private FontAwesome.Sharp.IconButton btnLimpiarAsistencia;
        private FontAwesome.Sharp.IconButton btnEditarAsistencia;
    }
}