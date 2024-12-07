namespace SistemaPolleria.presentacion.gestion_empleados.turnos
{
    partial class FrmAgregarTurno
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHoraFinTurno = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicioTurno = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardarTurno = new FontAwesome.Sharp.IconButton();
            this.cboNombreTurno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(176, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(47, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Inicio";
            // 
            // dtpHoraFinTurno
            // 
            this.dtpHoraFinTurno.CustomFormat = "";
            this.dtpHoraFinTurno.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinTurno.Location = new System.Drawing.Point(179, 125);
            this.dtpHoraFinTurno.MinDate = new System.DateTime(2024, 5, 6, 0, 0, 0, 0);
            this.dtpHoraFinTurno.Name = "dtpHoraFinTurno";
            this.dtpHoraFinTurno.ShowUpDown = true;
            this.dtpHoraFinTurno.Size = new System.Drawing.Size(126, 20);
            this.dtpHoraFinTurno.TabIndex = 84;
            // 
            // dtpHoraInicioTurno
            // 
            this.dtpHoraInicioTurno.CustomFormat = "";
            this.dtpHoraInicioTurno.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicioTurno.Location = new System.Drawing.Point(50, 125);
            this.dtpHoraInicioTurno.Name = "dtpHoraInicioTurno";
            this.dtpHoraInicioTurno.ShowUpDown = true;
            this.dtpHoraInicioTurno.Size = new System.Drawing.Size(123, 20);
            this.dtpHoraInicioTurno.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(92, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 82;
            this.label2.Text = "Agregar Turno";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDia.Location = new System.Drawing.Point(47, 70);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(86, 13);
            this.lblDia.TabIndex = 80;
            this.lblDia.Text = "Nombre de turno";
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
            this.btnCancelar.Location = new System.Drawing.Point(224, 178);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 33);
            this.btnCancelar.TabIndex = 79;
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
            this.btnLimpiar.Location = new System.Drawing.Point(137, 178);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiar.TabIndex = 78;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarTurno
            // 
            this.btnGuardarTurno.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarTurno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarTurno.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarTurno.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarTurno.IconSize = 21;
            this.btnGuardarTurno.Location = new System.Drawing.Point(50, 178);
            this.btnGuardarTurno.Name = "btnGuardarTurno";
            this.btnGuardarTurno.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarTurno.TabIndex = 77;
            this.btnGuardarTurno.Text = "Guardar";
            this.btnGuardarTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarTurno.UseVisualStyleBackColor = false;
            this.btnGuardarTurno.Click += new System.EventHandler(this.btnGuardarTurno_Click);
            // 
            // cboNombreTurno
            // 
            this.cboNombreTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreTurno.FormattingEnabled = true;
            this.cboNombreTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche",
            "Mediodia",
            "Temprano"});
            this.cboNombreTurno.Location = new System.Drawing.Point(50, 86);
            this.cboNombreTurno.Name = "cboNombreTurno";
            this.cboNombreTurno.Size = new System.Drawing.Size(254, 21);
            this.cboNombreTurno.TabIndex = 88;
            // 
            // FrmAgregarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 235);
            this.Controls.Add(this.cboNombreTurno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHoraFinTurno);
            this.Controls.Add(this.dtpHoraInicioTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardarTurno);
            this.Name = "FrmAgregarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarTurno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHoraFinTurno;
        private System.Windows.Forms.DateTimePicker dtpHoraInicioTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDia;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardarTurno;
        private System.Windows.Forms.ComboBox cboNombreTurno;
    }
}