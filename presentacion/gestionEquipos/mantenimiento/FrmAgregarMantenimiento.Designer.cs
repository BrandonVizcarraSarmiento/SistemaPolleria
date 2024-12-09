namespace SistemaPolleria.presentacion.gestionEquipos.mantenimiento
{
    partial class FrmAgregarMantenimiento
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
            this.dtpFechaMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Equipo = new System.Windows.Forms.Label();
            this.btnCancelarAsistencia = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarAsistencia = new FontAwesome.Sharp.IconButton();
            this.btnGuardarMantenimiento = new FontAwesome.Sharp.IconButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboIdEquipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpFechaMantenimiento
            // 
            this.dtpFechaMantenimiento.Location = new System.Drawing.Point(46, 122);
            this.dtpFechaMantenimiento.Name = "dtpFechaMantenimiento";
            this.dtpFechaMantenimiento.Size = new System.Drawing.Size(255, 20);
            this.dtpFechaMantenimiento.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(43, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(43, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Fecha de mantenimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(55, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 24);
            this.label2.TabIndex = 96;
            this.label2.Text = "Agregar Mantenimiento";
            // 
            // Equipo
            // 
            this.Equipo.AutoSize = true;
            this.Equipo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Equipo.Location = new System.Drawing.Point(43, 66);
            this.Equipo.Name = "Equipo";
            this.Equipo.Size = new System.Drawing.Size(40, 13);
            this.Equipo.TabIndex = 95;
            this.Equipo.Text = "Equipo";
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
            this.btnCancelarAsistencia.Location = new System.Drawing.Point(220, 202);
            this.btnCancelarAsistencia.Name = "btnCancelarAsistencia";
            this.btnCancelarAsistencia.Size = new System.Drawing.Size(81, 33);
            this.btnCancelarAsistencia.TabIndex = 94;
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
            this.btnLimpiarAsistencia.Location = new System.Drawing.Point(133, 202);
            this.btnLimpiarAsistencia.Name = "btnLimpiarAsistencia";
            this.btnLimpiarAsistencia.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarAsistencia.TabIndex = 93;
            this.btnLimpiarAsistencia.Text = "Limpiar";
            this.btnLimpiarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarAsistencia.UseVisualStyleBackColor = false;
            // 
            // btnGuardarMantenimiento
            // 
            this.btnGuardarMantenimiento.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarMantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMantenimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarMantenimiento.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarMantenimiento.IconSize = 21;
            this.btnGuardarMantenimiento.Location = new System.Drawing.Point(46, 202);
            this.btnGuardarMantenimiento.Name = "btnGuardarMantenimiento";
            this.btnGuardarMantenimiento.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarMantenimiento.TabIndex = 92;
            this.btnGuardarMantenimiento.Text = "Guardar";
            this.btnGuardarMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarMantenimiento.UseVisualStyleBackColor = false;
            this.btnGuardarMantenimiento.Click += new System.EventHandler(this.btnGuardarMantenimiento_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(46, 163);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(255, 20);
            this.txtDescripcion.TabIndex = 101;
            // 
            // cboIdEquipo
            // 
            this.cboIdEquipo.FormattingEnabled = true;
            this.cboIdEquipo.Location = new System.Drawing.Point(46, 82);
            this.cboIdEquipo.Name = "cboIdEquipo";
            this.cboIdEquipo.Size = new System.Drawing.Size(254, 21);
            this.cboIdEquipo.TabIndex = 102;
            // 
            // FrmAgregarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 283);
            this.Controls.Add(this.cboIdEquipo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dtpFechaMantenimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Equipo);
            this.Controls.Add(this.btnCancelarAsistencia);
            this.Controls.Add(this.btnLimpiarAsistencia);
            this.Controls.Add(this.btnGuardarMantenimiento);
            this.Name = "FrmAgregarMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarMantenimiento";
            this.Load += new System.EventHandler(this.FrmAgregarMantenimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaMantenimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Equipo;
        private FontAwesome.Sharp.IconButton btnCancelarAsistencia;
        private FontAwesome.Sharp.IconButton btnLimpiarAsistencia;
        private FontAwesome.Sharp.IconButton btnGuardarMantenimiento;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboIdEquipo;
    }
}